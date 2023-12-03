using System;
namespace BarSplitterMVC.Models
{
	public class Mesa
	{
		public string Id { get; set; }
		public double ValorTotal { get; set; }
		public Usuario UsuarioAdmin { get; set; }

		public List<Usuario> Usuarios = new List<Usuario>();

		public List<Grupo> Grupos = new List<Grupo>();

        public List<Item> Itens = new List<Item>();

    }
}

