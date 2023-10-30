using System;
using Microsoft.AspNetCore.Mvc; // importa do controller

namespace BarSplitterMVC.Controllers
{
	//Precisa herdar da classe controller para funcionar
	public class MesaController : Controller
	{
		public MesaController()
		{
		}
        public IActionResult Index()
        {
            return View();
        }
    }
}

