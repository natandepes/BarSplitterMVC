using System;
using BarSplitterMVC.Data;
using BarSplitterMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BarSplitterMVC.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly Context _contextService;

        private Usuario user = new Usuario();

        public UsuarioController(Context contextService)
        {
            _contextService = contextService;
        }

        public IActionResult Index() 
        {
            return View();
        }

        public async Task<IActionResult> ItensUsuario()
        {

            user.Itens = await _contextService.Item.ToListAsync();
            return View(user.Itens);
        }
        //public void PagarUsuario(decimal valor, Usuario quemRecebe)
        //{
        //    if (valor > 0 && valor <= Saldo)
        //    {
        //        Saldo -= valor;
        //        quemRecebe.Saldo += valor;

        //        Console.WriteLine($"Pagamento de {valor:C} realizado de {Nome} para {quemRecebe.Nome}.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Erro");
        //    }
        //}

        //public void AdicionarItem(Item item)
        //{
        //    Itens.Add(item);
        //}

        //public void RemoverItem(Item item)
        //{
        //    Itens.Remove(item);
        //}

        //public void ParticiparJogo(Jogo jogo)
        //{
        //    jogo.AdicionarParticipante(this);
        //}
    }
}
