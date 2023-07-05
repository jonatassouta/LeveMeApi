using LeveMv.Domain.Models;

namespace LeveMe.Application.InterfacesServices
{
    public interface IProdutoService
    {
        Task Cadastar(Produto produto);
        Task Atualizar(Produto produto);
        Task<string> Vender(Guid produtoId, int quantidade);
        Task<List<Produto>> Listar();
        Task<List<Produto>> ListarPorNome(string nome);
        Task<List<Produto>> ListarPorCliente();
        Task Excluir(Guid produtoId);
        Task<Produto> PesquisarPoId(Guid produtoId);
    }
}
