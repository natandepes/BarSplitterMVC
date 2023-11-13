using BarSplitterMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BarSplitterMVC.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        // Metodo de acao que carrega home 
        public IActionResult Index()
        {
            // Recebendo dados da pagina inicial
            Home home = new Home();
            home.loginUsuario = "Frederico Pitol";
            home.loginSenha = "123456";

            // Retornando dados para a view
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}