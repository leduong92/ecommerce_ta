﻿using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Web.Controllers
{
    public class SettingsController : BaseController
    {
        public SettingsController()
        {
            
        }
        [HttpPost]
        public IActionResult SetRegion(string regionCode)
        {
            Response.Cookies.Append("region", regionCode,
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddDays(30) });

            return Redirect(Request.Headers["Referer"].ToString()); 
        }
        [HttpPost]
        public IActionResult SetLocalization(string languageCode)
        {
            Response.Cookies.Append("language", languageCode,
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddDays(30) });

            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
