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
            Endereco end = new Endereco();
            Telefone tel = new Telefone();
            tel.Ddd = 270;
            end.Bairro = "teste";
            Fornecedor teste = new Fornecedor(end,tel);
            Produto novo = new Produto(teste);

            MessageBox.Show("o telefone do fornecedor é:"+novo.Fornecedor.Telefone.Ddd.ToString());
        }
    }
}
