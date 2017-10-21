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
        private string linha;
        private string DiretorioCliente = @"cliente.txt";
        private string DiretorioFornecedor = @"fornecedor.txt";
        private string DiretorioProduto = @"produto.txt";


        public void WriteArquivo(Cliente cliente)
        {   //teste
            sw = File.CreateText(DiretorioCliente);
            
            sw.WriteLine(cliente.Codigo);
            sw.Close();
        }

        public void WriteArquivo(Fornecedor fornecedor)
        {
            if(File.Exists(DiretorioFornecedor) == true)
            {
                
                sw = File.AppendText(DiretorioFornecedor);
                sw.WriteLine(fornecedor.Email);
                sw.Close();
            }
            else
            {
                sw = File.CreateText(DiretorioFornecedor);
                sw.WriteLine(fornecedor.Email);
                sw.Close();
            }

        }

        public List<Endereco> ReadArquivo()
        {
            
                List<Endereco> load = new List<Endereco>();
            
                sr = File.OpenText(DiretorioFornecedor);

                 while((linha = sr.ReadLine()) != null)
                 {
                    Endereco endereco = new Endereco();
                    //linha = sr.ReadLine();
                    endereco.Rua = sr.ReadLine();
                    
                    
                    load.Add(endereco);
                 }

            return load;
        }
    }
}

