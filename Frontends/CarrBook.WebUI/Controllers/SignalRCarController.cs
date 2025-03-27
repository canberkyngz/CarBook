using Microsoft.AspNetCore.Mvc;

namespace CarrBook.WebUI.Controllers
{
    public class SignalRCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
