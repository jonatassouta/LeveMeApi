using LeveMv.Application.InterfacesServices;
using LeveMv.Domain.InterfacesRepositories;
using LeveMv.Domain.Models;

namespace LeveMv.Application.Services
{
    public class LeveMeService : ILeveMeService
    {
        private readonly ILeveMeRepository _iLeveMvRepositories;

        public LeveMeService(ILeveMeRepository iLeveMvRepositories)
        {
            _iLeveMvRepositories = iLeveMvRepositories;
        }

        public async Task Atualizar(Levemv leveMv)
        {
            try
            {
                await _iLeveMvRepositories.Atualizar(leveMv);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Cadastar(Domain.Models.Levemv leveMv)
        {
            try
            {
                await _iLeveMvRepositories.Cadastar(leveMv);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Excluir(Guid leveMvId)
        {
            try
            {
                await _iLeveMvRepositories.Excluir(leveMvId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<Levemv>> Listar()
        {
            try
            {
               return await _iLeveMvRepositories.Listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<Levemv>> ListarPorCliente()
        {
            try
            {
               return await _iLeveMvRepositories.ListarPorCliente();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<Domain.Models.Levemv>> ListarPorNome(string nome)
        {
            try
            {
                return await _iLeveMvRepositories.ListarPorNome(nome);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Domain.Models.Levemv> Pesquisar(Guid leveMvId)
        {
            try
            {
                return await _iLeveMvRepositories.Pesquisar(leveMvId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
