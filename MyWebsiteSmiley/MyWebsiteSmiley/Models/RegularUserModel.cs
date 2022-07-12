namespace MyWebsiteSmiley.Models
{
    public class RegularUserModel : UserModel
    {
        public RegularUserModel(int userId, string userName, string password, string email) : base(userId, userName, password, email)
        {
        }
    }
}
