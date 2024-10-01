using Common.Models;

namespace Services.UserServices
{
    public interface IUserServices
    {
        void AddUser(UserForCreateDTO userForCreateDTO);
    }
}