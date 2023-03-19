using IoC.Dominio.Entidades;
using System.Collections.Generic;
using IoC.Dominio.Contratos;
namespace IoC.Repositorio
{
    internal class ClienteRepository : IClienteRepository
    {
        private static List<Cliente> clientes = new List<Cliente>();
        public void Adicionar(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public Cliente BuscarClientePorId(int id)
        {
           return clientes.Find(x => x.Id == id);
        }
    }
}
