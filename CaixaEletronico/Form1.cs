using CaixaEletronico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AluraC
{
    public partial class Form1 : Form
    {
        //Conta[] contas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var contas = new List<Conta>();
            contas.Add(ContaComSaldo(2300));
            contas.Add(ContaComSaldo(1000));
            contas.Add(ContaComSaldo(2500));

            var filtradas = from c in contas where c.Saldo > 2000 select c;

            double saldoTotal = filtradas.Sum(c => c.Saldo);

            MessageBox.Show("Saldo Total: " + saldoTotal);

            //contas = new Conta[2];

            //contas[0] = new Conta();
            //contas[0].Numero = 1;
            //contas[0].Titular = new Cliente("Well");

            //contas[1] = new Conta();
            //contas[1].Numero = 2;
            //contas[1].Titular = "Mario";
            //contas[1].Depositar(445);

            //foreach (Conta conta in contas)
            //{
            //    cbxContas.Items.Add(conta.Titular);
            //}
        }

        private Conta ContaComSaldo(double valor)
        {
            Conta c = new ContaCorrente();
            c.Depositar(valor);
            return c;
        }

        private void cbxContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int indiceSelecionado = cbxContas.SelectedIndex;
            //Conta contaSelecionada = contas[indiceSelecionado];

            //txtTitular.Text = contaSelecionada.Titular;
            //txtNumero.Text = Convert.ToString(contaSelecionada.Numero);
            //txtSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = "wellington sales";

            int posicao = nome.IndexOf("s");
            string segundoNome = nome.Substring(posicao);
            MessageBox.Show(segundoNome);
            //var contas = new List<Conta>();
            //var contas = new HashSet<Conta>();
            //var c1 = new ContaCorrente();
            //c1.Titular = new Cliente("Well");
            //contas.Add(c1);
            //contas.Add(c1);

            //Conta copiaC1 = contas[0];

            //var c2 = new ContaCorrente();
            //c2.Titular = new Cliente("Vitor");
            //contas.Add(c2);

            //foreach (var c in contas)
            //{
            //    MessageBox.Show(c.Titular.Nome);
            //}
            //MostrarConta();

            //ContaCorrente contaCorrente = new ContaCorrente();
            //ContaPoupanca contaPoupanca = new ContaPoupanca();

            //contaCorrente.Depositar(100);
            //contaPoupanca.Depositar(100);
        }
    }
}
