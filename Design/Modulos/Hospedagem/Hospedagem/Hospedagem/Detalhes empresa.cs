﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedagem
{
    public partial class Detalhes_empresa : Form
    {
        public Detalhes_empresa()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // bottao cadastrar
        {
            Cad_Quarto cdQuarto = new Cad_Quarto();
            cdQuarto.ShowDialog();
            


        }

        private void button4_Click(object sender, EventArgs e) //botão que limpa os textbox do primeiro bloco
        {

        }

        private void button3_Click(object sender, EventArgs e) // 
        {
            
        }
    }
}
