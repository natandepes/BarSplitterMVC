namespace BarSplitterMVC.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        public Item? Prenda { get; set; }
        public List<Usuario>? Usuarios { get; set; }
    }
}
