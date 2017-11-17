using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    [Serializable]
    class Produto
    {

        private string nome;
        private float preco;
        private string descricao;
        private string codigo;
        private DateTime data;
        private Fornecedor fornecedor;


        public string Nome { get => nome; set => nome = value; }
        public float Preco { get => preco; set => preco = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        internal Fornecedor Fornecedor { get => fornecedor; set => fornecedor = value; }
        public DateTime Data { get => data; set => data = value; }

        public Produto(Fornecedor fornecedor)
        {

            this.fornecedor = fornecedor;
        }

        public Produto()
        {

        }

        public override string ToString()
        {
            return this.Nome;
        }

    }


}
