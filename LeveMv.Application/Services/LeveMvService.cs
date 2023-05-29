using LeveMv.Application.InterfacesServices;
using LeveMv.Domain.InterfacesRepositories;
using LeveMv.Domain.Models;

namespace LeveMv.Application.Services
{
    public class LeveMvService : ILeveMvService
    {
        private readonly ILeveMvRepository _iLeveMvRepositories;

        public LeveMvService(ILeveMvRepository iLeveMvRepositories)
        {
            _iLeveMvRepositories = iLeveMvRepositories;
        }

        public async Task Atualizar(LeMv leveMv)
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

        public async Task Cadastar(LeMv leveMv)
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

        public async Task<List<LeMv>> Listar()
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

        public async Task<List<LeMv>> ListarPorCliente()
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

        public async Task<LeMv> Pesquisar(Guid leveMvId)
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
