using LeveMv.Domain.Models;

namespace LeveMv.Application.InterfacesServices
{
    public interface ILeveMeService
    {
        Task Cadastar(Domain.Models.Levemv leveMv);
        Task Atualizar(Domain.Models.Levemv leveMv);
        Task<List<Domain.Models.Levemv>> Listar();
        Task<List<Domain.Models.Levemv>> ListarPorNome(string nome);
        Task<List<Domain.Models.Levemv>> ListarPorCliente();
        Task Excluir(Guid leveMvId);
        Task<Domain.Models.Levemv> Pesquisar(Guid leveMvId);
    }
}
