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
        private List<Cliente> _ListaCliente = new List<Cliente>();

        public Estoque_pricipal()
        {
            InitializeComponent();

            Arquivo arq = new Arquivo();
            _ListaCliente = arq.ReadArquivoCliente();

            foreach (Cliente cliente in _ListaCliente)
            {
                cmb_cliente.Items.Add(cliente.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            //Arquivo escreve = new Arquivo();
            //Cliente novo = new Cliente();
            //novo.Nome = "opt";
            //novo.Email = "opt@gmial.com";
            //novo.Rg = "7159951";

            //escreve.WriteArquivo(novo);
        }


        private void cmb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }


    }
}
