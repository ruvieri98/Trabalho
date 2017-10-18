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

        protected Fornecedor()
        {
            cnpj = "default";
            nascimento = "default";
        }

       }
    }

  
