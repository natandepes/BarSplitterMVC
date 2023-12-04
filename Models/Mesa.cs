using System;
namespace BarSplitterMVC.Models
{
	public class Mesa
	{
		public int Id { get; set; }
		public string? Nome { get; set; }
		public double ValorTotal { get; set; }
		public Usuario? UsuarioAdmin { get; set; }
		public List<Usuario>? Usuarios { get; set; }
        public List<Grupo>? Grupos { get; set; }
        public List<Item>? Itens { get; set; }

    }
}

