using eCommerce.Application.Dtos;

namespace eCommerce.Web.ViewModels
{
    public class NavMenuViewModel
    {
        public List<LanguageDto> Languages { get; set; }
        public List<RegionDto> Regions { get; set; }
    }
}
