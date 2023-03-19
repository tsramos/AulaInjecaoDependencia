using IoC.Dominio.Contratos;
using IoC.Dominio.Entidades;

namespace IoC.Servicos
{
    internal class EmailService : IEmailService
    {
        public void EnviarEmail(string de, string para, string assunto, string corpo)
        {
            Email email = new Email()
            {
                Assunto = assunto,
                Corpo = corpo,
                De = de,
                Para = para,
            };            
        }
    }
}
