using Microsoft.AspNetCore.Mvc;


namespace FineUI.Core.Examples.MVC.Areas.GridCard.Controllers
{
    [Area("GridCard")]
    public class CardSwitchAvatarController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridCard/CardSwitchAvatar
        public IActionResult Index()
        {
            return View();
        }


    }
}
