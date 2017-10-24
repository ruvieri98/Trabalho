﻿using System;
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
        FileStream sw;
        FileStream sr;
        private string linha;
        private string DiretorioCliente = @"cliente.jp";
        private string DiretorioFornecedor = @"fornecedor.jp";
        private string DiretorioProduto = @"produto.jp";


        //escreve o arquivo de cliente
        public void WriteArquivo(object cliente)
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

        public List<Cliente> ReadArquivo()
        {
            FileInfo fi = new FileInfo(DiretorioCliente);
            List<Cliente> lista = new List<Cliente>();
            FileStream arq = new FileStream(DiretorioCliente, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            ;
            try
            {
                if (fi.Exists == true)
                {
                    long teste = arq.Length;
                    //Cliente novo = (Cliente)bf.Deserialize(arq);
                    while (arq.Length >= teste)
                    {
                        Cliente novo = new Cliente();
                        novo = (Cliente)bf.Deserialize(arq);
                        lista.Add(novo);

                    }
                    arq.Close();

                    return lista;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception)
            {
                arq.Close();
                return lista;
            }

        }



    }
}

