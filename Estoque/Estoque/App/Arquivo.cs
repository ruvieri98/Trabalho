using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Estoque
{
       class Arquivo
    {
        StreamWriter sw;
        StreamReader sr;

        public void WriteCliente(Cliente cliente)
        {
            sw = File.CreateText(@"cliente.txt");
            sw.WriteLine(cliente.Codigo);
            sw.Close();
        }
    }
}
