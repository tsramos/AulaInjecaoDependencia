using IoC.Dominio.Contratos;
using IoC.Dominio.Entidades;
using IoC.Repositorio;
using System;

namespace IoC.Servicos
{
    internal class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailService _emailService;

        public ClienteService(IClienteRepository clienteRepository, IEmailService emailService)
        {
            _clienteRepository = clienteRepository;
            _emailService = emailService;
        }

        public void Adicionar(Cliente cliente)
        {
            if (!cliente.Validar())
            {
                Console.WriteLine("Cliente cadastrado incorretamente.");
            }
            
            _clienteRepository.Adicionar(cliente);
            Cliente ex = _clienteRepository.BuscarClientePorId(2);
            _emailService.EnviarEmail("thiago.ramos@techclass.com.br", cliente.Email, "Matricula", "Bem vindo a turma");

        }
    }
}
