using LeveMe.Application.InterfacesServices;
using LeveMe.Application.Services;
using LeveMe.Application.ViewModels;
using LeveMe.Data.Repositories;
using LeveMe.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LeveMeApi.Controllers
{
    [Route("api/account")]
    public class AuthenticateController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthenticateController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody]UserDto model)
        {
            var user = _userService.Get(model.UserName, model.Password);

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(user);
            user.Senha = "";

            var userDto = new UserDto();
            userDto.Id = user.ID;
            userDto.UserName = user.Nome;
            userDto.Role = user.Perfil;

            return new 
            {
                user = userDto,
                token = token
            };
        }
    }
}
