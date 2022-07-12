using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogicLayer
{
    public abstract class User
    {
        int userId;
        string userName;
        string password;
        string email;

        public User(int userId, string userName, string password, string email)
        {
            this.userId = userId;
            this.userName = userName;
            this.password = password;
            this.email = email;
        }

        protected User(string userName, string password, string email)
        {
            this.userName = userName;
            this.password = password;
            this.email = email;
        }
        public User()
        {

        }


        public int UserId { get => userId; set => userId = value; }

        [Required]
        [StringLength(15, ErrorMessage = "The minimum allowed length is 4 characters.", MinimumLength = 4)]        
        
        public string UserName { get => userName; set => userName = value; }

        [Required]
        //[DataType(DataType.Password)]
        //[RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        public string Password { get => password; set => password = value; }

        [Required]
        [EmailAddress(ErrorMessage = " Invalid e-mail adress.")]
        public string Email { get => email; set => email = value; }
    }
}
