namespace LeveMv.Domain.Models
{
    public class LeveMe
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public IList<ClienteLME> Clientes { get; set; }

        public LeveMe()
        { 
        
        }
        public LeveMe(Guid id, string nome)
        {
            ID = id;
            Nome = nome;
        }
    }
}
