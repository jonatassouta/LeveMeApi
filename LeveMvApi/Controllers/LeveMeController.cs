using LeveMv.Application.Services;
using LeveMv.Application.ViewModels;
using LeveMv.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeveMvApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LeveMvController : ControllerBase
    {
        private readonly LeveMeService _leveMvService;

        public LeveMvController(LeveMeService leveMvService)
        {
            _leveMvService = leveMvService;
        }

        [HttpGet]
        [Route("listar")]
        public async Task<List<LeveMe>> Listar()
        {
            return await _leveMvService.Listar();
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<string> Cadastra([FromBody] leveMeDto leveMv)
        {
            var entidade = leveMv.ConverterParaEntidade();
            await _leveMvService.Cadastar(entidade);
            return "Cadastro efetuado com sucesso!";
        }

        [HttpGet]
        [Route("listar-cliente")]
        public async Task<List<LeveMe>> ListarPorCliente()
        {
            return await _leveMvService.ListarPorCliente();
        }
    }
}
