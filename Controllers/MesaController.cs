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
            return View(mesa); 
        }

        public IActionResult CriarUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdicionarUsuario()
        {
            var idGerado = mesa.Usuarios.Count > 0 ? mesa.Usuarios.Max(i => i.Id) + 1 : 1;
            var novoUsuario = new Usuario { Id = idGerado, Nome = "FABAO", Admin = false, Conta = 0 };
            mesa.Usuarios.Add(novoUsuario);

            return View("Index");

        }

    }
}
