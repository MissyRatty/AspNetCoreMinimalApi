using UserApi.Dtos;
using UserApi.Mappers;
using UserApi.Models;
using UserApi.Repositories;

namespace UserApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool TryCreateUser(UserModel user)
        {
            var userDto = user.ToDto();

            return _userRepository.TryCreateUser(userDto);
        }

        public bool TryDeleteUser(int userId)
        {
            return _userRepository.TryDeleteUser(userId);
        }

        public UserModelBase GetUser(int userId)
        {
            var userDtoBase = _userRepository.GetById(userId);

            if (userDtoBase.UserId.Equals(0))
            {
                return new NullUserModel();
            }

            return userDtoBase.ToModel();
        }

        public bool TryUpdateUser(UserModel user)
        {
            return _userRepository.TryUpdateUser(user.ToDto());
        }

        public IEnumerable<UserModel> GetAllUsers()
        {
            var userDtos = _userRepository.GetAllUsers();

            foreach(var userDto in userDtos)
            {
                var userModel = userDto.ToModel();
                yield return userModel; 
            }

           yield break;
        }
    }
}
