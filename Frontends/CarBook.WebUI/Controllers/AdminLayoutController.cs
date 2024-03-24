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
    public IActionResult AdminNavbarPartial()
    {
        return PartialView();
    }
    public IActionResult AdminSidebarPartial()
    {
        return PartialView();
    }
    public IActionResult AdminFooterPartial()
    {
        return PartialView();
    }
    public IActionResult AdminScriptPartial()
    {
        return PartialView();
    }
}
