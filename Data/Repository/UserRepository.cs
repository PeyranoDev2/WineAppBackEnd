using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UserRepository : IUserRepository
    {

        private List<User> users = new List<User>()
        {
            new User
            {
                Id = 1,
                Username = "admin",
                Password = "admin"
            },
            new User
            {
                Id = 2,
                Username = "test",
                Password = "test12345"
            }
        };
        public List<User> GetUsers()
        {
            return users;
        }
        public void AddUser(User user)
        {
            users.Add(user);
        }
    }
}
