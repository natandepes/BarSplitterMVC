using System;
using BarSplitterMVC.Models;
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
            var items = new List<Item>()
            {
                new Item() { Nome = "Heineken", Valor = 8 },
                new Item() { Nome = "Coxinha", Valor = 5 }
            };

            return View(items);
        }

    }
}

