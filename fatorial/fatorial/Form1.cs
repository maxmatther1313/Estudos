﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fatorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fatorial = 1;            

            for (int n = 1;n <= 10; n++)
            {
                fatorial = fatorial * n;
                MessageBox.Show("Fatorial(" + n + ") =" + fatorial);
            }
        }
    }
}
