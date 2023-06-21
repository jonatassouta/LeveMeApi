namespace LeveMv.Domain.Models
{
    public class Leveme
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public IList<ClienteLeveMe> Clientes { get; set; }

        public Leveme()
        { 
        
        }
        public Leveme(Guid id, string nome)
        {
            ID = id;
            Nome = nome;
        }
    }
}
