using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers;

public class AdminLayoutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult AdminHeaderPartial()
    {
        return PartialView();
    }
}
