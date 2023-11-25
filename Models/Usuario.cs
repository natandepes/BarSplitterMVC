namespace BarSplitterMVC.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Admin { get; set; }
        public bool CriadorMesa { get; set; }
        public bool ParicipaJogo { get; set; }
        public decimal Saldo { get; set; } // Adicionei saldo para conseguir fazer o médoto pagar 

        public List<Item> Itens { get; set; } = new List<Item>();  // armazenar itens do usuário


        public Usuario(int id, string nome, bool admin, bool criadorMesa, bool participaJogo, decimal saldo)
        {
            Id = id;
            Nome = nome;
            Admin = admin;
            CriadorMesa = criadorMesa;
            ParicipaJogo = participaJogo;
            Saldo = saldo;
        }

        public void PagarUsuario(decimal valor, Usuario quemRecebe)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                quemRecebe.Saldo += valor;

                Console.WriteLine($"Pagamento de {valor:C} realizado de {Nome} para {quemRecebe.Nome}.");
            }
            else
            {
                Console.WriteLine("Erro");
            }
        }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }

        public void RemoverItem(Item item)
        {
            Itens.Remove(item);
        }

        //public void ParticiparJogo(Jogo jogo)
        //{
        //    jogo.AdicionarParticipante(this);
        //}
    }
}
