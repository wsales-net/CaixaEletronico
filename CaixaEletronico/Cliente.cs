
namespace CaixaEletronico
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }
        public bool EEmancipado { get; set; }
        public string Cpf { get; set; }

        public Cliente(string nome)
        {
            Nome = nome;
        }

        public bool PodeAbrirConta()
        {
            bool maiorDeIdade = Idade >= 18;
            bool emancipado = EEmancipado;
            bool temCpf = !string.IsNullOrEmpty(Cpf);

            return (maiorDeIdade || emancipado) && temCpf;
        }

        public override bool Equals(object obj)
        {
            Cliente cliente = (Cliente)obj;
            return Rg.Equals(cliente.Rg);
        }

        public override string ToString()
        {
            return "Cliente Nome: " + Nome + " RG: " + Rg;
        }
    }
}
