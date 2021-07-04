using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.User;
using BLLInterfaces;

namespace PLWinForms
{
    public partial class LogInForm : Form
    {
        IDataExchangerLogic _logic;
        public User CurrentUser { get; private set; }


        public LogInForm(IDataExchangerLogic logic)
        {
            InitializeComponent();

            _logic = logic;

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
            }
            else
            {
                logInGB.Visible = true;
                logInGB.Enabled = true;

                signUpGB.Visible = false;
                signUpGB.Enabled = false;

                errorProvider1.Clear();
            }

        }

        private void signUpLoginTB_Leave(object sender, EventArgs e)
        {
            Control tb = (TextBox)sender;

            LoginErrorCheck(tb);
        }

        private void nicknameTB_Leave(object sender, EventArgs e)
        {
            Control tb = (TextBox)sender;

            LoginErrorCheck(tb);
        }

        private void signUpPasswordTB_Leave(object sender, EventArgs e)
        {
            Control tb = (TextBox)sender;

            PasswordErrorCheck(tb);

            RepeatPasswordErrorCheck(repeatPasswordTB);
        }

        private void repeatPasswordTB_Leave(object sender, EventArgs e)
        {
            Control tb = (TextBox)sender;

            RepeatPasswordErrorCheck(tb);
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
        }

        private void passwordTB_Leave(object sender, EventArgs e)
        {
            Control tb = (TextBox)sender;

            PasswordErrorCheck(tb);
        }


        private void logInBtn_Click(object sender, EventArgs e)
        {
            LoginErrorCheck(loginTB);
            PasswordErrorCheck(passwordTB);

            if (HasLogInErrors())
                MessageBox.Show("Error in login and/or password!", "Warning!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    CurrentUser = _logic.LogIn(loginTB.Text, passwordTB.Text);

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch(ArgumentException error)
                {
                    MessageBox.Show(error.Message, "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch(InvalidOperationException error)
                {
                    MessageBox.Show(error.Message, "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            LoginErrorCheck(signUpLoginTB);
            LoginErrorCheck(nicknameTB);
            PasswordErrorCheck(signUpPasswordTB);
            RepeatPasswordErrorCheck(repeatPasswordTB);

            if (HasSignUpErrors())
                MessageBox.Show("Error in login and/or password and/or nickname!", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    CurrentUser = _logic.SignUp(signUpLoginTB.Text, nicknameTB.Text, signUpPasswordTB.Text);

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch(ArgumentException error)
                {
                    MessageBox.Show(error.Message, "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch(InvalidOperationException error)
                {
                    MessageBox.Show(error.Message, "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

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
                errorProvider1.SetError(login, "Field cannot be is empty");
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

        bool HasSignUpErrors()
        {
            if (errorProvider1.GetError(signUpLoginTB) == "" &&
                errorProvider1.GetError(signUpPasswordTB) == "" &&
                errorProvider1.GetError(repeatPasswordTB) == "" && 
                errorProvider1.GetError(nicknameTB) == "" /*&&
                !string.IsNullOrEmpty(signUpLoginTB.Text) &&
                !string.IsNullOrEmpty(signUpPasswordTB.Text) &&
                !string.IsNullOrEmpty(repeatPasswordTB.Text) &&
                !string.IsNullOrEmpty(nicknameTB.Text)*/)
            {
                return false;
            }
            else return true;
        }

        bool HasLogInErrors()
        {
            if (errorProvider1.GetError(loginTB) == "" &&
                errorProvider1.GetError(passwordTB) == ""/* &&
                !string.IsNullOrEmpty(loginTB.Text) &&
                !string.IsNullOrEmpty(passwordTB.Text)*/)
            {
                return false;
            }
            else return true;
        }
    }
}
