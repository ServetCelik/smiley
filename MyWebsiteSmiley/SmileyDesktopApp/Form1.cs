using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;







namespace SmileyDesktopApp
{
    public partial class Form1 : Form
    {   LogicClass logicClass = new LogicClass();
        List<Post> posts = new();
        User loggedInUser = new RegularUser(10,"WesleySneijder","1234","asda@email");
        int number=0;

        public Form1()
        {
            InitializeComponent();

            posts.Add(new Post("Programmers, everyday", "programmer.PNG", loggedInUser));
            posts.Add(new Post("If ramen noodles can’t fix it, don’t mention it.", "mechanic.PNG", loggedInUser));
            posts.Add(new Post("I like broccoli and sports. Go sports!", "brocoli.PNG", loggedInUser));
            posts.Add(new Post("OMG!", "car.PNG", loggedInUser));
            UpdateHomePage();
            tabControl.TabPages.Remove(tabHome);
            tabControl.TabPages.Remove(tabSignUp);
            tabControl.TabPages.Remove(tabLogIn);
            logicClass.updateUsers();
            logicClass.updateAdmins();
            //lblTitle.TextAlign = (ContentAlignment)HorizontalAlignment.Center;

        }


        private void btnDirectToLoginPage_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Add(tabLogIn);
            tabControl.TabPages.Remove(tabWelcome);
            //LogicLayer.Post post = new Post();
            //post.Title = "asdasd";
        }

        private void btnDirectToHomePage_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //this.number--;
            number = (number-1) % posts.Count;           
            if (number==-1)
            {
                number = posts.Count-1;
            }
            UpdateHomePage();
        }
        public void UpdateHomePage()
        {            
            lblTitle.Text = posts[number].Title;
            //var s = @"C:\Users\srvtc\Desktop\smiley\git\s2-cmk-wad-servet-can-celik-web-app-smiley\MyWebsiteSmiley\SmileyDesktopApp\\";
            var s = @".\Images";

            var b = Path.Combine(s, posts[number].ImgURL);
            pBHome.Image = Image.FromFile(b);          
            

        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            //this.number++;
            number=(number+ 1)%posts.Count;
            UpdateHomePage();
        }
        // i only check if admin exists, i will check it for user later.
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string userName = tbSignupUserName.Text;
            string password = tbSignupPassword.Text;
            string email = tbSignupEmail.Text;
            if (string.IsNullOrEmpty(password)||string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email)||(!rBRegularUser.Checked & !rBAdmin.Checked))
            {
                MessageBox.Show("Oppps, Next time fill all the fields...");
            }
            else
            {
                if (logicClass.CheckUserExistence(userName, email))
                {
                    if (rBRegularUser.Checked)
                    {
                        logicClass.AddUser("regularUser", userName, password, email);
                    }
                    else if (rBAdmin.Checked)
                    {
                        logicClass.AddUser("admin", userName, password, email);
                    }
                    MessageBox.Show("Succesfully added");
                }
                else
                {
                    MessageBox.Show("This username or email already exists");
                }
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = tbLoginUserName.Text;
            string password = tbLoginPassword.Text;
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Oppps, Next time fill all the fields...");                
            }
            else
            {
                if (logicClass.LoginCheck(userName, password))
                {
                    tabControl.TabPages.Add(tabHome);
                    tabControl.TabPages.Add(tabSignUp);
                    tabControl.TabPages.Remove(tabWelcome);
                    tabControl.TabPages.Remove(tabLogIn);
                }
                else
                {
                    MessageBox.Show("Under this circumstances, You better go and login other apps");
                }
            }
            



            //if (logicClass.control(userName,password))
            //{
            //    MessageBox.Show("ok");
            //}

            //MessageBox.Show(Convert.ToString(logicClass.control()));

        }

        
    }
}
