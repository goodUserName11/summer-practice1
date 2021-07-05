using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.MyFile;
using Common.User;
using BLLInterfaces;

namespace PLWinForms
{
    public partial class FilesForm : Form
    {
        IDataExchangerLogic _logic;
        User _currentUser;
        List<MyFile> _files;

        public FilesForm(IDataExchangerLogic logic, User currentUser)
        {
            InitializeComponent();

            _logic = logic;
            _currentUser = currentUser;

            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            downloadBtn.Enabled = false;
            editBtn.Enabled = false;
            deleteBtn.Enabled = false;

            saveFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.Filter = "All files (*.*)|*.*";
        }

        private void FilesForm_Load(object sender, EventArgs e)
        {
            GetFilesInTable("");
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            GetFilesInTable(searchTB.Text);
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            if(filesDataGridView.SelectedRows.Count > 0)
            {
                int selIndex = filesDataGridView.SelectedRows[0].Index;

                saveFileDialog1.FileName = _files[selIndex].FileName;

                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _logic.WriteFile(_files[selIndex].Id, saveFileDialog1.FileName);
                }
            }
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileForm f = new FileForm(openFileDialog1.FileName);

                if (f.ShowDialog() == DialogResult.OK)
                {
                    _logic.CreateFile(f.FileName, f.FileDescription, _currentUser.ID);

                    GetFilesInTable("");
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (filesDataGridView.SelectedRows.Count > 0)
            {
                int selIndex = filesDataGridView.SelectedRows[0].Index;

                _logic.DeleteFile(_files[selIndex].Id, _currentUser.ID);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string fileName = (string)filesDataGridView.SelectedRows[0].Cells[0].Value;
            string desc = (string)filesDataGridView.SelectedRows[0].Cells[1].Value;

            if (filesDataGridView.SelectedRows.Count > 0)
            {
                int selIndex = filesDataGridView.SelectedRows[0].Index;

                FileForm f = new FileForm(fileName, desc);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    try 
                    { 
                        _logic.ChangeFile(_files[selIndex].Id, _currentUser.ID, f.FileName, f.FileDescription);
                    }
                    catch(ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message, "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    GetFilesInTable("");
                }
            }
        }

        private void filesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            int selIndex = 0;

            if (dataGridView.SelectedCells.Count > 0)
            {
                selIndex = dataGridView.SelectedCells[0].RowIndex;

                dataGridView.Rows[selIndex].Selected = true;
            }


            if (dataGridView.SelectedRows.Count > 0)
            {
                downloadBtn.Enabled = true;
                addBtn.Enabled = true;
                deleteBtn.Enabled = true;
                editBtn.Enabled = true;
            }
            else
            {
                downloadBtn.Enabled = false;
                addBtn.Enabled = false;
                deleteBtn.Enabled = false;
                editBtn.Enabled = false;
            }
        }

        void GetFilesInTable(string filter)
        {
            filesDataGridView.Rows.Clear();

            _files = _logic.GetFiles(filter);

            foreach (MyFile file in _files)
            {
                filesDataGridView.Rows.Add(file.FileName, file.Description, file.Creator, file.AddingDate);
            }
        }
    }
}
