using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta1 umaConta = new Conta1();
            umaConta.numero = 1;
            umaConta.titular = "Lucas Oliveira";
            umaConta.saldo = 2000.0;
            umaConta.agencia = 666;
            umaConta.cpf = "111.222.333-44";

            Conta1 outraConta = new Conta1();
            outraConta.numero = 2;
            outraConta.titular = "Maria Silva";
            outraConta.saldo = 1500.0;
            outraConta.agencia = 667;
            outraConta.cpf = "555.666.777-88";

            MessageBox.Show("O Titular da Conta 1 é: " + umaConta.titular);
            MessageBox.Show("O Numero da Conta de " + umaConta.titular + " é: " + umaConta.numero);
            MessageBox.Show("O Saldo da Conta de " + umaConta.titular + " é: " + umaConta.saldo);
            MessageBox.Show("A Agência de " + umaConta.titular + " é: " + umaConta.agencia);
            MessageBox.Show("O CPF de " + umaConta.titular + " é: " + umaConta.cpf);


            MessageBox.Show("O Titular da Conta 2 é: " + outraConta.titular);
            MessageBox.Show("O Numero da Conta de " + outraConta.titular + " é: " + outraConta.numero);
            MessageBox.Show("O Saldo da Conta de " + outraConta.titular + " é: " + outraConta.saldo);
            MessageBox.Show("A Agência de " + outraConta.titular + " é: " + outraConta.agencia);
            MessageBox.Show("O CPF de " + outraConta.titular + " é: " + outraConta.cpf);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta1 guilherme = new Conta1();
            Conta1 mauricio = new Conta1();

            guilherme.saldo = 1500.0;
            mauricio.saldo = 2000.0;

            guilherme.Transfere(200.0, mauricio);
            MessageBox.Show("Guilherme: " + guilherme.saldo);
            MessageBox.Show("Maurício: " + mauricio.saldo);
        }
    }
}
