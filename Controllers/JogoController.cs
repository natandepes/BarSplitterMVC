using BarSplitterMVC.Data;
using BarSplitterMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BarSplitterMVC.Controllers
{
    public class JogoController : Controller
    {
        private readonly Context _contextService;

        private Jogo jogo = new Jogo();

        public JogoController(Context contextService) 
        {
            _contextService = contextService;
        }


        public async Task<IActionResult> Index()
        {
            jogo.Usuarios = await _contextService.Usuario.ToListAsync();

            return View();
        }

        //public void GetUsers(List<Usuario>? users)
        //{

        //    jogo.Usuarios = users ?? new List<Usuario>();

        //    Console.WriteLine(jogo);

        //}
    }
}
