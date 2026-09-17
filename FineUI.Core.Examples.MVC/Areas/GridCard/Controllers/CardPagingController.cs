using Microsoft.AspNetCore.Mvc;


namespace FineUI.Core.Examples.MVC.Areas.GridCard.Controllers
{
    [Area("GridCard")]
    public class CardPagingController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridCard/CardPaging
        public IActionResult Index()
        {
            return View();
        }


    }
}
