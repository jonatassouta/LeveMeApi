using LeveMe.Domain.Models;

namespace LeveMe.Data.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, UserName = "Jonatas", Password = "jonatas", Role = "manager"});
            users.Add(new User { Id = 2, UserName = "teste", Password = "teste", Role = "cliente" });
            return users.Where( x => x.UserName.ToLower() == username.ToLower() && x.Password == password).FirstOrDefault();
        }
    }
}
