using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 1; i < 30; i++)
            {
                if(i % 3 == 0 || i % 4 == 1)
                {
                    MessageBox.Show("O número que é Divisivel por 3 ou 4 é: " + i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n, m;

            n = 15 % 3;
            m = 15 % 4;

            MessageBox.Show("15 % 3 = O resultado é: " + n);
            MessageBox.Show("15 % 4 = O resultado é: " + m);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = 0;

            for(int i = 1; i <= 100; i++)
            {
                
                if(i % 3 != 0)
                {
                    num += 1;                   
                }
            }
            MessageBox.Show("O Resultado é: " + num);
        }
    }
}
