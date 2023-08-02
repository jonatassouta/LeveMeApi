using LeveMe.Domain.InterfacesRepositories;
using LeveMv.Data.Context;
using LeveMv.Domain.Models;

namespace LeveMe.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly LeveMeContext _context;
        public UserRepository(LeveMeContext context)
        {
            _context = context;
        }

        public Cliente Get(string username, string password)
        {
            var users = _context.Clientes.Where(x => x.Nome.ToLower() == username.ToLower() && x.Senha == password).FirstOrDefault();
            
            return users;
        }
    }
}
