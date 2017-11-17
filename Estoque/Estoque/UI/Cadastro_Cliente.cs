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
    public partial class Cadastro_Cliente : Form
    {
        Arquivo arq = new Arquivo();
        Telefone telefone = new Telefone();
        Endereco endereco = new Endereco();
        Cliente cliente = new Cliente();

        public Cadastro_Cliente()
        {
            InitializeComponent();
        }

        private int ValidarCampos()//retorna 0 se der errado, e 1 se deu certo.
        {


            if (txb_nomeFornecedor.Text.Trim() == "")
            {
                MessageBox.Show("Campo Nome não pode ser vazio");
                txb_nomeFornecedor.Focus();
                return 0;
            }

            if (txb_emailFornecedor.Text.Trim() == "")
            {
                MessageBox.Show("Campo Email não pode ser vazio");
                txb_emailFornecedor.Focus();
                return 0;
            }

            if (mask_dataFornecedor.MaskCompleted == false)
            {
                MessageBox.Show("Campo Data de Nascimento não pode ser vazio");
                mask_dataFornecedor.Focus();
                return 0;
            }

            if (mask_cnjpFornecedor.MaskCompleted == false)
            {
                MessageBox.Show("Campo CNPJ não pode ser vazio");
                mask_cnjpFornecedor.Focus();
                return 0;
            }

            if (txb_bairroFornecedor.Text.Trim() == "")
            {
                MessageBox.Show("Campo Bairro não pode ser vazio");
                txb_bairroFornecedor.Focus();
                return 0;
            }

            if (txb_ruaFornecedor.Text.Trim() == "")
            {
                MessageBox.Show("Campo Rua não pode ser vazio");
                txb_bairroFornecedor.Focus();
                return 0;
            }

            if (txb_cepFornecedor.Text.Trim() == "")
            {
                MessageBox.Show("Campo Cep não pode ser vazio");
                txb_cepFornecedor.Focus();
                return 0;
            }

            if (txb_cidadeFornecedor.Text.Trim() == "")
            {
                MessageBox.Show("Campo Cidade não pode ser vazio");
                txb_cidadeFornecedor.Focus();
                return 0;
            }

            if (mask_numCasaFornecedor.MaskCompleted == false)
            {
                MessageBox.Show("Campo Numero da casa não pode ser vazio, ou está incompleto.");
                mask_numCasaFornecedor.Focus();
                return 0;
            }

            if (mask_codCidade.MaskCompleted == false)
            {
                MessageBox.Show("Campo Codigo da Cidade não pode ser vazio, ou está incompleto.");
                mask_codCidade.Focus();
                return 0;
            }

            if (mask_ddd.MaskCompleted == false)
            {
                MessageBox.Show("Campo DDD não pode ser vazio, não pode ser vazio");
                mask_ddd.Focus();
                return 0;
            }

            if (mask_telefone.MaskCompleted == false)
            {
                MessageBox.Show("Campo Telefone não pode ser vazio, ou está incompleto.");
                mask_telefone.Focus();
                return 0;
            }
            return 1;
        }

        private void PreencheDados()
        {
            telefone.CodCidade = Convert.ToInt32(mask_codCidade.Text);
            telefone.Ddd = Convert.ToInt32(mask_ddd.Text);
            telefone.Telefoned = Convert.ToInt32(mask_telefone.Text);
            telefone.Tipo = cmb_tipoTelefone.SelectedItem.ToString();

            endereco.Bairro = txb_bairroFornecedor.Text;
            endereco.Cep = txb_cepFornecedor.Text;
            endereco.Cidade = txb_cidadeFornecedor.Text;
            endereco.Complemento = txb_complementoFornecedor.Text;
            endereco.Numero = Convert.ToInt32(mask_numCasaFornecedor.Text);
            endereco.Rua = txb_ruaFornecedor.Text;

            cliente.Endereco = endereco;
            cliente.Telefone = telefone;

            cliente.Nome = txb_nomeFornecedor.Text;
            cliente.Email = txb_emailFornecedor.Text;
            cliente.Cpf = mask_cnjpFornecedor.Text;
            cliente.Nascimento = mask_dataFornecedor.Text;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if(ValidarCampos() == 1)
            {
                PreencheDados();
                arq.WriteArquivo(cliente);
                MessageBox.Show("Cliente Cadastrado com Sucesso.");
                List<Cliente> Lista_Clientes = arq.ReadArquivoCliente();

                foreach (Cliente cliente in Lista_Clientes)
                {
                    MessageBox.Show(cliente.ToString());
                }
            }
        }
    }
}
