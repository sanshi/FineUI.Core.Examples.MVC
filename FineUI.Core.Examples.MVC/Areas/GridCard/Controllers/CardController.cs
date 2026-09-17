using Microsoft.AspNetCore.Mvc;


namespace FineUI.Core.Examples.MVC.Areas.GridCard.Controllers
{
    [Area("GridCard")]
    public class CardController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridCard/Card
        public IActionResult Index()
        {
            return View();
        }


    }
}
