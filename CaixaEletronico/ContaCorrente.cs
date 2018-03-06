
namespace CaixaEletronico
{
    public class ContaCorrente : Conta
    {
        public static int TotalDeContas { get; private set; }

        public ContaCorrente()
        {
            TotalDeContas++;
        }

        public static int ProximoNumero()
        {
            return TotalDeContas + 1;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor + 0.1;
        }
    }
}
