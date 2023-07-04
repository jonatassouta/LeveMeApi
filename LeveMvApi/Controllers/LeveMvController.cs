using LeveMv.Application.InterfacesServices;
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
        private readonly ILeveMeService _leveMvService;

        public LeveMvController(ILeveMeService leveMvService)
        {
            _leveMvService = leveMvService;
        }

        [HttpGet]
        [Route("listar")]
        public async Task<List<Levemv>> Listar()
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
        public async Task<List<LeveMv.Domain.Models.Levemv>> ListarPorCliente()
        {
            return await _leveMvService.ListarPorCliente();
        }

        [HttpGet]
        [Route("pesquisar/{id}")]
        public async Task<LeveMv.Domain.Models.Levemv> Pesquisar(Guid id)
        {
            return await _leveMvService.Pesquisar(id);
        }

        [HttpGet]
        [Route("listar-por-nome/{nome}")]
        public async Task<List<LeveMv.Domain.Models.Levemv>> ListarPorNome(string nome)
        {
            return await _leveMvService.ListarPorNome(nome);
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
        public async Task<string> Deletar(Guid id)
        {
            var leveMv = await Pesquisar(id);
            if (leveMv != null && !string.IsNullOrEmpty(leveMv.ID.ToString()) && leveMv.ID.Equals(id))
            {
                await _leveMvService.Excluir(id);
                return "Excluido com sucesso";
            }
            else
            {
                return "Registro não encontrado!";
            }
        }
    }
}
