using System;
using Microsoft.AspNetCore.Mvc;

namespace BarSplitterMVC.Controllers
{
	public class ItemController : Controller
	{
		public ItemController ()
		{
		}
        public IActionResult Index()
        {
            return View();
        }
    }
}

