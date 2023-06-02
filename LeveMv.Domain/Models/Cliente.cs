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
        public Guid LeveMvID { get; set; }
        public IList<ClienteLME> LeveMv { get; set; }

        public Cliente()
        {

        }

        public Cliente(Guid id, string nome, string telefone, string endereco, string cidade, string uf, Guid leveMvId)
        { 
            ID = id;
            Nome = nome;
            Telefone = telefone;
            Endereço = endereco;
            Cidade = cidade;
            UF = uf;
            LeveMvID = leveMvId;
        }
    }
}
