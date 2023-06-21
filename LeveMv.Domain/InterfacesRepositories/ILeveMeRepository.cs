using LeveMv.Domain.Models;

namespace LeveMv.Domain.InterfacesRepositories
{
    public interface ILeveMeRepository
    {
        Task Cadastar(Leveme leveMv);
        Task Atualizar(Leveme leveMv);
        Task<List<Leveme>> Listar();
        Task<List<Leveme>> ListarPorCliente();
        Task Excluir(Guid leveMvId);
        Task<Leveme> Pesquisar(Guid leveMvId);
    }
}
