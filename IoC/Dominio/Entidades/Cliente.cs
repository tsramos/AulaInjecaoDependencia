using IoC.Dominio.Enumeradores;

namespace IoC.Dominio.Entidades
{
    internal class Cliente : Entidade
    {        
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public Genero Genero { get; set; }

        public Cliente() : base()
        {         
        }

        public bool Validar()
        {   // NOT                             AND                         OR ||
            return !(string.IsNullOrEmpty(this.Nome) &&
                     string.IsNullOrEmpty(this.CPF) && 
                     string.IsNullOrEmpty(Email));           
        }
    }
}
