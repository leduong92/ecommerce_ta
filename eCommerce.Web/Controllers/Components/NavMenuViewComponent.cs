using eCommerce.Web.Services;
using eCommerce.Web.Services.IService;
using eCommerce.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Web.Controllers.Components
{
    public class NavMenuViewComponent : ViewComponent
    {
        private readonly IRegionApiClient _regionApiClient;
        private readonly ILanguageApiClient _languageApiClient;

        public NavMenuViewComponent(IRegionApiClient regionApiClient, ILanguageApiClient languageApiClient)
        {
            _regionApiClient = regionApiClient;
            _languageApiClient = languageApiClient;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var languages = await _languageApiClient.GetLanguagesAsync();
            var regions = await _regionApiClient.GetRegionsAsync();

            ViewBag.SelectedLanguage = Request.Cookies["language"] ?? "en";
            ViewBag.SelectedRegion = Request.Cookies["region"] ?? "US";

            ViewBag.Languages = languages.Data;
            ViewBag.Regions = regions.Data;

            var response = new NavMenuViewModel()
            {
                Languages = languages.Data,
                Regions = regions.Data
            };

            return View(response);
        }
    }
}
