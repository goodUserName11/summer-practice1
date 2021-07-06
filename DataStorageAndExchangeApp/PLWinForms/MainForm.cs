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
using Common.MyFile;
using Dependencies;
using BLLInterfaces;

namespace PLWinForms
{
    public partial class MainForm : Form
    {
        IDataExchangerLogic _logic;
        User _currentUser/* = new User(1, "Admin")*/;

        public MainForm()
        {
            _logic = DependecyResolver.Instance.DataExchangerLogic;

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LogIn();
        }

        private void changeUserTSBtn_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void currentUserTSBtn_Click(object sender, EventArgs e)
        {
            closeAllMdiChildren();

            User profileUser = _logic.GetUserInfo(_currentUser.ID);

            UserForm uf = new UserForm(_logic, _currentUser, profileUser);
            uf.MdiParent = this;

            uf.Show();
        }

        private void filesTSMenuItem_Click(object sender, EventArgs e)
        {
            closeAllMdiChildren();

            FilesForm ff = new FilesForm(_logic, _currentUser);
            ff.MdiParent = this;

            ff.Show();
        }

        private void usersTSMenuItem_Click(object sender, EventArgs e)
        {
            closeAllMdiChildren();

            UsersForm uf = new UsersForm(_logic, _currentUser);
            uf.MdiParent = this;

            uf.Show();
        }

        void LogIn()
        {
            closeAllMdiChildren();

            LogInForm loginForm = new LogInForm(_logic);

            if (loginForm.ShowDialog() != DialogResult.OK)
                Application.Exit();
            else
            {
                _currentUser = loginForm.CurrentUser;

                currentUserTSBtn.Text = _currentUser.Nickname;

                FilesForm fs = new FilesForm(_logic, _currentUser);
                fs.MdiParent = this;
                fs.Show();
            }
        }

        void closeAllMdiChildren()
        {
            if (this.MdiChildren.Length > 0)
            {
                foreach (var form in this.MdiChildren)
                {
                    form.Close();
                }
            }
        }

        public void SetCurrentUserNickname(string nickname)
        {
            _currentUser.Nickname = nickname;
            currentUserTSBtn.Text = nickname;
        }

        public void ExitFromCurrentUser()
        {
            LogIn();
        }
    }
}
