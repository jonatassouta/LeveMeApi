using System.Xml;

namespace LeveMv.Domain.Models
{
    public class Cliente
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereço { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }          
        public IList<ClienteLeveMe> LeveMe { get; set; }

        public Cliente()
        {

        }

        public Cliente(Guid id, string nome, string telefone, string endereco, string cidade, string uf, DateTime dataCadastro, bool ativo)
        { 
            ID = id;
            Nome = nome;
            Telefone = telefone;
            Endereço = endereco;
            Cidade = cidade;
            UF = uf;
            DataCadastro = dataCadastro;
            Ativo = ativo;
        }
    }
}
