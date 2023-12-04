using System.ComponentModel.DataAnnotations.Schema;

namespace BarSplitterMVC.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public bool Admin { get; set; }
        public decimal? Conta { get; set; } 
        public List<Item>? Itens { get; set; }
    }
}
