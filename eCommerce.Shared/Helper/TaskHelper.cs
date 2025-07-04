using Microsoft.Extensions.Caching.Memory;
using System.Text.Json;

namespace ECommerce.Shared
{
    public class TaskHelper
    {
        public static readonly SemaphoreSlim GlobalSemaphore = new SemaphoreSlim(30);
        /// <summary>
        /// Chạy một danh sách tác vụ I/O-bound song song, trả về kết quả theo đúng thứ tự đầu vào.
        /// </summary>
        /// <typeparam name="T">Kiểu dữ liệu kết quả của các tác vụ.</typeparam>
        /// <param name="tasks">Danh sách các tác vụ (Func<Task<T>>).</param>
        /// <param name="maxConcurrency">Số lượng tác vụ tối đa chạy đồng thời (mặc định 10).</param>
        /// <param name="cancellationToken">Token để hủy tác vụ nếu cần.</param>
        /// <returns>Danh sách kết quả từ các tác vụ, theo đúng thứ tự đầu vào.</returns>
        public static async Task<List<(bool IsSuccess, T result, Exception error)>> RunParallelTasksCPUBoundAsync<T>(IEnumerable<Func<Task<T>>> tasks, int maxConcurrency = 4, CancellationToken cancellationToken = default)
        {
            //check input
            if (tasks == null || !tasks.Any())
                return new List<(bool, T, Exception )>();

            var taskList = tasks.ToList();
            var results = new List<(bool, T, Exception)>(new (bool IsSuccess, T result, Exception error)[taskList.Count]);

            var indexedTasks = taskList.Select((taskFunc, index) => Task.Run(async () =>
            {
                await GlobalSemaphore.WaitAsync(cancellationToken);
                try
                {
                    var result = await taskFunc().ConfigureAwait(false);
                    //results[index] = result;
                    return (index, true, result, (Exception)null);
                }
                catch (Exception ex)
                {
                    return (index, false, default, ex);
                }
                finally
                {
                    GlobalSemaphore.Release();
                }
            })).ToList();

            var completedTasks = await Task.WhenAll(indexedTasks).ConfigureAwait(false);
            results.AddRange(completedTasks.Select(t => (t.Item2, t.Item3, t.Item4)));

            return results;
        }
        public static async Task<List<(bool IsSuccess, T result, Exception error)>> RunParallelTasksIOBoundAsync<T>(IEnumerable<Func<Task<T>>> taskFactories, int maxConcurrency = 4, CancellationToken cancellationToken = default)
        {
            //check input
            if (taskFactories == null || !taskFactories.Any())
                return new List<(bool, T, Exception)>();

            var taskList = taskFactories.ToList();
            var results = new List<(bool, T, Exception)>(new (bool IsSuccess, T result, Exception error)[taskList.Count]);

            var indexedTasks = taskList.Select((taskFunc, index) =>
            ExecuteWithSemaphore(taskFunc, index, GlobalSemaphore, cancellationToken)).ToList();

            var completedTasks = await Task.WhenAll(indexedTasks).ConfigureAwait(false);
            foreach (var (index, isSuccess, result, error) in completedTasks)
            {
                results[index] = (isSuccess, result, error);
            }

            return results.ToList();
        }
        private static async Task<(int Index, bool IsSuccess, T Result, Exception Error)> ExecuteWithSemaphore<T>(
            Func<Task<T>> taskFunc,
            int index,
            SemaphoreSlim semaphore,
            CancellationToken cancellationToken)
        {
            await semaphore.WaitAsync(cancellationToken);
            try
            {
                var result = await taskFunc().ConfigureAwait(false);
                return (index, true, result, null);
            }
            catch (Exception ex)
            {
                return (index, false, default, ex);
            }
            finally
            {
                semaphore.Release();
            }
        }
        public async Task<List<bool>> RunWithThrottlingAsyncOrdered(
                List<Func<Task<bool>>> tasks,
                int maxDegreeOfParallelism)
        {
            var semaphore = new SemaphoreSlim(maxDegreeOfParallelism);
            var results = new bool[tasks.Count];

            var taskList = tasks.Select((taskFunc, index) => Task.Run(async () =>
            {
                await semaphore.WaitAsync();
                try
                {
                    var result = await taskFunc();
                    results[index] = result;
                }
                finally
                {
                    semaphore.Release();
                }
            })).ToList();

            await Task.WhenAll(taskList);
            return results.ToList();
        }
    }
}


