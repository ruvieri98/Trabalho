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
        ServiceCliente servico = new ServiceCliente();
        Arquivo arq = new Arquivo();

        public Estoque_pricipal()
        {
            InitializeComponent();
            List<Cliente> _Lista_Cliente = new List<Cliente>();
            _ListaCliente = arq.ReadArquivoCliente();
            foreach(Cliente cliente in _ListaCliente)
            {
                Cmb_Cliente.Items.Add(cliente);
            }
        }

        private void Create_Client_Click(object sender, EventArgs e)
        {
            Cliente novo = new Cliente();

            novo.Nome = "kael";
            novo.Rg = "123456";
            arq.WriteArquivo(novo);
        }

        private void Cmb_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Del_Client_Click(object sender, EventArgs e)
        {
            ServiceCliente Service_Client = new ServiceCliente();


            _ListaCliente = Service_Client.DelCliente(Cmb_Cliente.SelectedItem.ToString(), _ListaCliente);

        }

        private void Search_Client_Click(object sender, EventArgs e)
        {

            Cliente client = (Cliente)Cmb_Cliente.SelectedItem;

            MessageBox.Show("Nome:" + client.Nome +
                "\nRG:" + client.Rg);


        }

        private void Estoque_pricipal_Load(object sender, EventArgs e)
        {

        }
    }
}
