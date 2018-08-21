using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioFibonacci01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String serieFibonacci = "";
            int anterior = 0;
            int atual = 1;

            while(atual <= 100)
            {
                serieFibonacci += atual + "";
                int proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }
            MessageBox.Show("A Série de Fibonacci até 100: " + serieFibonacci);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int qtdLinhas = 5;
            string triangulo = "";

            for(int linha = 1; linha <= qtdLinhas; linha++)
            {
                for(int coluna = 1;coluna <= linha; coluna++)
                {
                    triangulo += (linha * coluna) + " ";
                }
                triangulo += "\n";
            }
            MessageBox.Show(triangulo);
        }
    }
}
