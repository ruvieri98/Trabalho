using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    class ServiceCliente
    {
        Cliente elemento;

        public Cliente Buscar(string busca, List<Cliente> clientes)
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


    }
}
