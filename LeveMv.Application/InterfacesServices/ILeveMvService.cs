using LeveMv.Domain.Models;

namespace LeveMv.Application.InterfacesServices
{
    public interface ILeveMvService
    {
        Task Cadastar(LeMv leveMv);
        Task Atualizar(LeMv leveMv);
        Task<List<LeMv>> Listar();
        Task<List<LeMv>> ListarPorCliente();
        Task Excluir(Guid leveMvId);
        Task<LeMv> Pesquisar(Guid leveMvId);
    }
}
