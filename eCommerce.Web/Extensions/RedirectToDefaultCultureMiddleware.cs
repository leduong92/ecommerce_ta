namespace eCommerce.Web.Extensions
{
    public class RedirectToDefaultCultureMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IList<string> _supportedCultures;
        private readonly string _defaultCulture;

        public RedirectToDefaultCultureMiddleware(RequestDelegate next, IList<string> supportedCultures, string defaultCulture)
        {
            _next = next;
            _supportedCultures = supportedCultures;
            _defaultCulture = defaultCulture;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var path = context.Request.Path.Value;

            if (!string.IsNullOrWhiteSpace(path))
            {
                var segments = path.Split('/', StringSplitOptions.RemoveEmptyEntries);

                if (segments.Length == 0 || !_supportedCultures.Contains(segments[0]))
                {
                    var newPath = $"/{_defaultCulture}{context.Request.Path}{context.Request.QueryString}";
                    context.Response.Redirect(newPath);
                    return;
                }
            }

            await _next(context);
        }
    }
}
