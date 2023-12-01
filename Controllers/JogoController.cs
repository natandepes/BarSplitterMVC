using Microsoft.AspNetCore.Mvc;

namespace BarSplitterMVC.Controllers
{
    public class JogoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
