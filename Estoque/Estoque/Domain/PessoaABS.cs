using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{      [Serializable]

       abstract class PessoaABS
    {
        
        protected string nome;
        protected string email;
        private string nascimento;
        protected Endereco endereco;
        protected Telefone telefone;


        //Definindo propriedade Get e Set.
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        internal Telefone Telefone { get => telefone; set => telefone = value; }
        internal Endereco Endereco { get => endereco; set => endereco = value; }
        public string Nascimento { get => nascimento; set => nascimento = value; }
    }
}
