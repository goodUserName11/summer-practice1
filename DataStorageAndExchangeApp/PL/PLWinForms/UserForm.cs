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
    public partial class UserForm : Form
    {
        IDataExchangerLogic _logic;
        User _currentUser;
        User _profileUser;
        private string _text = "User";

        public UserForm(IDataExchangerLogic logic, User currentUser, User profileUser)
        {
            InitializeComponent();

            _logic = logic;
            _currentUser = currentUser;
            _profileUser = profileUser;

            firstNameTB.Text = _profileUser.FirstName;
            lastNameTB.Text = _profileUser.LastName;
            nicknameTB.Text = _profileUser.Nickname;
            descriptionRTB.Text = _profileUser.UserDescription;
            registrationDateTB.Text = _profileUser.RegistrationDate.ToShortDateString();

            this.Text = _profileUser.Nickname + " " + _text;

            if (_profileUser.ID != _currentUser.ID)
            {
                changePasswordBtn.Visible = false;
                changePasswordBtn.Enabled = false;

                saveChangesBtn.Visible = false;
                saveChangesBtn.Enabled = false;

                discardChangesBtn.Visible = false;
                discardChangesBtn.Enabled = false;

                deleteBtn.Visible = false;
                deleteBtn.Enabled = false;

                firstNameTB.ReadOnly = true;
                lastNameTB.ReadOnly = true;
                nicknameTB.ReadOnly = true;
                descriptionRTB.ReadOnly = true;
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.Location = Point.Empty;
        }

        private void nicknameTB_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            NameErrorCheck(control);
        }

        private void firstNameTB_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            NameErrorCheck(control);
        }

        private void lastNameTB_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            NameErrorCheck(control);
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            NameErrorCheck(nicknameTB);
            NameErrorCheck(firstNameTB);
            NameErrorCheck(lastNameTB);

            if (!HasNamesErrors())
            {
                try
                {
                    _logic.ChangeUserInfo(_profileUser.ID, _currentUser.ID, firstNameTB.Text,
                        lastNameTB.Text, nicknameTB.Text, descriptionRTB.Text);

                    _profileUser.FirstName = firstNameTB.Text;
                    _profileUser.LastName = lastNameTB.Text;
                    _profileUser.Nickname = nicknameTB.Text;
                    _profileUser.UserDescription = descriptionRTB.Text;

                    if (_currentUser.ID == _profileUser.ID)
                    {
                        _currentUser.Nickname = _profileUser.Nickname;

                        this.Text = _profileUser.Nickname + " " + _text;

                        MainForm parent = (MainForm)(this.MdiParent);
                        parent.SetCurrentUserNickname(_profileUser.Nickname);
                    }
                }
                catch(Exception ex)
                {
                    if(ex is FormatException || ex is ArgumentException)
                        MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    else MessageBox.Show("Unexpected exception:  " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void discardChangesBtn_Click(object sender, EventArgs e)
        {
            firstNameTB.Text = _profileUser.FirstName;
            lastNameTB.Text = _profileUser.LastName;
            nicknameTB.Text = _profileUser.Nickname;
            descriptionRTB.Text = _profileUser.UserDescription;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _logic.DeleteUser(_profileUser.ID, _currentUser.ID);

                if (_profileUser.ID == _currentUser.ID)
                {
                    MainForm mf = (MainForm)this.MdiParent;
                    mf.ExitFromCurrentUser();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected exception:  " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePasswordForm cf = new ChangePasswordForm();

            if (cf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _logic.ChangeUserPassword(_profileUser.ID, _currentUser.ID, cf.NewPassword);
                }
                catch(FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected exception:  " + ex.Message, "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void NameErrorCheck(Control name)
        {
            name.Text = name.Text.Trim(' ');


            bool onlyLettersAndNumbers = false;

            for (int i = 0; i < name.Text.Length; i++)
            {
                if (!char.IsLetterOrDigit(name.Text[i]) && name.Text[i] != ' ')
                    break;

                if (i == name.Text.Length - 1)
                    onlyLettersAndNumbers = true;
            }

            if (string.IsNullOrEmpty(name.Text))
            {
                errorProvider1.SetError(name, "Field cannot be is empty");
            }
            else if (!onlyLettersAndNumbers)
            {
                errorProvider1.SetError(name, "Only numbers and letters");
            }
            else
            {
                errorProvider1.SetError(name, "");
            }
        }

        bool HasNamesErrors()
        {
            if (errorProvider1.GetError(nicknameTB) == "" &&
                errorProvider1.GetError(firstNameTB) == "" &&
                errorProvider1.GetError(lastNameTB) == "")
            {
                return false;
            }
            else return true;
        }
    }
}