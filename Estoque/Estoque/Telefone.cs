using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    class Telefone
    {
        private int codCidade;
        private int ddd;
        private string telefone;
        private string tipo;

        public int CodCidade { get => codCidade; set => codCidade = value; }
        public int Ddd { get => ddd; set => ddd = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Telefoned { get => telefone; set => telefone = value; }
    }
}
