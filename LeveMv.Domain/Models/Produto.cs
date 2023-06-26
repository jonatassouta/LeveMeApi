using LeveMe.Domain.Models;

namespace LeveMv.Domain.Models
{
    public class Produto
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public IList<ProdutoCliente> Clientes { get; set; }

        public Produto() 
        { 
        
        }

        public Produto(Guid id, string nome, decimal preco)
        {
            ID = id;
            Nome = nome;
            Preco = preco;
        }
    }
}
