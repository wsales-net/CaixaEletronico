using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta ton = new Conta();
            Conta well = new Conta();

            ton.Saldo = 1500.0;
            well.Saldo = 2000.0;

            ton.Transfere(412, well);
            MessageBox.Show("TOM: " + ton.Saldo);
            MessageBox.Show("WELL: " + well.Saldo);
        }
    }
}
