using LeveMv.Domain.Models;

namespace LeveMe.Domain.InterfacesRepositories
{
    public interface IProdutoRepository
    {
        Task Cadastar(Produto produto);
        Task Atualizar(Produto produto);
        Task<List<Produto>> Listar();
        Task<List<Produto>> ListarPorCliente();
        Task Excluir(Guid produtoId);
        Task<Produto> PesquisarPoId(Guid produtoId);
    }
}
