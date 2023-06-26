using LeveMe.Domain.Models;
using System.Xml;

namespace LeveMv.Domain.Models
{
    public class Cliente
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public int CNPJ { get; set; }
        public string Endereço { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }          
        public DateTime DataCadastro { get; set; }
        public IList<ClienteLeveMe> LeveMe { get; set; }
        public IList<ProdutoCliente> Produtos { get; set; }

        public Cliente()
        {

        }

        public Cliente(Guid id, string nome, int cnpj, string bairro, string telefone, string endereco, string cidade, string uf, DateTime dataCadastro, bool ativo, string email)
        { 
            ID = id;
            Nome = nome;
            CNPJ = cnpj;
            Endereço = endereco;
            Bairro = bairro;
            Cidade = cidade;
            UF = uf;
            Telefone = telefone;
            Email = email;
            DataCadastro = dataCadastro;
            Ativo = ativo;
        }
    }
}
