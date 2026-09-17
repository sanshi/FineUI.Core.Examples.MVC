using Microsoft.AspNetCore.Mvc;


namespace FineUI.Core.Examples.MVC.Areas.GridCard.Controllers
{
    [Area("GridCard")]
    public class CardShowSelectedRowController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridCard/CardShowSelectedRow
        public IActionResult Index()
        {
            return View();
        }


    }
}
