using Microsoft.AspNetCore.Mvc;

namespace CarrBook.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _HeadUILayoutcomponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
