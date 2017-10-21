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

        public void WriteArquivo(Cliente cliente)
        {   //teste
            sw = File.CreateText(@"cliente.txt");
            sw.WriteLine(cliente.Codigo);
            sw.Close();
        }

        public void WriteArquivo(Fornecedor fornecedor)
        {
            sw = File.CreateText(@"fornecedor.txt");
            sw.WriteLine(fornecedor.Email);
            sw.Close();
        }

        public Fornecedor ReadArquivo(Fornecedor fornecedor)
        {
            sr.ReadLine();

            return fornecedor;
        }
    }
}

