﻿using Microsoft.AspNetCore.Mvc;

namespace CarrBook.WebUI.ViewComponents.AboutViewComponents
{
	public class _BecomeADriverComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
