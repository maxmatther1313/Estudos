using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeDeTudo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;

            for(int i = 1; i <= 1000; i++)
            {
                num += i;
            }
            MessageBox.Show("A Soma fica: " + num);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = 3;

            for (num = 1; num <= 10; num++)
            {
                if(num % 3 == 0)
                {
                    MessageBox.Show("O número " + num + " é multiplo de 3.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int fatorial = 1;

            for(int i = 1; i <= 10; i++)
            {
                fatorial = fatorial * i;
                MessageBox.Show("O fatorial de (" + i + ") é: " + fatorial);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
