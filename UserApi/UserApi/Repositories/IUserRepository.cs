using UserApi.Dtos;

namespace UserApi.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<UserDto> GetAllUsers();

        UserDtoBase GetById(int id);

        bool TryUpdateUser(UserDto user);

        bool TryDeleteUser(int userId);

        bool TryCreateUser(UserDto user);
    }
}
