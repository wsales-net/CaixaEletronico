using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraC
{
    class ContaPoupanca : Conta
    {
        public override void Sacar(double valor)
        {
            Saldo -= valor + 0.1;
        }

        public void CalculaInvestimento()
        {
        }
    }
}
