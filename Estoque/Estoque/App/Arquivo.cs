using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Estoque
{
    class Arquivo
    {

        private string DiretorioCliente = @"cliente.jp";
        private string DiretorioFornecedor = @"fornecedor.jp";
        private string DiretorioProduto = @"produto.jp";


        //escreve o arquivo de cliente, criando no diretorio padrao.
        public void WriteArquivo(Cliente cliente)
        {
            try
            {
                if (File.Exists(DiretorioCliente) == true)
                {

                    FileStream ClienteFile = new FileStream(DiretorioCliente, FileMode.Append);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ClienteFile, cliente);
                    ClienteFile.Close();
                }
                else
                {
                    FileStream ClienteFile = new FileStream(DiretorioCliente, FileMode.Create);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ClienteFile, cliente);
                    ClienteFile.Close();
                }
            }
            catch
            {
                Console.WriteLine("Falha ao abrir o arqivo");
            }

        }

        public void WriteArquivo(List<Cliente> clientes)
        {
            File.Delete(@"C:\Users\joao3\source\repos\Trabalho\Estoque\Estoque\bin\Debug\cliente.jp");
            FileStream ClienteFile = new FileStream(DiretorioCliente, FileMode.Append);
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                foreach (Cliente client in clientes)
                {

                    bf.Serialize(ClienteFile, client);

                }
            }
            catch { Console.WriteLine("Impossivel abrir o arquivo"); }
            finally { ClienteFile.Close(); }
        }


        //escreve o arquivo de fornecedor
        public void WriteArquivo(Fornecedor fornecedor)
        {
            try
            {
                if (File.Exists(DiretorioFornecedor) == true)
                {

                    FileStream FornecedorFile = new FileStream(DiretorioFornecedor, FileMode.Append);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(FornecedorFile, fornecedor);
                    FornecedorFile.Close();
                }
                else
                {
                    FileStream FornecedorFile = new FileStream(DiretorioFornecedor, FileMode.Create);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(FornecedorFile, fornecedor);
                    FornecedorFile.Close();
                }
            }
            catch
            {
                Console.WriteLine("falha ao abrir o arquivo");
            }
        }

        //escreve o arquivo produto
        public void WriteArquivo(Produto produto)
        {
            try
            {
                if (File.Exists(DiretorioProduto) == true)
                {

                    FileStream produtoFile = new FileStream(DiretorioProduto, FileMode.Append);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(produtoFile, produto);
                    produtoFile.Close();
                }
                else
                {
                    FileStream produtoFile = new FileStream(DiretorioProduto, FileMode.Create);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(produtoFile, produto);
                    produtoFile.Close();
                }
            }
            catch
            {
                Console.WriteLine("Falha ao abrir o arquivo");
            }
        }

        public List<Cliente> ReadArquivoCliente()
        {
            FileInfo fi = new FileInfo(DiretorioCliente);
            List<Cliente> lista = new List<Cliente>();
            FileStream arq = new FileStream(DiretorioCliente, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                if (fi.Exists == true)
                {
                    while (arq.Position < arq.Length)
                    {
                        Cliente novo = new Cliente();
                        novo = (Cliente)bf.Deserialize(arq);
                        lista.Add(novo);
                    }
                }
                else
                {
                    lista = null;
                }
            }
            catch
            {
                lista = null;
            }
            finally
            {
                arq.Close();
            }
            return lista;
        }

        public List<Produto> ReadArquivoProduto()
        {
            FileInfo fi = new FileInfo(DiretorioProduto);
            List<Produto> lista = new List<Produto>();
            FileStream arq = new FileStream(DiretorioProduto, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                if (fi.Exists == true)
                {
                    while (arq.Position < arq.Length)
                    {
                        Produto novo = new Produto();
                        novo = (Produto)bf.Deserialize(arq);
                        lista.Add(novo);
                    }
                    
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                arq.Close();
            }
            return lista;
        }

        public List<Fornecedor> ReadArquivoFornecedor()
        {
            FileInfo fi = new FileInfo(DiretorioFornecedor);
            List<Fornecedor> lista = new List<Fornecedor>();
            FileStream arq = new FileStream(DiretorioFornecedor, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                if (fi.Exists == true)
                {
                    while (arq.Position < arq.Length)
                    {
                        Fornecedor novo = new Fornecedor();
                        novo = (Fornecedor)bf.Deserialize(arq);
                        lista.Add(novo);
                    }
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                arq.Close();
            }
            return lista;
        }

    }
}

