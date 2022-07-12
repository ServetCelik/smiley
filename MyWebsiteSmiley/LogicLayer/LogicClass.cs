using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;


namespace LogicLayer
{
    public class LogicClass
    {
        DataBaseHelper helper= new DataBaseHelper();
        List<RegularUser> users= new List<RegularUser>();
        List<Admin> admins= new List<Admin>();
        List<int> id= new List<int>();
        List<string> username = new List<string>();
        List<string> password  = new List<string>();
        List<string> email = new List<string>();

        public void updateUsers()
        {
            users.Clear();
            helper.getAllUsers(id, username, password, email);
            for (int i = 0; i < id.Count; i++)
            {
               users.Add(new RegularUser(id[i],username[i],password[i],email[i]));
            }           
            
        }

        public void updateAdmins()
        {
            admins.Clear();
            helper.getAllAdmins(id, username, password, email);
            for (int i = 0; i < id.Count; i++)
            {
                admins.Add(new Admin(id[i], username[i], password[i], email[i]));
            }
        }

        public void AddUser(string table,string userName, string password, string email)
        {
            helper.CreateUser(table, userName, password, email);
            if (table == "regularUser")
            {
                users.Add(new RegularUser(helper.GetLastRowId(table),userName,password,email));
            }
            else if (table == "admin")
            {
                admins.Add(new Admin(helper.GetLastRowId(table),userName,password,email));
            }            
        }
        public bool CheckUserExistence(string username,string email)
        {
            if (admins.Exists(x=>x.UserName==username))
            {
                return false;
            }
            else if (admins.Exists(x => x.Email == email))
            {
                return false;
            }
            return true;
        }

        public bool LoginCheck(string username, string password)
        {
            if (admins.Exists(x=>x.UserName==username))
            {
                var loggedInUSer = admins.Find(x => x.UserName == username);
                    
                if (loggedInUSer.Password==password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        //public bool control(string username, string password)
        //{
        //    //helper.getAllAdmins(id, username, password, email);

        //    //return id[0];
        //    if (admins.Exists(x => x.UserName == username))
        //    {
        //        return true;
        //    }
        //    return false;
        //}




    }
}
