using System;
using BarSplitterMVC.Data;
using BarSplitterMVC.Models;
using Microsoft.AspNetCore.Mvc; // importa do controller
using Microsoft.EntityFrameworkCore;

namespace BarSplitterMVC.Controllers
{
	//Precisa herdar da classe controller para funcionar
	public class MesaController : Controller
	{
        private readonly Context _contextService;

        private Mesa mesa = new Mesa();

		public MesaController(Context contextService)
		{
            _contextService = contextService;
		}


        public async Task<IActionResult> Index()
        {
            mesa = await _contextService.Mesa.FirstAsync();

            mesa.Usuarios = await _contextService.Usuario.ToListAsync();

            return View(mesa); 
        }

        public IActionResult CriarUsuario()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarUsuario(string nome)
        {
            Usuario novoUsuario = new Usuario { Nome = nome, Admin = false};

            await _contextService.AddAsync(novoUsuario);
            await _contextService.SaveChangesAsync();

            return RedirectToAction("Index");

        }

    }
}
