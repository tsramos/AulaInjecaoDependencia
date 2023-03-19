namespace IoC.Dominio.Entidades
{
    internal class Email : Entidade
    {
        public string Assunto { get; set; }
        public string Corpo { get; set; }
        public string De { get; set; }
        public string Para { get; set; }

        public Email() : base()
        {
        }
    }
}
