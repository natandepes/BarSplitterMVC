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
                new Usuario { Id = 1, Nome = "Natan", Admin = true, Conta = 0 },
                new Usuario { Id = 2, Nome = "Fred", Admin = false, Conta = 0 },
                new Usuario { Id = 3, Nome = "Lucas Bragança", Admin = true, Conta = 0 },
                new Usuario { Id = 4, Nome = "Lia", Admin = true, Conta = 0 },
                new Usuario { Id = 5, Nome = "Lucas André", Admin = false, Conta = 0 }
            };
		}

        public IActionResult Index()
        {
            return View(mesa); 
        }

        //[HttpPost]
        //public IActionResult RealizarSoma(int numero1, int numero2)
        //{
        //    int resultado = numero1 + numero2;
        //    return Json(new { Resultado = resultado });
        //}
    }
}

