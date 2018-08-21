using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {
        Conta[] contas;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {            
            var contas = new List<Conta>();
            var c1 = new ContaCorrente();            
            c1.Titular = "José";
            contas.Add(c1);

            Conta copiaC1 = contas[0];

            var c2 = new ContaCorrente();
            c2.Titular = "Aluana";

            contas.Add(c2);
            contas.RemoveAt(0);

            var c3 = new ContaCorrente();
            c3.Titular = "Mario";
            contas.Add(c3);

            foreach(var conta in contas)
            {
                MessageBox.Show(conta.Titular);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
