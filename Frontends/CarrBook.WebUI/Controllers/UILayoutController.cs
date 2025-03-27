using Microsoft.AspNetCore.Mvc;

namespace CarrBook.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
