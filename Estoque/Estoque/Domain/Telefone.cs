using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    [Serializable]
    class Telefone
    {
        private int codCidade;
        private int ddd;
        private int telefone;
        private string tipo;

        public int CodCidade { get => codCidade; set => codCidade = value; }
        public int Ddd { get => ddd; set => ddd = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Telefoned { get => telefone; set => telefone = value; }


        public Telefone SetCodigoCidade(int codigocidade)
        {
            this.codCidade = codigocidade;
            return this;
        }

        public Telefone SetDDD( int ddd)
        {
            this.ddd = ddd;
            return this;
        }

        public Telefone SetTelefone(int telefone)
        {
            this.telefone = telefone;
            return this;
        }

        public Telefone SetTipo(string tipo)
        {
            this.tipo = tipo;
            return this;
        }


    }


}
