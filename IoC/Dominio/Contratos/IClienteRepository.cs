using IoC.Dominio.Entidades;

namespace IoC.Dominio.Contratos
{
    internal interface IClienteRepository
    {
        void Adicionar(Cliente cliente);
        Cliente BuscarClientePorId(int id);
    }
}
