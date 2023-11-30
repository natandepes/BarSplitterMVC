namespace BarSplitterMVC.Models
{
    public class Grupo
    {
        public string nome { get; set; }
        public List<Usuario> participantesSub { get; set; }
        public Usuario MyProperty { get; set; }
    }
}
