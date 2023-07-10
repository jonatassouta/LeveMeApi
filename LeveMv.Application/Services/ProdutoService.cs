using LeveMe.Application.InterfacesServices;
using LeveMe.Domain.InterfacesRepositories;
using LeveMv.Domain.Models;

namespace LeveMe.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _iProdutoRepositories;

        public ProdutoService(IProdutoRepository iProdutoRepositories)
        {
            _iProdutoRepositories = iProdutoRepositories;
        }

        public async Task Atualizar(Produto produto)
        {
            try
            {
                await _iProdutoRepositories.Atualizar(produto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Cadastar(Produto produto)
        {
            try
            {
                await _iProdutoRepositories.Cadastar(produto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Excluir(Guid produtoId)
        {
            try
            {
                await _iProdutoRepositories.Excluir(produtoId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<Produto>> Listar()
        {
            try
            {
                return await _iProdutoRepositories.Listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<Produto>> ListarPorNome(string nome)
        {
            try
            {
                return await _iProdutoRepositories.ListarPorNome(nome);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<Produto>> ListarPorCliente(Guid id, string? number)
        {
            try
            {
                return await _iProdutoRepositories.ListarPorCliente(id, number);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Produto> PesquisarPoId(Guid produtoId)
        {
            try
            {
                return await _iProdutoRepositories.PesquisarPoId(produtoId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<string> Vender(Guid produtoId, int quantidade)
        {
            try
            {
                return await _iProdutoRepositories.Vender(produtoId, quantidade);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
