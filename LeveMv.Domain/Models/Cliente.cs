using LeveMe.Domain.Enums;

namespace LeveMv.Domain.Models
{
    public class Cliente
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public long CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Telefone { get; set; }
        public string? Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public Guid LeveMvId { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Perfil { get; set; }
        public IList<ClienteLeveMv> LeveMe { get; set; }
        public ICollection<Produto> Produtos { get; set; }

        public Cliente()
        {

        }

        public Cliente(Guid id, string nome, int cnpj, string bairro, string telefone, string endereco, string cidade, string uf, DateTime dataCadastro, bool ativo, string email, Guid leveID, string perfil, string senha)
        { 
            ID = id;
            Nome = nome;
            CNPJ = cnpj;
            Endereco = endereco;
            Bairro = bairro;
            Cidade = cidade;
            UF = uf;
            Telefone = telefone;
            Email = email;
            DataCadastro = dataCadastro;
            Ativo = ativo;
            LeveMvId = leveID;
            Perfil = perfil;
            Senha = senha;
        }
    }
}
