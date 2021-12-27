namespace UserApi.Dtos
{
    public class NullUserDto : UserDtoBase
    {
        public NullUserDto(int userId = 0, string firstName = "", string lastName = "") 
            : base(userId, firstName, lastName)
        {
        }
    }
}