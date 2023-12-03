using BarSplitterMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BarSplitterMVC.Controllers
{
    public class JogoController : Controller
    {

        Jogo jogo = new Jogo();

        public JogoController() 
        {
            jogo.Usuarios = new List<Usuario>
            {
                new Usuario { Id = 1, Nome = "Natan", Admin = true, Conta = 0 },
                new Usuario { Id = 2, Nome = "Fred", Admin = false, Conta = 0 },
                new Usuario { Id = 3, Nome = "Lucas Bragança", Admin = true, Conta = 0 },
                new Usuario { Id = 4, Nome = "Lia", Admin = true, Conta = 0 },
                new Usuario { Id = 5, Nome = "Lucas André", Admin = false, Conta = 0 }
            };
        }


        public IActionResult Index(List<Usuario>? users)
        {

            Console.WriteLine(users);

            return View();
        }

        //public void GetUsers(List<Usuario>? users)
        //{

        //    jogo.Usuarios = users ?? new List<Usuario>();

        //    Console.WriteLine(jogo);

        //}
    }
}
