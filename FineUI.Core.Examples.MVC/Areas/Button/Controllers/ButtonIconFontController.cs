using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;


namespace FineUI.Core.Examples.MVC.Areas.Button.Controllers
{
    [Area("Button")]
    public class ButtonIconFontController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Button/ButtonIconFont
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnCustomIconFont_Click(string iconFont)
        {
            var btnCustomIconFont = UIHelper.Button("btnCustomIconFont");

            if (iconFont == "f-iconfont-volume-up")
            {
                btnCustomIconFont.IconFont(IconFont._VolumeDown);
            }
            else if (iconFont == "f-iconfont-volume-down")
            {
                btnCustomIconFont.IconFont(IconFont._VolumeOff);
            }
            else
            {
                btnCustomIconFont.IconFont(IconFont._VolumeUp);
            }

            return UIHelper.Result();
        }
    }
}