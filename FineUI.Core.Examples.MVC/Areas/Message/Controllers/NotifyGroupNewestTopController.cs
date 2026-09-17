using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Message.Controllers
{
    [Area("Message")]
    public class NotifyGroupNewestTopController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Message/NotifyGroupNewestTop
        public IActionResult Index()
        {
            return View();
        }


    }
}