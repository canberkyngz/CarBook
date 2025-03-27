using Microsoft.AspNetCore.Mvc;

namespace CarrBook.WebUI.ViewComponents.CarDetailViewComponents
{
	public class _CarDetailTabPaneComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
