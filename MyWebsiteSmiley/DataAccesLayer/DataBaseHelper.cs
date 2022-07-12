using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace DataAccesLayer
{
    public class DataBaseHelper
    {
        MySqlConnection con = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi489394;Database=dbi489394;Pwd=1234;");
        MySqlCommand cmd = new MySqlCommand();       


        public void CreateUser(string table, string userName, string password, string email)
        {
            try
            {
                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();
                    if (table== "regularUser")
                    {
                        cmd.CommandText = "INSERT INTO smileyregularuser (userName,password,email) VALUES(@userName,@password,@email)";
                    }
                    else if (table== "admin")
                    {
                        cmd.CommandText = "INSERT INTO smileyadmin (userName,password,email) VALUES(@userName,@password,@email)";
                    }                                      
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);
                    
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(Convert.ToString(ex));
                
            }
            finally
            {
                con.Close();
            }
        }

        //public int GetLastAddedId()
        //{            
        //    cmd = con.CreateCommand();
        //    cmd.CommandText = "SELECT id smileyregularuser Table ORDER BY ID DESC LIMIT 1";

        //    int id=0;
        //    try
        //    {
        //        con.Open();

        //        using (con)
        //        {
        //            MySqlDataReader reader = cmd.ExecuteReader();
        //            using (reader)
        //            {
        //                while (reader.Read())
        //                {
        //                    id = Convert.ToInt32(reader["id"]);                     
                            
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(Convert.ToString(ex));
        //    }
        //    finally
        //    {
        //        con.Close();
                
        //    }
        //    return id;
        //}

        public void getAllUsers(List<int> id, List<string> username, List<string> password, List<string> email)
        {
            id.Clear();
            username.Clear();
            password.Clear();
            email.Clear();

            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM smileyregularuser";

            try
            {
                con.Open();

                using (con)
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            id.Add(Convert.ToInt32(reader["id"]));
                            username.Add(Convert.ToString(reader["username"]));
                            password.Add(Convert.ToString(reader["password"]));
                            email.Add(Convert.ToString(reader["email"]));
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(Convert.ToString(ex));
            }
            finally
            {
                con.Close();
            }
            
        }

        public void getAllAdmins(List<int> id, List<string> username, List<string> password, List<string> email)
        {
            id.Clear();
            username.Clear();
            password.Clear();
            email.Clear();

            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM smileyadmin";

            try
            {
                con.Open();

                using (con)
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            id.Add(Convert.ToInt32(reader["id"]));
                            username.Add(Convert.ToString(reader["username"]));
                            password.Add(Convert.ToString(reader["password"]));
                            email.Add(Convert.ToString(reader["email"]));
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(Convert.ToString(ex));
            }
            finally
            {
                con.Close();
            }
        }

        public int GetLastRowId(string table)
        {
            int id = 0;
            cmd = con.CreateCommand();
            if (table == "regularUser")
            {
                cmd.CommandText = "SELECT id FROM smileyregularuser ORDER BY id DESC LIMIT 1";
            }
            else if (table == "admin")
            {
                cmd.CommandText = "SELECT id FROM smileyadmin ORDER BY id DESC LIMIT 1";
            }
            

            try
            {
                con.Open();

                using (con)
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            id=(Convert.ToInt32(reader["id"]));
                            
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(Convert.ToString(ex));
            }
            finally
            {
                con.Close();
            }
            return id;
        }
    }
    
}
