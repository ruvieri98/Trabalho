using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Telefone T = new Telefone();
            Endereco C = new Endereco();
            Fornecedor B = new Fornecedor(C,T);
            Produto A = new Produto(B);
            A.Nome = txb_nome.Text;
            MessageBox.Show("nome do produto:" + A.Nome);

        }

        private void txb_nome_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
