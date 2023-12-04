namespace BarSplitterMVC.Models
{
    public class Grupo
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public List<Usuario>? IntegrantesGrupo { get; set; }
    }
}
