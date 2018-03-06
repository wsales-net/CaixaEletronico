
namespace CaixaEletronico
{
    public class ContaInvestimento : Conta, ITributavel
    {
        public void Sacar(double valor)
        {
            Saldo -= valor;
        }

        public double CalcularTributo()
        {
            return Saldo * 0.03;
        }
    }
}
