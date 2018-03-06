using System;

namespace CaixaEletronico
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }
        public int Tipo { get; set; }

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException();
            }
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
            else
            {
                throw new SaldoInsuficienteException();
            }
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Transferir(double valor, Conta destino)
        {
            Sacar(valor);
            destino.Depositar(valor);
        }
    }
}
