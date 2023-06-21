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

        public async Task Atualizar(Leveme leveMv)
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

        public async Task Cadastar(Leveme leveMv)
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

        public async Task<List<Leveme>> Listar()
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

        public async Task<List<Leveme>> ListarPorCliente()
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

        public async Task<Leveme> Pesquisar(Guid leveMvId)
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
