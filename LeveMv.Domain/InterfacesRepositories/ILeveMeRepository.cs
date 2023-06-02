using LeveMv.Domain.Models;

namespace LeveMv.Domain.InterfacesRepositories
{
    public interface ILeveMeRepository
    {
        Task Cadastar(LeveMe leveMv);
        Task Atualizar(LeveMe leveMv);
        Task<List<LeveMe>> Listar();
        Task<List<LeveMe>> ListarPorCliente();
        Task Excluir(Guid leveMvId);
        Task<LeveMe> Pesquisar(Guid leveMvId);
    }
}
