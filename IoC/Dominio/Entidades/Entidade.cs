namespace IoC.Dominio.Entidades
{
    internal abstract class Entidade
    {
        private static int _id = 0;
        private int id;
        public int Id { get { return id; } }

        public Entidade()
        {
            _id++;
            id = _id;
        }
    }
}
