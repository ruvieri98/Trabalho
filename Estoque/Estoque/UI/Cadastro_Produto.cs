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
    public partial class Cadastro_Produto : Form
    {
        Arquivo arq = new Arquivo();
        Produto produto = new Produto();

        public Cadastro_Produto()
        {
            InitializeComponent();
            CarrregaListaArquivo();
        }


        private void CarrregaListaArquivo()//carrega os forncedores do arquivo, e inclui dentro do combobox.
        {
            List<Fornecedor> Lista_Fornecedor = arq.ReadArquivoFornecedor();

            foreach(Fornecedor produto in Lista_Fornecedor)
            {
                cmb_fornecedorList.Items.Add(produto);
            } 
        }

        private void PreencheDados()
        {
            produto.Codigo = txb_codigo.Text;
            produto.Nome = txb_nome.Text;
            produto.Preco = Convert.ToSingle(txb_preco.Text);
            produto.Descricao = txb_descricao.Text;
            produto.Data = data_produto.Value;
            produto.Fornecedor = (Fornecedor)cmb_fornecedorList.SelectedItem;
        }
       
        private int validarCampos() //retorna 0 se der errado, e retorna 1 se der certo.
        {
            if(txb_codigo.Text.Trim() == "")
            {
                MessageBox.Show("Campo Codigo não foi preenchido.");
                txb_codigo.Focus();
                return 0;
            }

            if(txb_nome.Text.Trim() == "")
            {
                MessageBox.Show("Campo nome não foi preenchido.");
                txb_nome.Focus();
                return 0;
            }

            if(txb_preco.Text.Trim() == "")
            {
                MessageBox.Show("Campo preço não foi preenchido.");
                txb_preco.Focus();
                return 0;
            }

            if(data_produto.Value > DateTime.Now)
            {
                MessageBox.Show("A data que você informou é futura.");
                data_produto.Focus();
                return 0;
            }

            if(cmb_fornecedorList.SelectedItem == null)
            {
                MessageBox.Show("Você não selecionou um fornecedor.");
                cmb_fornecedorList.Focus();
                return 0;
            }
            return 1;
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            if (validarCampos() == 1)
            {
                PreencheDados();
                arq.WriteArquivo(produto);
                MessageBox.Show("Produto Cadastrado com Sucesso!!");

            }
        }
    }
}
