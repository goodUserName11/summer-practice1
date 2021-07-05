﻿using System;
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
                _logic.CreateFile(openFileDialog1.FileName, "Empty", _currentUser.ID);

                GetFilesInTable("");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {

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
            }
            else
            {
                downloadBtn.Enabled = false;
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