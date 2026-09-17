using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MobileAccordion.Controllers
{
    [Area("MobileAccordion")]
    public class AccordionController : FineUI.Core.Examples.MVC.Controllers.BaseMobileController
    {
        // GET: MobileAccordion/Accordion
        public IActionResult Index()
        {
            return View();
        }


    }
}