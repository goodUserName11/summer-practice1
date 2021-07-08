
namespace PLWinForms
{
    partial class FileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileNameTB = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.fileDescriptionRTB = new System.Windows.Forms.RichTextBox();
            this.fileNameLbl = new System.Windows.Forms.Label();
            this.fileDescriptionLbl = new System.Windows.Forms.Label();
            this.changeFileBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // fileNameTB
            // 
            this.fileNameTB.Location = new System.Drawing.Point(12, 26);
            this.fileNameTB.Name = "fileNameTB";
            this.fileNameTB.Size = new System.Drawing.Size(289, 20);
            this.fileNameTB.TabIndex = 0;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(12, 168);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(226, 168);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // fileDescriptionRTB
            // 
            this.fileDescriptionRTB.Location = new System.Drawing.Point(12, 75);
            this.fileDescriptionRTB.Name = "fileDescriptionRTB";
            this.fileDescriptionRTB.Size = new System.Drawing.Size(289, 75);
            this.fileDescriptionRTB.TabIndex = 3;
            this.fileDescriptionRTB.Text = "";
            // 
            // fileNameLbl
            // 
            this.fileNameLbl.AutoSize = true;
            this.fileNameLbl.Location = new System.Drawing.Point(13, 10);
            this.fileNameLbl.Name = "fileNameLbl";
            this.fileNameLbl.Size = new System.Drawing.Size(52, 13);
            this.fileNameLbl.TabIndex = 4;
            this.fileNameLbl.Text = "File name";
            // 
            // fileDescriptionLbl
            // 
            this.fileDescriptionLbl.AutoSize = true;
            this.fileDescriptionLbl.Location = new System.Drawing.Point(13, 59);
            this.fileDescriptionLbl.Name = "fileDescriptionLbl";
            this.fileDescriptionLbl.Size = new System.Drawing.Size(60, 13);
            this.fileDescriptionLbl.TabIndex = 4;
            this.fileDescriptionLbl.Text = "Description";
            // 
            // changeFileBtn
            // 
            this.changeFileBtn.Location = new System.Drawing.Point(125, 168);
            this.changeFileBtn.Name = "changeFileBtn";
            this.changeFileBtn.Size = new System.Drawing.Size(77, 23);
            this.changeFileBtn.TabIndex = 2;
            this.changeFileBtn.Text = "Change File";
            this.changeFileBtn.UseVisualStyleBackColor = true;
            this.changeFileBtn.Click += new System.EventHandler(this.changeFileBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 204);
            this.Controls.Add(this.fileDescriptionLbl);
            this.Controls.Add(this.fileNameLbl);
            this.Controls.Add(this.fileDescriptionRTB);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.changeFileBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.fileNameTB);
            this.Name = "FileForm";
            this.Text = "FileForm";
            this.Load += new System.EventHandler(this.FileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileNameTB;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.RichTextBox fileDescriptionRTB;
        private System.Windows.Forms.Label fileNameLbl;
        private System.Windows.Forms.Label fileDescriptionLbl;
        private System.Windows.Forms.Button changeFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}