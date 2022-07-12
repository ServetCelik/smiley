namespace MyWebsiteSmiley.Models
{
    public class AdminModel : UserModel
    {
        public AdminModel(int userId, string userName, string password, string email) : base(userId, userName, password, email)
        {
        }
    }
}
