using UserApi.Models;

namespace UserApi.Services
{
    public interface IUserService
    {
        IEnumerable<UserModel> GetAllUsers();

        UserModelBase GetUser(int userId);

        bool TryUpdateUser(UserModel user);

        bool TryDeleteUser(int userId);

        bool TryCreateUser(UserModel user);
    }
}
