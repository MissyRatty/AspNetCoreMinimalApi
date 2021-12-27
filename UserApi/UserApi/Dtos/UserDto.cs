namespace UserApi.Dtos
{
    public class UserDto : UserDtoBase
    {
        public UserDto(int userId, string firstName, string lastName) 
            : base(userId, firstName, lastName)
        {
        }
    }
}