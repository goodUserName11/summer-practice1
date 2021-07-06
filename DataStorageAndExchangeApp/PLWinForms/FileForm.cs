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
    public partial class FileForm : Form
    {
        FileFormPurpose _purpose;

        public string FileName { get; private set; }
        public string FileDescription { get; private set; }

        /// <summary>
        /// For adding new file
        /// </summary>
        /// <param name="fileName"></param>
        public FileForm(string fileName)
        {
            InitializeComponent();

            FileName = fileName;

            fileNameTB.Text = FileName;

            _purpose = FileFormPurpose.AddFile;

            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FileName = fileName;
        }

        /// <summary>
        /// For editing existing file
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="description"></param>
        public FileForm(string fileName, string description) : this(fileName)
        {
            FileDescription = description;

            fileDescriptionRTB.Text = description;

            _purpose = FileFormPurpose.EditFile;
        }

        private void FileForm_Load(object sender, EventArgs e)
        {
            if(_purpose == FileFormPurpose.AddFile)
            {
                this.Text = "Add file";

                okBtn.Text = "Add";

                fileNameTB.Text = FileName;
                fileNameTB.ReadOnly = true;
            }
            else 
            {
                this.Text = "Edit file";

                okBtn.Text = "Edit";

                fileNameTB.Text = FileName;
                fileDescriptionRTB.Text = FileDescription;

                changeFileBtn.Visible = false;
                changeFileBtn.Enabled = false;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if(_purpose == FileFormPurpose.EditFile && !IsCorrectFileName(fileNameTB))
            {
                MessageBox.Show("File name cannot be empty or contain *?:<>/\\|\"", "Warning!");
            }
            else
            {

                if (string.IsNullOrEmpty(fileDescriptionRTB.Text))
                    fileDescriptionRTB.Text = "Empty";

                FileName = fileNameTB.Text;
                FileDescription = fileDescriptionRTB.Text;

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
        }

        private void changeFileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNameTB.Text = openFileDialog1.FileName;

                FileName = openFileDialog1.FileName;
            }
        }

        bool IsCorrectFileName(Control fileName)
        {
            bool correctFileName = true;

            foreach (char ch in fileNameTB.Text)
            {
                if (ch == '/' || ch == '\\' || ch == '*' ||
                    ch == '?' || ch == ':' || ch == '"' ||
                    ch == '<' || ch == '>' || ch == '|')
                {
                    correctFileName = false;

                    break;
                }

            }

            if (!string.IsNullOrEmpty(fileNameTB.Text) && correctFileName)
                return true;

            else return false;
        }
    }
}
