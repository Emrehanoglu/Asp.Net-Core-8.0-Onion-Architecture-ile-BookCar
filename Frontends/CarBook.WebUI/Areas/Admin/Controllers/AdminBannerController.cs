using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    public class AdminBannerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
