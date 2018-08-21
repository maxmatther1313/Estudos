using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaIdadesAmigos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idadeFelipe = 16;

            MessageBox.Show("Idade de Felipe é: " + idadeFelipe);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idadeThiago = 17;

            MessageBox.Show("A idade de Thiago é: " + idadeThiago);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idadeNicolas = 18;

            MessageBox.Show("A idade de Nicolas é: " + idadeNicolas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadeFelipe = 16, idadeThiago = 17, idadeNicolas = 18;
            int somaIdades = idadeFelipe + idadeThiago + idadeNicolas;
            double mediaIdades = somaIdades / 3;

            MessageBox.Show("A média das idades é: " + mediaIdades);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Lista de Amigos:");
        }
    }
}
