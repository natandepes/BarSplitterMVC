namespace BarSplitterMVC.Models
{
    public class Jogo
    {
        public Item Prenda { get; set; }
        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();
        public List<Rodada> Rodadas { get; set; } = new List<Rodada> ();
    }
}
