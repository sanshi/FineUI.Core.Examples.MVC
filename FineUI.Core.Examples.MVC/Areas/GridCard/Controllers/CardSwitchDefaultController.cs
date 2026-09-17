using Microsoft.AspNetCore.Mvc;


namespace FineUI.Core.Examples.MVC.Areas.GridCard.Controllers
{
    [Area("GridCard")]
    public class CardSwitchDefaultController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridCard/CardSwitchDefault
        public IActionResult Index()
        {
            return View();
        }


    }
}
