using LeveMe.Application.InterfacesServices;
using LeveMe.Application.ViewModels;
using LeveMv.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LeveMeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
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

        [HttpGet]
        [Route("listar-por-nome/{nome}")]
        public async Task<List<Produto>> ListarPorNome(string nome)
        {
            return await _produtoService.ListarPorNome(nome);
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
        [Route("listar-cliente/{id},{number}")]
        public async Task<List<Produto>> ListarPorCliente(Guid id, string? number)
        {
            return await _produtoService.ListarPorCliente(id, number);
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
        [Authorize("Manager")]
        public async Task<string> Deletar(Guid id)
        {
            await _produtoService.Excluir(id);
            return "Exclusão efetuada com sucesso!";
        }

        [HttpPut]
        [Route("vender/{id},{quantidade}")]
        [Authorize("Cliente")]
        public async Task<string> Vender(Guid id, int quantidade)
        {
            var msg = await _produtoService.Vender(id, quantidade);
            return msg;
        }
    }
}
