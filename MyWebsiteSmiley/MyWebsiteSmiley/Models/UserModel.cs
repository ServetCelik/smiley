namespace MyWebsiteSmiley.Models
{
    public class UserModel
    {
        public UserModel(int userId, string userName, string password, string email)
        {
            UserId = userId;
            UserName = userName;
            Password = password;
            Email = email;
        }
        public UserModel()
        {

        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }
}
