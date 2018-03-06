﻿
namespace CaixaEletronico
{
    public class ContaPoupanca : Conta, ITributavel
    {
        public void Sacar(double valor)
        {
            Saldo -= valor + 0.1;
        }

        public double CalcularTributo()
        {
            return Saldo * 0.02;
        }
    }
}
