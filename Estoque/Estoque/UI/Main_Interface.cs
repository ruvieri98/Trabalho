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

            Arquivo arq = new Arquivo();
            Endereco endereco = new Endereco();
            Telefone tel = new Telefone();
           
            
            Cliente clinete = new Cliente(endereco,tel);

            clinete.Codigo = 55;
            arq.WriteCliente(clinete);

            
        }
    }
}
