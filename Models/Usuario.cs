namespace BarSplitterMVC.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Admin { get; set; }

        //public bool ParicipaJogo { get; set; }
        public decimal Conta { get; set; } // Adicionei saldo para conseguir fazer o médoto pagar 

        public List<Item> Itens { get; set; } = new List<Item>();  // armazenar itens do usuário

        // Completamente errado fazer isso mas eh a gambiarra do dia de hoje
    }
}
