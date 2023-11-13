using System;
namespace BarSplitterMVC.Models;y

public class Home
{
	public Home()
	{	
		// Informacoes de login do usuario que serao verificadas no banco de dados 
		public string loginUsuario { get; set; }
        public string loginSenha { get; set; }
	}
}
