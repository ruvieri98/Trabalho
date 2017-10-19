using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    class Fornecedor:PessoaABS
    {
        private string cnpj;
        private string nascimento;

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Nascimento { get => nascimento; set => nascimento = value; }

        public Fornecedor()
        {
           
           this.cnpj = "default";
           this.Nascimento = "default";
        }


    }
    }

  
