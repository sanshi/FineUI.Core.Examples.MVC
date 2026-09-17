using Microsoft.AspNetCore.Mvc;


namespace FineUI.Core.Examples.MVC.Areas.GridCard.Controllers
{
    [Area("GridCard")]
    public class CardAvatarController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridCard/CardAvatar
        public IActionResult Index()
        {
            return View();
        }


    }
}
