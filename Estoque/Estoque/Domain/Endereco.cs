using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    [Serializable]
    class Endereco
    {
        private string bairro;
        private string cidade;
        private string cep;
        private string rua;
        private string complemento;
        private int numero;
        


        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public int Numero { get => numero; set => numero = value; }


        public Endereco SetBairro(string bairro)
        {
            this.bairro = bairro;

            return this;
        }

        public Endereco SetCidade(string cidade)
        {
            this.cidade = cidade;
            return this;
        }

        public Endereco SetCep(string cep)
        {
            this.cep = cep;
            return this;
        }

        public Endereco SetRua(string rua)
        {

            this.rua = rua;
            return this;
        }

        public Endereco SetComplemento(string complemento)
        {
            this.complemento = complemento;
            return this;
        }

        public Endereco SetNumero(int numero)
        {
            this.numero = numero;
            return this;
        }



    }
}
