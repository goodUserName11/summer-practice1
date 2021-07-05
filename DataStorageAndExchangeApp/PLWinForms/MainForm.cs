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
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        User _currentUser = new User(1, "Admin");

        public MainForm()
        {
            _logic = DependecyResolver.Instance.DataExchangerLogic;

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //LogIn();

            //FilesForm fs = new FilesForm(_logic, _currentUser);
            //fs.MdiParent = this;
            //fs.Show();

            UsersForm f = new UsersForm(_logic, _currentUser);
            f.MdiParent = this;
            f.Show();
        }

        private void changeUserTSBtn_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        void LogIn()
        {
            LogInForm loginForm = new LogInForm(_logic);

            if (loginForm.ShowDialog() != DialogResult.OK)
                Application.Exit();
            else
            {
                _currentUser = loginForm.CurrentUser;

                currentUserTSBtn.Text = _currentUser.Nickname;
            }
        }
    }
}
