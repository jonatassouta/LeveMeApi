using LeveMv.Domain.Entities;
using LeveMv.Domain.Models;

namespace LeveMe.Application.ViewModels
{
    public class ClienteDto
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
        public Guid LeveMvId { get; set; }
        public DateTime DataCadastro { get; set; }
       
        public ClienteDto()
        {

        }

        public Cliente ConverterParaEntidade()
        {
            var novoCliente = new Cliente();
            novoCliente.ID = !string.IsNullOrEmpty(this.ID.ToString()) ? this.ID : BaseEntity.GenerateId();
            novoCliente.Nome = this.Nome;
            novoCliente.CNPJ = this.CNPJ;
            novoCliente.Endereco = this.Endereco;
            novoCliente.Bairro = this.Bairro;
            novoCliente.Cidade = this.Cidade;
            novoCliente.UF = this.UF;
            novoCliente.Telefone = this.Telefone;
            novoCliente.Email = this.Email;
            novoCliente.DataCadastro = this.DataCadastro;
            novoCliente.LeveMvId = this.LeveMvId;

            return novoCliente;
        }
    }
}
