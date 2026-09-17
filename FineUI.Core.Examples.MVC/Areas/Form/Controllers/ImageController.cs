using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class ImageController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/Image
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click(int imageWidth)
        {
            var Image3 = UIHelper.Image("Image3");

            if (imageWidth == 32)
            {
                Image3.ImageWidth(64);
                Image3.ImageHeight(64);
            }
            else
            {
                Image3.ImageWidth(32);
                Image3.ImageHeight(32);
            }

            return UIHelper.Result();
        }

    }
}