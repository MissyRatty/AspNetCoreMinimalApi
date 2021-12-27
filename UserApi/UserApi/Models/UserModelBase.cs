namespace UserApi.Models
{
    public class UserModelBase
    {
        public UserModelBase(int userId, string firstName, string lastName)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
        }

        public int UserId { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; set; }
    }
}
