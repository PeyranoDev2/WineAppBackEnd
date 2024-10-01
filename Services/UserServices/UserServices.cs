using Common.Models;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.UserServices
{
    public class UserServices : IUserServices
    {
        public readonly IUserRepository _userRepository;
        public UserServices(IUserRepository userHardCodedDBRepository)
        {
            _userRepository = userHardCodedDBRepository;
        }

        public void AddUser(UserForCreateDTO userForCreateDTO)
        {
            if (_userRepository.GetUsers().All(user => user.Username != userForCreateDTO.Username))
            {
                _userRepository.AddUser(
                    new Data.Entities.User
                    {
                        Id = _userRepository.GetUsers().Max(x => x.Id) + 1,
                        Username = userForCreateDTO.Username,
                        Password = userForCreateDTO.Password
                    }
                    );
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
