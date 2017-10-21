using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    [Serializable]
    class Cliente : PessoaABS
    {
        private string cpf;
        private string rg;

        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg {  get => rg; set => rg = value; }

        public Cliente(Endereco endereco, Telefone telefone)
        {
            this.endereco = endereco;
            this.Telefone = telefone;
        }
        public Cliente()
        {

        }

        public Cliente SetName(string nome)
        {
            this.nome = nome;

            return this;
        }

        public Cliente SetEmail(string email)
        {
            this.email = email;
            return this;
        }
    }
}
