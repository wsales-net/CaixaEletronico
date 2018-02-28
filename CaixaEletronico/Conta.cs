using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraC
{
    class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }
        public int Tipo { get; set; }

        public virtual void Sacar(double valor)
        {
            Saldo -= valor;
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
