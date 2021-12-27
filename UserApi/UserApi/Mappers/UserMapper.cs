using UserApi.Dtos;
using UserApi.Models;

namespace UserApi.Mappers
{
    public static class UserMapper
    {
        public static UserModel ToModel(this UserDtoBase userDtoBase)
        {
            return new UserModel(userDtoBase.UserId, userDtoBase.FirstName, userDtoBase.LastName);
        }

        public static UserDto ToDto(this UserModelBase userModelBase)
        {
            return new UserDto(userModelBase.UserId, userModelBase.FirstName, userModelBase.LastName);
        }
    }
}
