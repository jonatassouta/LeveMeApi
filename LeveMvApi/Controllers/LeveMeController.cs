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
    }
}
