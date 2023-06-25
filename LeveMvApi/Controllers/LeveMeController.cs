using LeveMv.Application.InterfacesServices;
using LeveMv.Application.Services;
using LeveMv.Application.ViewModels;
using LeveMv.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeveMvApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LeveMeController : ControllerBase
    {
        private readonly ILeveMeService _leveMvService;

        public LeveMeController(ILeveMeService leveMvService)
        {
            _leveMvService = leveMvService;
        }

        [HttpGet]
        [Route("listar")]
        public async Task<List<Leveme>> Listar()
        {
            return await _leveMvService.Listar();
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<string> Cadastrar([FromBody] leveMeDto leveMv)
        {
            var entidade = leveMv.ConverterParaEntidade();
            await _leveMvService.Cadastar(entidade);
            return "Cadastro efetuado com sucesso!";
        }

        [HttpGet]
        [Route("listar-cliente")]
        public async Task<List<Leveme>> ListarPorCliente()
        {
            return await _leveMvService.ListarPorCliente();
        }

        [HttpGet]
        [Route("pesquisar/{id}")]
        public async Task<Leveme> Pesquisar(Guid id)
        {
            return await _leveMvService.Pesquisar(id);
        }

        [HttpPut]
        [Route("atualizar")]
        public async Task<string> Atualizar ([FromBody] leveMeDto leveMe)
        {
            var entidade = leveMe.ConverterParaEntidade();
            await _leveMvService.Atualizar(entidade);
            return "Atualizado com sucesso!";
        }


        [HttpDelete]
        [Route("deletar/{id}")]
        public async Task<string> Deletar(Guid idLeveMe)
        {
            await _leveMvService.Excluir(idLeveMe);
            return "Exclusão efetuada com sucesso!";
        }
    }
}
