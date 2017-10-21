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
    public partial class Estoque_pricipal : Form
    {
        public Estoque_pricipal()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Endereco> listafornecedor = new List<Endereco>();
            Arquivo arq = new Arquivo();
            Endereco endereco = new Endereco();
            Telefone tel = new Telefone();

            Fornecedor produto = new Fornecedor(endereco, tel);
            Cliente clinete = new Cliente(endereco,tel);

            listafornecedor = arq.ReadArquivo();

            endereco = listafornecedor[1];
            MessageBox.Show(endereco.Rua);
        }
    }
}
