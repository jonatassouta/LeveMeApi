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
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        [Route("listar")]
        public async Task<List<Cliente>> Listar()
        {
            return await _clienteService.Listar();
        }

        [HttpGet]
        [Route("listar-por-nome/{nome}")]
        public async Task<List<Cliente>> ListarPorNome(string nome)
        {
            return await _clienteService.ListarPorNome(nome);
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<string> Cadastrar([FromBody] ClienteDto cliente)
        {
            var entidade = cliente.ConverterParaEntidade();
            string msg = await _clienteService.Cadastar(entidade);
            return msg;
        }

        [HttpGet]
        [Route("pesquisar/{id}")]
        public async Task<Cliente> Pesquisar(Guid id)
        {
            return await _clienteService.PesquisarPoId(id);
        }

        [HttpPut]
        [Route("atualizar")]
        public async Task<string> Atualizar([FromBody] ClienteDto cliente)
        {
            var entidade = cliente.ConverterParaEntidade();
            await _clienteService.Atualizar(entidade);
            return "Atualizado com sucesso!";
        }

        [HttpDelete]
        [Route("deletar/{id}")]
        public async Task<string> Deletar(Guid id)
        {
            await _clienteService.Excluir(id);
            return "Exclusão efetuada com sucesso!";
        }
    }
}
