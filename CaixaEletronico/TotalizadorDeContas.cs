using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraC
{
    class TotalizadorDeContas
    {
        public double Total { get; private set; }

        public void Adicionar(Conta conta)
        {
            Total += conta.Saldo;
        }
    }
}
