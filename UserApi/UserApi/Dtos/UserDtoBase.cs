namespace UserApi.Dtos
{
    public class UserDtoBase
    {
        public UserDtoBase(int userId, string firstName, string lastName)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
        }

        public int UserId { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }
    }
}