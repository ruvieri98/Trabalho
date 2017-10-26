using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    class ServiceCliente
    {
        //recebe a busta e uma lista de cliente, e retorna o cliente caso encontre.
        public Cliente BuscarCliente(string busca, List<Cliente> clientes)
        {
            foreach(Cliente elemento in clientes)
            {
                if(busca == elemento.Nome)
                {
                    return elemento;
                }
            }

            return null;
        }

        public List<Cliente> DelCliente(string busca, List<Cliente> clientes)
        {
            Arquivo arq = new Arquivo();
            foreach (Cliente elemento in clientes)
            {
                if (busca == elemento.Nome)
                {
                    clientes.Remove(elemento);
                    arq.WriteArquivo(clientes);
                    return clientes;
                }
            }
            return clientes;             
        }

    }
}
