namespace UserApi.Models
{
    public class NullUserModel : UserModelBase
    {
        public NullUserModel(int userId = 0, string firstName = "", string lastName = "") 
            : base(userId, firstName, lastName)
        {
        }
    }
}