namespace LeveMv.Domain.Models
{
    public class Levemv
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public IList<ClienteLeveMv> Clientes { get; set; }

        public Levemv()
        { 
        
        }
        public Levemv(Guid id, string nome)
        {
            ID = id;
            Nome = nome;
        }
    }
}
