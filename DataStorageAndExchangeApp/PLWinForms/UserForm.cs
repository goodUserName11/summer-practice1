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

        public UserForm(IDataExchangerLogic logic, User currentUser, User profileUser)
        {
            InitializeComponent();

            _logic = logic;
            _currentUser = currentUser;
            _profileUser = profileUser;
        }

    }
}
