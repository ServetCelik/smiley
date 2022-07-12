namespace SmileyDesktopApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabSignUp = new System.Windows.Forms.TabPage();
            this.rBAdmin = new System.Windows.Forms.RadioButton();
            this.rBRegularUser = new System.Windows.Forms.RadioButton();
            this.tbSignupEmail = new System.Windows.Forms.TextBox();
            this.tbSignupPassword = new System.Windows.Forms.TextBox();
            this.tbSignupUserName = new System.Windows.Forms.TextBox();
            this.lblSignupEmail = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblSignUpPassword = new System.Windows.Forms.Label();
            this.lblSignupUserName = new System.Windows.Forms.Label();
            this.tabLogIn = new System.Windows.Forms.TabPage();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.tbLoginUserName = new System.Windows.Forms.TextBox();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.lblLoginUserName = new System.Windows.Forms.Label();
            this.tabWelcome = new System.Windows.Forms.TabPage();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDirectToLoginPage = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pBHome = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabSignUp.SuspendLayout();
            this.tabLogIn.SuspendLayout();
            this.tabWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBHome)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSignUp
            // 
            this.tabSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(254)))), ((int)(((byte)(194)))));
            this.tabSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabSignUp.BackgroundImage")));
            this.tabSignUp.Controls.Add(this.rBAdmin);
            this.tabSignUp.Controls.Add(this.rBRegularUser);
            this.tabSignUp.Controls.Add(this.tbSignupEmail);
            this.tabSignUp.Controls.Add(this.tbSignupPassword);
            this.tabSignUp.Controls.Add(this.tbSignupUserName);
            this.tabSignUp.Controls.Add(this.lblSignupEmail);
            this.tabSignUp.Controls.Add(this.btnSignUp);
            this.tabSignUp.Controls.Add(this.lblSignUpPassword);
            this.tabSignUp.Controls.Add(this.lblSignupUserName);
            this.tabSignUp.Location = new System.Drawing.Point(4, 29);
            this.tabSignUp.Name = "tabSignUp";
            this.tabSignUp.Size = new System.Drawing.Size(644, 555);
            this.tabSignUp.TabIndex = 3;
            this.tabSignUp.Text = "Sign Up";
            // 
            // rBAdmin
            // 
            this.rBAdmin.AutoSize = true;
            this.rBAdmin.BackColor = System.Drawing.Color.White;
            this.rBAdmin.Location = new System.Drawing.Point(133, 334);
            this.rBAdmin.Name = "rBAdmin";
            this.rBAdmin.Size = new System.Drawing.Size(74, 24);
            this.rBAdmin.TabIndex = 13;
            this.rBAdmin.TabStop = true;
            this.rBAdmin.Text = "Admin";
            this.rBAdmin.UseVisualStyleBackColor = false;
            // 
            // rBRegularUser
            // 
            this.rBRegularUser.AutoSize = true;
            this.rBRegularUser.BackColor = System.Drawing.Color.White;
            this.rBRegularUser.Location = new System.Drawing.Point(133, 294);
            this.rBRegularUser.Name = "rBRegularUser";
            this.rBRegularUser.Size = new System.Drawing.Size(114, 24);
            this.rBRegularUser.TabIndex = 12;
            this.rBRegularUser.TabStop = true;
            this.rBRegularUser.Text = "Regular User";
            this.rBRegularUser.UseVisualStyleBackColor = false;
            // 
            // tbSignupEmail
            // 
            this.tbSignupEmail.Location = new System.Drawing.Point(322, 225);
            this.tbSignupEmail.Name = "tbSignupEmail";
            this.tbSignupEmail.Size = new System.Drawing.Size(183, 27);
            this.tbSignupEmail.TabIndex = 11;
            // 
            // tbSignupPassword
            // 
            this.tbSignupPassword.Location = new System.Drawing.Point(322, 159);
            this.tbSignupPassword.Name = "tbSignupPassword";
            this.tbSignupPassword.Size = new System.Drawing.Size(183, 27);
            this.tbSignupPassword.TabIndex = 8;
            // 
            // tbSignupUserName
            // 
            this.tbSignupUserName.Location = new System.Drawing.Point(322, 96);
            this.tbSignupUserName.Name = "tbSignupUserName";
            this.tbSignupUserName.Size = new System.Drawing.Size(183, 27);
            this.tbSignupUserName.TabIndex = 7;
            // 
            // lblSignupEmail
            // 
            this.lblSignupEmail.AutoSize = true;
            this.lblSignupEmail.BackColor = System.Drawing.Color.White;
            this.lblSignupEmail.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSignupEmail.Location = new System.Drawing.Point(133, 223);
            this.lblSignupEmail.Name = "lblSignupEmail";
            this.lblSignupEmail.Size = new System.Drawing.Size(69, 26);
            this.lblSignupEmail.TabIndex = 10;
            this.lblSignupEmail.Text = "Email";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignUp.Location = new System.Drawing.Point(347, 361);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(94, 29);
            this.btnSignUp.TabIndex = 9;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblSignUpPassword
            // 
            this.lblSignUpPassword.AutoSize = true;
            this.lblSignUpPassword.BackColor = System.Drawing.Color.White;
            this.lblSignUpPassword.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSignUpPassword.Location = new System.Drawing.Point(133, 157);
            this.lblSignUpPassword.Name = "lblSignUpPassword";
            this.lblSignUpPassword.Size = new System.Drawing.Size(106, 26);
            this.lblSignUpPassword.TabIndex = 6;
            this.lblSignUpPassword.Text = "Password";
            // 
            // lblSignupUserName
            // 
            this.lblSignupUserName.AutoSize = true;
            this.lblSignupUserName.BackColor = System.Drawing.Color.White;
            this.lblSignupUserName.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSignupUserName.Location = new System.Drawing.Point(133, 97);
            this.lblSignupUserName.Name = "lblSignupUserName";
            this.lblSignupUserName.Size = new System.Drawing.Size(119, 26);
            this.lblSignupUserName.TabIndex = 5;
            this.lblSignupUserName.Text = "User Name";
            // 
            // tabLogIn
            // 
            this.tabLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(254)))), ((int)(((byte)(194)))));
            this.tabLogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabLogIn.BackgroundImage")));
            this.tabLogIn.Controls.Add(this.btnLogin);
            this.tabLogIn.Controls.Add(this.tbLoginPassword);
            this.tabLogIn.Controls.Add(this.tbLoginUserName);
            this.tabLogIn.Controls.Add(this.lblLoginPassword);
            this.tabLogIn.Controls.Add(this.lblLoginUserName);
            this.tabLogIn.Location = new System.Drawing.Point(4, 29);
            this.tabLogIn.Name = "tabLogIn";
            this.tabLogIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogIn.Size = new System.Drawing.Size(644, 555);
            this.tabLogIn.TabIndex = 2;
            this.tabLogIn.Text = "Log In";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(371, 327);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 29);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.Location = new System.Drawing.Point(325, 224);
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.Size = new System.Drawing.Size(183, 27);
            this.tbLoginPassword.TabIndex = 3;
            // 
            // tbLoginUserName
            // 
            this.tbLoginUserName.Location = new System.Drawing.Point(325, 154);
            this.tbLoginUserName.Name = "tbLoginUserName";
            this.tbLoginUserName.Size = new System.Drawing.Size(183, 27);
            this.tbLoginUserName.TabIndex = 2;
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.BackColor = System.Drawing.Color.White;
            this.lblLoginPassword.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginPassword.Location = new System.Drawing.Point(123, 225);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(106, 26);
            this.lblLoginPassword.TabIndex = 1;
            this.lblLoginPassword.Text = "Password";
            // 
            // lblLoginUserName
            // 
            this.lblLoginUserName.AutoSize = true;
            this.lblLoginUserName.BackColor = System.Drawing.Color.White;
            this.lblLoginUserName.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginUserName.Location = new System.Drawing.Point(123, 152);
            this.lblLoginUserName.Name = "lblLoginUserName";
            this.lblLoginUserName.Size = new System.Drawing.Size(119, 26);
            this.lblLoginUserName.TabIndex = 0;
            this.lblLoginUserName.Text = "User Name";
            // 
            // tabWelcome
            // 
            this.tabWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tabWelcome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabWelcome.BackgroundImage")));
            this.tabWelcome.Controls.Add(this.lblWelcome);
            this.tabWelcome.Controls.Add(this.pictureBox1);
            this.tabWelcome.Controls.Add(this.btnDirectToLoginPage);
            this.tabWelcome.Location = new System.Drawing.Point(4, 29);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tabWelcome.Size = new System.Drawing.Size(644, 555);
            this.tabWelcome.TabIndex = 0;
            this.tabWelcome.Text = "WelcomeToSmiley";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.White;
            this.lblWelcome.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Image = ((System.Drawing.Image)(resources.GetObject("lblWelcome.Image")));
            this.lblWelcome.Location = new System.Drawing.Point(231, 182);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(176, 23);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome to Smiley";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(277, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnDirectToLoginPage
            // 
            this.btnDirectToLoginPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDirectToLoginPage.BackgroundImage")));
            this.btnDirectToLoginPage.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDirectToLoginPage.Location = new System.Drawing.Point(222, 263);
            this.btnDirectToLoginPage.Name = "btnDirectToLoginPage";
            this.btnDirectToLoginPage.Size = new System.Drawing.Size(197, 73);
            this.btnDirectToLoginPage.TabIndex = 1;
            this.btnDirectToLoginPage.Text = "Go to Log-in Page";
            this.btnDirectToLoginPage.UseVisualStyleBackColor = true;
            this.btnDirectToLoginPage.Click += new System.EventHandler(this.btnDirectToLoginPage_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabWelcome);
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Controls.Add(this.tabLogIn);
            this.tabControl.Controls.Add(this.tabSignUp);
            this.tabControl.Location = new System.Drawing.Point(-4, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(652, 588);
            this.tabControl.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(254)))), ((int)(((byte)(194)))));
            this.tabHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabHome.BackgroundImage")));
            this.tabHome.Controls.Add(this.btnForward);
            this.tabHome.Controls.Add(this.btnBack);
            this.tabHome.Controls.Add(this.pBHome);
            this.tabHome.Controls.Add(this.lblTitle);
            this.tabHome.Location = new System.Drawing.Point(4, 29);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(644, 555);
            this.tabHome.TabIndex = 4;
            this.tabHome.Text = "Home";
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(338, 496);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(65, 56);
            this.btnForward.TabIndex = 4;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(202, 496);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 56);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pBHome
            // 
            this.pBHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBHome.BackgroundImage")));
            this.pBHome.Image = global::SmileyDesktopApp.Properties.Resources.brocoli;
            this.pBHome.InitialImage = null;
            this.pBHome.Location = new System.Drawing.Point(153, 78);
            this.pBHome.Name = "pBHome";
            this.pBHome.Size = new System.Drawing.Size(320, 394);
            this.pBHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBHome.TabIndex = 2;
            this.pBHome.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(50, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(83, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 583);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabSignUp.ResumeLayout(false);
            this.tabSignUp.PerformLayout();
            this.tabLogIn.ResumeLayout(false);
            this.tabLogIn.PerformLayout();
            this.tabWelcome.ResumeLayout(false);
            this.tabWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabSignUp;
        private System.Windows.Forms.TextBox tbSignupEmail;
        private System.Windows.Forms.TextBox tbSignupPassword;
        private System.Windows.Forms.TextBox tbSignupUserName;
        private System.Windows.Forms.Label lblSignupEmail;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblSignUpPassword;
        private System.Windows.Forms.Label lblSignupUserName;
        private System.Windows.Forms.TabPage tabLogIn;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbLoginPassword;
        private System.Windows.Forms.TextBox tbLoginUserName;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Label lblLoginUserName;
        private System.Windows.Forms.TabPage tabWelcome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDirectToLoginPage;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pBHome;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RadioButton rBAdmin;
        private System.Windows.Forms.RadioButton rBRegularUser;
    }
}
