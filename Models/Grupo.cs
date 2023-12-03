namespace BarSplitterMVC.Models
{
    public class Grupo
    {
        private static int contadorGrupos = 1;

        public string Nome { get; set; }
        public List<Usuario> IntegrantesGrupo { get; set; } = new List<Usuario>();

        public Grupo()
        {
            IntegrantesGrupo = new List<Usuario>();
        }

        // Já criei o crupo criando o nome aleátorio
        public static Grupo CriarGrupo(List<Usuario> usuarios)
        {
            Grupo novoGrupo = new Grupo
            {
                Nome = "Grupo: " + contadorGrupos,
                IntegrantesGrupo = usuarios
            };

            contadorGrupos++;

            return novoGrupo;
        }

        public void AdicionarUsuarioGrupo(Usuario usuario)
        {
            IntegrantesGrupo.Add(usuario);
        }

        public void RemoverUsuarioGrupo(Usuario usuario)
        {
            IntegrantesGrupo.Remove(usuario);
        }
    }
}
