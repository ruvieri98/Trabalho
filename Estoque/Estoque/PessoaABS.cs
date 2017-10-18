using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
     abstract class PessoaABS
    {
        private int codigo;
        private string nome;
        private string email;


        protected PessoaABS()
        {
            codigo = 0;
            nome = "default";
            email = "dafault";
        }

    }
}
