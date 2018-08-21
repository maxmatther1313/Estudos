using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoBasckara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 13, b = 36, c = -5;

            double delta = b * b - 4 * a * c;
            double a1 = (- b + (Math.Sqrt(delta)) / (2 * a));
            double a2 = (- b - (Math.Sqrt(delta)) / (2 * a));

            MessageBox.Show("O Resultado do 1º calculo é: " + a1);
            MessageBox.Show("O Resultado do 2º calculo é:" + a2);
        }
    }
}
