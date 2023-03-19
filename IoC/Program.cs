using IoC.Dominio.Contratos;
using IoC.Dominio.Entidades;
using IoC.Repositorio;
using IoC.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<IClienteService, ClienteService>();            
            services.AddSingleton<IClienteRepository, ClienteRepository>();
            services.AddTransient<IEmailService, EmailService>();
            ServiceProvider provider = services.BuildServiceProvider();
            var servico = provider.GetService<IClienteService>();

            Cliente cli1 = new Cliente();
            Cliente cli2 = new Cliente();
            cli1.Nome = "Danilo";
            cli1.Email = "danilo@suporte.com.br";
            cli1.CPF = "123123132";
            cli2.Nome = "Joao";
            cli2.Email = "joao@bbb.com";
            cli2.CPF = "56+52656+56+";
            
            servico.Adicionar(cli1);
            servico.Adicionar(cli2);
        }
    }
}
