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

        private void button1_Click(object sender, EventArgs e)
        {
            Arquivo arq = new Arquivo();
            Cliente novo = new Cliente();

            novo.Nome = "kamuddasdsa";
            novo.Rg = "3217dfasdfsdfsda7159";

            arq.WriteArquivo(novo);

            MessageBox.Show("cliente salvo com sucesso.");


        }
    }
}
