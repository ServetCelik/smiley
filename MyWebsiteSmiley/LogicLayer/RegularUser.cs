using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class RegularUser : User
    {
        public RegularUser(string userName, string password, string email) : base(userName, password, email)
        {
        }

        public RegularUser(int userId, string userName, string password, string email) : base(userId, userName, password, email)
        {
        }
        public RegularUser()
        {

        }
    }
}
