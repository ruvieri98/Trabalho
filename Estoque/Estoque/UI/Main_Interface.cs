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
  


            //Arquivo arq = new Arquivo();
            //Endereco endereco = new Endereco();
            //Telefone tel = new Telefone();

            Telefone telefone = new Telefone();
            Endereco end = new Endereco();
            Fornecedor elemento = new Fornecedor(end,telefone);
            Cliente cliente = new Cliente(end,telefone);

            cliente.Codigo = 666;

            Arquivo arq = new Arquivo();

            arq.WriteCliente(cliente);
            //Cliente clinete = new Cliente(endereco,tel);

            //clinete.Codigo = 55;
            //arq.WriteCliente(clinete);


            
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Cliente cliente = new Cadastro_Cliente();
            cliente.Show();
        }
    }
}
