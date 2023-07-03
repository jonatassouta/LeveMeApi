using LeveMv.Domain.Models;

namespace LeveMv.Domain.InterfacesRepositories
{
    public interface ILeveMeRepository
    {
        Task Cadastar(Levemv leveMv);
        Task Atualizar(Models.Levemv leveMv);
        Task<List<Models.Levemv>> Listar();
        Task<List<Models.Levemv>> ListarPorNome(string nome);
        Task<List<Models.Levemv>> ListarPorCliente();
        Task<string> Excluir(Guid leveMvId);
        Task<Models.Levemv> Pesquisar(Guid leveMvId);
    }
}
