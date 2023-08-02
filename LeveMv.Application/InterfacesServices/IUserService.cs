using LeveMv.Domain.Models;

namespace LeveMe.Application.InterfacesServices
{
    public interface IUserService
    {
        public Cliente Get(string username, string password);
    }
}
