﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluraC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContaPoupanca cp = new ContaPoupanca();
            cp.Depositar(1000);
            cp.Sacar(100);

            MessageBox.Show("Saldo: " + cp.Saldo);

            Conta c = new Conta();
            c.Depositar(100);

            MessageBox.Show("Saldo: " + c.Saldo);

        }
    }
}
