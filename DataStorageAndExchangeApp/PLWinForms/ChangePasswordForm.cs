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
    public partial class ChangePasswordForm : Form
    {
        public string NewPassword { get; private set; }

        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            PasswordErrorCheck(newPasswordTB);

            if(errorProvider1.GetError(newPasswordTB) == "")
            {
                NewPassword = newPasswordTB.Text;

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
        }

        private void newPasswordTB_Leave(object sender, EventArgs e)
        {
            Control password = (Control)sender;

            PasswordErrorCheck(password);
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
    }
}
