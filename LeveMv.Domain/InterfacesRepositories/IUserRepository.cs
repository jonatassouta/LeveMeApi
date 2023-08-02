using LeveMv.Domain.Models;

namespace LeveMe.Domain.InterfacesRepositories
{
    public interface IUserRepository
    {
        public Cliente Get(string username, string password);
    }
}
