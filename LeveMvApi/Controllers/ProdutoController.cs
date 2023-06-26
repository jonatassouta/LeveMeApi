using LeveMe.Application.InterfacesServices;
using LeveMe.Application.ViewModels;
using LeveMv.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeveMeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        [Route("listar")]
        public async Task<List<Produto>> Listar()
        {
            return await _produtoService.Listar();
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<string> Cadastrar([FromBody] ProdutoDto produto)
        {
            var entidade = produto.ConverterParaEntidade();
            await _produtoService.Cadastar(entidade);
            return "Cadastro efetuado com sucesso!";
        }

        [HttpGet]
        [Route("listar-cliente")]
        public async Task<List<Produto>> ListarPorCliente()
        {
            return await _produtoService.ListarPorCliente();
        }

        [HttpGet]
        [Route("pesquisar/{id}")]
        public async Task<Produto> Pesquisar(Guid id)
        {
            return await _produtoService.PesquisarPoId(id);
        }

        [HttpPut]
        [Route("atualizar")]
        public async Task<string> Atualizar([FromBody] ProdutoDto produto)
        {
            var entidade = produto.ConverterParaEntidade();
            await _produtoService.Atualizar(entidade);
            return "Atualizado com sucesso!";
        }


        [HttpDelete]
        [Route("deletar/{id}")]
        public async Task<string> Deletar(Guid id)
        {
            await _produtoService.Excluir(id);
            return "Exclusão efetuada com sucesso!";
        }
    }
}
