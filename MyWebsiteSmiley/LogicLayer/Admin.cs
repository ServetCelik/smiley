using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicLayer
{
    public class Admin : User
    {
        public Admin(int userId, string userName, string password, string email) : base(userId, userName, password, email)
        {
        }
        public Admin(string userName, string password, string email) : base(userName, password, email)
        {
        }
        public Admin()
        {

        }
    }
}
