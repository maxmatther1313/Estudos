﻿using System;
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
            double saldo = 100.0;
            double valor = 10.0;
            bool podeSacar = (valor <= saldo) && (valor >= 0);
            
            //bool realmentePodeSacar = (saldo >= valor) && (valor > 0);
            /*if(realmentePodeSacar)
             * {
             *   //codigo do Saque
             * }else
             * {
             * MessageBox.Show("Saldo Insuficiemte!");
             * }
             */

            if (valor <= saldo)
            {
                valor = saldo - valor;

                MessageBox.Show("Saque Realizado com Sucesso!");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente!");
            }
            
        }
    }
}
