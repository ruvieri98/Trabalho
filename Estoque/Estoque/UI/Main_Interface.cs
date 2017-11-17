using System;
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
            Form formulario_fornecedor = new Cadastro_Fornecedor();
            formulario_fornecedor.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario_produto = new Cadastro_Produto();
            formulario_produto.Show();
        }
    }
}
