namespace BarSplitterMVC.Models
{
    public class Usuario
    {
        public string nome { get; set; }
        public int id { get; set; }
        public List<ItemPedido> Itens { get; set; }
        public bool participaJogo { get; set; }
        public bool admin { get; set; }


    }
}
