using UserApi.Dtos;
using UserApi.Helpers;

namespace UserApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDatasource _datasource;

        public UserRepository(IDatasource datasource)
        {
            _datasource = datasource;
        }

        public bool TryCreateUser(UserDto user)
        {

            if (_datasource.Users.TryGetValue(user.UserId, out UserDto existingUser))
            {
                return false;
            }

            _datasource.Users.Add(user.UserId, user);
            return true;
        }

        public bool TryDeleteUser(int userId)
        {
            return _datasource.Users.Remove(userId);
        }

        public IEnumerable<UserDto> GetAllUsers()
        {
            var users = _datasource.Users;

            return users.Values;
        }

        public UserDtoBase GetById(int id)
        {

            if (_datasource.Users.TryGetValue(id, out UserDto existingUser))
            {
                return existingUser;
            }

            return new NullUserDto();
        }

        public bool TryUpdateUser(UserDto user)
        {

            if (_datasource.Users.TryGetValue(user.UserId, out UserDto existingUser))
            {
                var removedSuccessfully = _datasource.Users.Remove(user.UserId);

                if (removedSuccessfully)
                {
                    _datasource.Users.Add(user.UserId, user);
                    return true;
                }
            }

            return false;
        }
    }
}
