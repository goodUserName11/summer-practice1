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
    
    public partial class UsersForm : Form
    {
        IDataExchangerLogic _logic;
        List<User> _users;
        User _currentUser;

        public UsersForm(IDataExchangerLogic logic, User currentUser)
        {
            InitializeComponent();

            _logic = logic;
            _currentUser = currentUser;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            GetFilesInTable("");
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            GetFilesInTable(searchTB.Text);
        }

        private void usersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            int selIndex = 0;

            if (dataGridView.SelectedCells.Count > 0)
            {
                selIndex = dataGridView.SelectedCells[0].RowIndex;

                dataGridView.Rows[selIndex].Selected = true;
            }
        }

        private void usersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        }

        void GetFilesInTable(string filter)
        {
            usersDataGridView.Rows.Clear();

            _users = _logic.GetUsers(filter);

            foreach (User u in _users)
            {
                usersDataGridView.Rows.Add(u.Nickname);
            }
        }
    }
}
