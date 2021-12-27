namespace UserApi.Models
{
    public class UserModel : UserModelBase
    {
        public UserModel(int userId, string firstName, string lastName) 
            : base(userId, firstName, lastName)
        {
        }
    }
}