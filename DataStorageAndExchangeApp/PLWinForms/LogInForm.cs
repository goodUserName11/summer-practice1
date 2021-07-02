using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLWinForms
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();

            signUpBtn.Enabled = false;
            logInBtn.Enabled = false;
        }

        private void signUpChB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chB = (CheckBox)sender;

            if (chB.Checked)
            {
                signUpGB.Enabled = true;
                signUpGB.Visible = true;

                logInGB.Visible = false;
                logInGB.Enabled = false;

                errorProvider1.Clear();

                signUpBtn.Enabled = false;
            }
            else
            {
                logInGB.Visible = true;
                logInGB.Enabled = true;

                signUpGB.Visible = false;
                signUpGB.Enabled = false;

                errorProvider1.Clear();

                logInBtn.Enabled = false;
            }

        }

        private void signUpLoginTB_Leave(object sender, EventArgs e)
        {
            Control tb = (TextBox)sender;

            LoginErrorCheck(tb);

            SignUpErrorsCheck();
        }

        private void signUpPasswordTB_Leave(object sender, EventArgs e)
        {
            Control tb = (TextBox)sender;

            PasswordErrorCheck(tb);

            RepeatPasswordErrorCheck(repeatPasswordTB);

            SignUpErrorsCheck();
        }

        private void repeatPasswordTB_Leave(object sender, EventArgs e)
        {
            Control tb = (TextBox)sender;

            RepeatPasswordErrorCheck(tb);

            SignUpErrorsCheck();
        }

        private void showPasswordChB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chB = (CheckBox)sender;
            showPasswordSignUpChB.Checked = chB.Checked;
            showPasswordLogInChB.Checked = chB.Checked;

            if (chB.Checked)
            {
                signUpPasswordTB.UseSystemPasswordChar = false;
                repeatPasswordTB.UseSystemPasswordChar = false;
                passwordTB.UseSystemPasswordChar = false;
            }
            else
            {
                signUpPasswordTB.UseSystemPasswordChar = true;
                repeatPasswordTB.UseSystemPasswordChar = true;
                passwordTB.UseSystemPasswordChar = true;
            }
        }

        private void loginTB_Leave(object sender, EventArgs e)
        {
            Control tb = (TextBox)sender;

            LoginErrorCheck(tb);

            LogInErrorsCheck();
        }

        private void passwordTB_Leave(object sender, EventArgs e)
        {
            Control tb = (TextBox)sender;

            PasswordErrorCheck(tb);

            LogInErrorsCheck();
        }


        private void logInBtn_Click(object sender, EventArgs e)
        {
            //
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            //
        }

        void LoginErrorCheck(Control login)
        {

            bool onlyLettersAndNumbers = false;

            for (int i = 0; i < login.Text.Length; i++)
            {
                if (!char.IsLetterOrDigit(login.Text[i]))
                    break;

                if (i == login.Text.Length - 1)
                    onlyLettersAndNumbers = true;
            }

            if (string.IsNullOrEmpty(login.Text))
            {
                errorProvider1.SetError(login, "Login field cannot be is empty");
            }
            else if (!onlyLettersAndNumbers)
            {
                errorProvider1.SetError(login, "Only numbers and letters");
            }
            else
            {
                errorProvider1.SetError(login, "");
            }
        }

        void PasswordErrorCheck(Control password)
        {
            if (string.IsNullOrEmpty(password.Text))
            {
                errorProvider1.SetError(password, "Password field cannot be is empty");
            }
            else
            {
                errorProvider1.SetError(password, "");
            }
        }

        void RepeatPasswordErrorCheck(Control repeatPassword)
        {
            if (!repeatPassword.Text.Equals(signUpPasswordTB.Text))
            {
                errorProvider1.SetError(repeatPassword, "Passwords are not same");
            }
            else
            {
                errorProvider1.SetError(repeatPassword, "");
            }
        }

        void SignUpErrorsCheck()
        {
            if (errorProvider1.GetError(signUpLoginTB) == "" &&
                errorProvider1.GetError(signUpPasswordTB) == "" &&
                errorProvider1.GetError(repeatPasswordTB) == "" &&
                !string.IsNullOrEmpty(signUpLoginTB.Text) &&
                !string.IsNullOrEmpty(signUpPasswordTB.Text) &&
                !string.IsNullOrEmpty(repeatPasswordTB.Text))
            {
                signUpBtn.Enabled = true;
            }
            else signUpBtn.Enabled = false;
        }

        void LogInErrorsCheck()
        {
            if (errorProvider1.GetError(loginTB) == "" &&
                errorProvider1.GetError(passwordTB) == "" &&
                !string.IsNullOrEmpty(loginTB.Text) &&
                !string.IsNullOrEmpty(passwordTB.Text))
            {
                logInBtn.Enabled = true;
            }
            else logInBtn.Enabled = false;
        }
    }
}
