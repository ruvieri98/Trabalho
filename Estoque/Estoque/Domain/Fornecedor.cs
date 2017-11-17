using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    [Serializable]
    class Fornecedor:PessoaABS
    {
        private string cnpj;
        private string nascimento;

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Nascimento { get => nascimento; set => nascimento = value; }

        public Fornecedor(Endereco endereco, Telefone telefone)
        {
            this.endereco = endereco;
            this.Telefone = telefone;
        }
        public Fornecedor()
        {

        }

        public override string ToString()
        {
            return this.Nome;
        }




    }
    }

  
