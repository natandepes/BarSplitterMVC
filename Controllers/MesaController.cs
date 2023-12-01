using System;
using BarSplitterMVC.Models;
using Microsoft.AspNetCore.Mvc; // importa do controller

namespace BarSplitterMVC.Controllers
{
	//Precisa herdar da classe controller para funcionar
	public class MesaController : Controller
	{

        Mesa mesa = new Mesa();

		public MesaController()
		{
            mesa.Usuarios = new List<Usuario>
            {
                new Usuario { Id = 1, Nome = "Natan", Admin = true, Conta = 0  },
                new Usuario { Id = 2, Nome = "Fred", Admin = false, Conta = 0 },
                new Usuario { Id = 3, Nome = "Lucas Bragança", Admin = true, Conta = 0 },
                new Usuario { Id = 4, Nome = "Lia", Admin = true, Conta = 0 },
                new Usuario { Id = 5, Nome = "Lucas André", Admin = false, Conta = 0 }
            };
		}

        public IActionResult Index()
        {
            var items = new List<Item>()
            {
                new Item() { Nome = "Heineken", Valor = 8 },
                new Item() { Nome = "Coxinha", Valor = 5 }
            };

            return View(mesa);
        }

    }
}

