using LeveMe.Application.InterfacesServices;
using LeveMe.Domain.InterfacesRepositories;
using LeveMv.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeveMe.Application.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _iUserRepository;

        public UserService(IUserRepository iUserRepository)
        {
            _iUserRepository = iUserRepository;
        }

        public Cliente Get(string username, string password)
        {
            try
            {
                return _iUserRepository.Get(username, password);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
