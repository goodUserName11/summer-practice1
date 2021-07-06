
namespace PLWinForms
{
    partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            this.nicknameTB = new System.Windows.Forms.TextBox();
            this.descriptionRTB = new System.Windows.Forms.RichTextBox();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.registrationDateTB = new System.Windows.Forms.TextBox();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.changePasswordBtn = new System.Windows.Forms.Button();
            this.discardChangesBtn = new System.Windows.Forms.Button();
            this.nicknameLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.registrationDateLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nicknameTB
            // 
            this.nicknameTB.Location = new System.Drawing.Point(12, 19);
            this.nicknameTB.Name = "nicknameTB";
            this.nicknameTB.Size = new System.Drawing.Size(145, 20);
            this.nicknameTB.TabIndex = 0;
            this.nicknameTB.Leave += new System.EventHandler(this.nicknameTB_Leave);
            // 
            // descriptionRTB
            // 
            this.descriptionRTB.Location = new System.Drawing.Point(12, 112);
            this.descriptionRTB.Name = "descriptionRTB";
            this.descriptionRTB.Size = new System.Drawing.Size(713, 96);
            this.descriptionRTB.TabIndex = 1;
            this.descriptionRTB.Text = "";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(12, 70);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(145, 20);
            this.firstNameTB.TabIndex = 0;
            this.firstNameTB.Leave += new System.EventHandler(this.firstNameTB_Leave);
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(207, 70);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(145, 20);
            this.lastNameTB.TabIndex = 0;
            this.lastNameTB.Leave += new System.EventHandler(this.lastNameTB_Leave);
            // 
            // registrationDateTB
            // 
            this.registrationDateTB.Location = new System.Drawing.Point(207, 19);
            this.registrationDateTB.Name = "registrationDateTB";
            this.registrationDateTB.ReadOnly = true;
            this.registrationDateTB.Size = new System.Drawing.Size(145, 20);
            this.registrationDateTB.TabIndex = 0;
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Location = new System.Drawing.Point(162, 261);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(102, 23);
            this.saveChangesBtn.TabIndex = 2;
            this.saveChangesBtn.Text = "Save changes";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.Location = new System.Drawing.Point(319, 261);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(121, 23);
            this.changePasswordBtn.TabIndex = 3;
            this.changePasswordBtn.Text = "Change password";
            this.changePasswordBtn.UseVisualStyleBackColor = true;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // discardChangesBtn
            // 
            this.discardChangesBtn.Location = new System.Drawing.Point(485, 261);
            this.discardChangesBtn.Name = "discardChangesBtn";
            this.discardChangesBtn.Size = new System.Drawing.Size(118, 23);
            this.discardChangesBtn.TabIndex = 4;
            this.discardChangesBtn.Text = "Discard changes";
            this.discardChangesBtn.UseVisualStyleBackColor = true;
            this.discardChangesBtn.Click += new System.EventHandler(this.discardChangesBtn_Click);
            // 
            // nicknameLbl
            // 
            this.nicknameLbl.AutoSize = true;
            this.nicknameLbl.Location = new System.Drawing.Point(9, 3);
            this.nicknameLbl.Name = "nicknameLbl";
            this.nicknameLbl.Size = new System.Drawing.Size(55, 13);
            this.nicknameLbl.TabIndex = 5;
            this.nicknameLbl.Text = "Nickname";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(9, 54);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(55, 13);
            this.firstNameLbl.TabIndex = 5;
            this.firstNameLbl.Text = "First name";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(204, 54);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(56, 13);
            this.lastNameLbl.TabIndex = 5;
            this.lastNameLbl.Text = "Last name";
            // 
            // registrationDateLbl
            // 
            this.registrationDateLbl.AutoSize = true;
            this.registrationDateLbl.Location = new System.Drawing.Point(204, 3);
            this.registrationDateLbl.Name = "registrationDateLbl";
            this.registrationDateLbl.Size = new System.Drawing.Size(87, 13);
            this.registrationDateLbl.TabIndex = 5;
            this.registrationDateLbl.Text = "Registration date";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Location = new System.Drawing.Point(13, 93);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(60, 13);
            this.descriptionLbl.TabIndex = 6;
            this.descriptionLbl.Text = "Description";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Firebrick;
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteBtn.Location = new System.Drawing.Point(670, 8);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(61, 38);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete User";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 319);
            this.ControlBox = false;
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.registrationDateLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.nicknameLbl);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.discardChangesBtn);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.descriptionRTB);
            this.Controls.Add(this.registrationDateTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.nicknameTB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nicknameTB;
        private System.Windows.Forms.RichTextBox descriptionRTB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox registrationDateTB;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.Button changePasswordBtn;
        private System.Windows.Forms.Button discardChangesBtn;
        private System.Windows.Forms.Label nicknameLbl;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label registrationDateLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}