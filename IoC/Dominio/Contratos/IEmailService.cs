namespace IoC.Dominio.Contratos
{
    internal interface IEmailService
    {
        void EnviarEmail(string de, string para, string assunto, string corpo);
    }
}
