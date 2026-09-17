using Microsoft.AspNetCore.Mvc;


namespace FineUI.Core.Examples.MVC.Areas.GridCard.Controllers
{
    [Area("GridCard")]
    public class CardSwitchController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridCard/CardSwitch
        public IActionResult Index()
        {
            return View();
        }


    }
}
