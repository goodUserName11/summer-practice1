
namespace PLWinForms
{
    partial class LogInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.logInGB = new System.Windows.Forms.GroupBox();
            this.showPasswordLogInChB = new System.Windows.Forms.CheckBox();
            this.logInBtn = new System.Windows.Forms.Button();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.loginLbl = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.signUpGB = new System.Windows.Forms.GroupBox();
            this.showPasswordSignUpChB = new System.Windows.Forms.CheckBox();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.repeatPasswordLbl = new System.Windows.Forms.Label();
            this.signUpPasswordLbl = new System.Windows.Forms.Label();
            this.repeatPasswordTB = new System.Windows.Forms.TextBox();
            this.signUpLoginLbl = new System.Windows.Forms.Label();
            this.signUpPasswordTB = new System.Windows.Forms.TextBox();
            this.signUpLoginTB = new System.Windows.Forms.TextBox();
            this.signUpChB = new System.Windows.Forms.CheckBox();
            this.nicknameLbl = new System.Windows.Forms.Label();
            this.nicknameTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.logInGB.SuspendLayout();
            this.signUpGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // logInGB
            // 
            this.logInGB.Controls.Add(this.showPasswordLogInChB);
            this.logInGB.Controls.Add(this.logInBtn);
            this.logInGB.Controls.Add(this.passwordLbl);
            this.logInGB.Controls.Add(this.loginLbl);
            this.logInGB.Controls.Add(this.passwordTB);
            this.logInGB.Controls.Add(this.loginTB);
            this.logInGB.Location = new System.Drawing.Point(12, 12);
            this.logInGB.Name = "logInGB";
            this.logInGB.Size = new System.Drawing.Size(418, 247);
            this.logInGB.TabIndex = 0;
            this.logInGB.TabStop = false;
            this.logInGB.Text = "Log In";
            // 
            // showPasswordLogInChB
            // 
            this.showPasswordLogInChB.AutoSize = true;
            this.showPasswordLogInChB.Location = new System.Drawing.Point(45, 128);
            this.showPasswordLogInChB.Name = "showPasswordLogInChB";
            this.showPasswordLogInChB.Size = new System.Drawing.Size(108, 17);
            this.showPasswordLogInChB.TabIndex = 4;
            this.showPasswordLogInChB.Text = "Show Password?";
            this.showPasswordLogInChB.UseVisualStyleBackColor = true;
            this.showPasswordLogInChB.CheckedChanged += new System.EventHandler(this.showPasswordChB_CheckedChanged);
            // 
            // logInBtn
            // 
            this.logInBtn.Location = new System.Drawing.Point(161, 178);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(100, 45);
            this.logInBtn.TabIndex = 3;
            this.logInBtn.Text = "Log in";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(45, 86);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(53, 13);
            this.passwordLbl.TabIndex = 2;
            this.passwordLbl.Text = "Password";
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Location = new System.Drawing.Point(45, 16);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(33, 13);
            this.loginLbl.TabIndex = 2;
            this.loginLbl.Text = "Login";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(45, 102);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(329, 20);
            this.passwordTB.TabIndex = 1;
            this.passwordTB.UseSystemPasswordChar = true;
            this.passwordTB.Leave += new System.EventHandler(this.passwordTB_Leave);
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(45, 35);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(330, 20);
            this.loginTB.TabIndex = 0;
            this.loginTB.Leave += new System.EventHandler(this.loginTB_Leave);
            // 
            // signUpGB
            // 
            this.signUpGB.Controls.Add(this.nicknameLbl);
            this.signUpGB.Controls.Add(this.nicknameTB);
            this.signUpGB.Controls.Add(this.showPasswordSignUpChB);
            this.signUpGB.Controls.Add(this.signUpBtn);
            this.signUpGB.Controls.Add(this.repeatPasswordLbl);
            this.signUpGB.Controls.Add(this.signUpPasswordLbl);
            this.signUpGB.Controls.Add(this.repeatPasswordTB);
            this.signUpGB.Controls.Add(this.signUpLoginLbl);
            this.signUpGB.Controls.Add(this.signUpPasswordTB);
            this.signUpGB.Controls.Add(this.signUpLoginTB);
            this.signUpGB.Enabled = false;
            this.signUpGB.Location = new System.Drawing.Point(12, 12);
            this.signUpGB.Name = "signUpGB";
            this.signUpGB.Size = new System.Drawing.Size(418, 247);
            this.signUpGB.TabIndex = 4;
            this.signUpGB.TabStop = false;
            this.signUpGB.Text = "Sign Up";
            this.signUpGB.Visible = false;
            // 
            // showPasswordSignUpChB
            // 
            this.showPasswordSignUpChB.AutoSize = true;
            this.showPasswordSignUpChB.Location = new System.Drawing.Point(48, 191);
            this.showPasswordSignUpChB.Name = "showPasswordSignUpChB";
            this.showPasswordSignUpChB.Size = new System.Drawing.Size(108, 17);
            this.showPasswordSignUpChB.TabIndex = 4;
            this.showPasswordSignUpChB.Text = "Show Password?";
            this.showPasswordSignUpChB.UseVisualStyleBackColor = true;
            this.showPasswordSignUpChB.CheckedChanged += new System.EventHandler(this.showPasswordChB_CheckedChanged);
            // 
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(177, 206);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(84, 35);
            this.signUpBtn.TabIndex = 3;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // repeatPasswordLbl
            // 
            this.repeatPasswordLbl.AutoSize = true;
            this.repeatPasswordLbl.Location = new System.Drawing.Point(48, 151);
            this.repeatPasswordLbl.Name = "repeatPasswordLbl";
            this.repeatPasswordLbl.Size = new System.Drawing.Size(91, 13);
            this.repeatPasswordLbl.TabIndex = 2;
            this.repeatPasswordLbl.Text = "Repeat Password";
            // 
            // signUpPasswordLbl
            // 
            this.signUpPasswordLbl.AutoSize = true;
            this.signUpPasswordLbl.Location = new System.Drawing.Point(48, 109);
            this.signUpPasswordLbl.Name = "signUpPasswordLbl";
            this.signUpPasswordLbl.Size = new System.Drawing.Size(53, 13);
            this.signUpPasswordLbl.TabIndex = 2;
            this.signUpPasswordLbl.Text = "Password";
            // 
            // repeatPasswordTB
            // 
            this.repeatPasswordTB.Location = new System.Drawing.Point(48, 167);
            this.repeatPasswordTB.Name = "repeatPasswordTB";
            this.repeatPasswordTB.Size = new System.Drawing.Size(329, 20);
            this.repeatPasswordTB.TabIndex = 1;
            this.repeatPasswordTB.UseSystemPasswordChar = true;
            this.repeatPasswordTB.Leave += new System.EventHandler(this.repeatPasswordTB_Leave);
            // 
            // signUpLoginLbl
            // 
            this.signUpLoginLbl.AutoSize = true;
            this.signUpLoginLbl.Location = new System.Drawing.Point(45, 19);
            this.signUpLoginLbl.Name = "signUpLoginLbl";
            this.signUpLoginLbl.Size = new System.Drawing.Size(33, 13);
            this.signUpLoginLbl.TabIndex = 2;
            this.signUpLoginLbl.Text = "Login";
            // 
            // signUpPasswordTB
            // 
            this.signUpPasswordTB.Location = new System.Drawing.Point(48, 125);
            this.signUpPasswordTB.Name = "signUpPasswordTB";
            this.signUpPasswordTB.Size = new System.Drawing.Size(329, 20);
            this.signUpPasswordTB.TabIndex = 1;
            this.signUpPasswordTB.UseSystemPasswordChar = true;
            this.signUpPasswordTB.Leave += new System.EventHandler(this.signUpPasswordTB_Leave);
            // 
            // signUpLoginTB
            // 
            this.signUpLoginTB.Location = new System.Drawing.Point(48, 35);
            this.signUpLoginTB.Name = "signUpLoginTB";
            this.signUpLoginTB.Size = new System.Drawing.Size(330, 20);
            this.signUpLoginTB.TabIndex = 0;
            this.signUpLoginTB.Leave += new System.EventHandler(this.signUpLoginTB_Leave);
            // 
            // signUpChB
            // 
            this.signUpChB.AutoSize = true;
            this.signUpChB.Location = new System.Drawing.Point(12, 265);
            this.signUpChB.Name = "signUpChB";
            this.signUpChB.Size = new System.Drawing.Size(68, 17);
            this.signUpChB.TabIndex = 1;
            this.signUpChB.Text = "Sign up?";
            this.signUpChB.UseVisualStyleBackColor = true;
            this.signUpChB.CheckedChanged += new System.EventHandler(this.signUpChB_CheckedChanged);
            // 
            // nicknameLbl
            // 
            this.nicknameLbl.AutoSize = true;
            this.nicknameLbl.Location = new System.Drawing.Point(45, 61);
            this.nicknameLbl.Name = "nicknameLbl";
            this.nicknameLbl.Size = new System.Drawing.Size(55, 13);
            this.nicknameLbl.TabIndex = 6;
            this.nicknameLbl.Text = "Nickname";
            // 
            // nicknameTB
            // 
            this.nicknameTB.Location = new System.Drawing.Point(48, 77);
            this.nicknameTB.Name = "nicknameTB";
            this.nicknameTB.Size = new System.Drawing.Size(330, 20);
            this.nicknameTB.TabIndex = 5;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 294);
            this.Controls.Add(this.signUpGB);
            this.Controls.Add(this.signUpChB);
            this.Controls.Add(this.logInGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LogInForm";
            this.ShowIcon = false;
            this.Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.logInGB.ResumeLayout(false);
            this.logInGB.PerformLayout();
            this.signUpGB.ResumeLayout(false);
            this.signUpGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox signUpChB;
        private System.Windows.Forms.GroupBox logInGB;
        private System.Windows.Forms.GroupBox signUpGB;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Label repeatPasswordLbl;
        private System.Windows.Forms.Label signUpPasswordLbl;
        private System.Windows.Forms.TextBox repeatPasswordTB;
        private System.Windows.Forms.Label signUpLoginLbl;
        private System.Windows.Forms.TextBox signUpPasswordTB;
        private System.Windows.Forms.TextBox signUpLoginTB;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.CheckBox showPasswordSignUpChB;
        private System.Windows.Forms.CheckBox showPasswordLogInChB;
        private System.Windows.Forms.Label nicknameLbl;
        private System.Windows.Forms.TextBox nicknameTB;
    }
}