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

        private void button1_Click(object sender, EventArgs e)
        {
            Arquivo arq = new Arquivo();

            

            List<Cliente> lista = arq.ReadArquivocliente();

            foreach(Cliente cliente in lista)
            {
                MessageBox.Show(cliente.Nome);
            }
        }
    }
}
