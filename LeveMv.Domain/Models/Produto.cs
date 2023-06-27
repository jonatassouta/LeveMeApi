namespace LeveMv.Domain.Models
{
    public class Produto
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public Produto() 
        { 
        
        }

        public Produto(Guid id, string nome, decimal preco, int quantidade)
        {
            ID = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}
