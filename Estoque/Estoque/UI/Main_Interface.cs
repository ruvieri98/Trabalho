﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
    public partial class Estoque_pricipal : Form
    {

        public Estoque_pricipal()
        {
            InitializeComponent();
        }

        private void Estoque_pricipal_Load(object sender, EventArgs e)
        {

        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Cadastro_Fornecedor();
            formulario.Show();
        }
    }
}
