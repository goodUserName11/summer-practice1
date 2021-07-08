
namespace PLWinForms
{
    partial class UsersForm
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
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBtn = new System.Windows.Forms.Button();
            this.filterLbl = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.goToUserBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nickname});
            this.usersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.usersDataGridView.MultiSelect = false;
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.Size = new System.Drawing.Size(713, 169);
            this.usersDataGridView.TabIndex = 0;
            this.usersDataGridView.SelectionChanged += new System.EventHandler(this.usersDataGridView_SelectionChanged);
            // 
            // nickname
            // 
            this.nickname.HeaderText = "nickname";
            this.nickname.Name = "nickname";
            this.nickname.ReadOnly = true;
            this.nickname.Width = 200;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(275, 209);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(73, 21);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // filterLbl
            // 
            this.filterLbl.AutoSize = true;
            this.filterLbl.Location = new System.Drawing.Point(12, 194);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(29, 13);
            this.filterLbl.TabIndex = 6;
            this.filterLbl.Text = "Filter";
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(12, 210);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(260, 20);
            this.searchTB.TabIndex = 5;
            // 
            // goToUserBtn
            // 
            this.goToUserBtn.Location = new System.Drawing.Point(574, 207);
            this.goToUserBtn.Name = "goToUserBtn";
            this.goToUserBtn.Size = new System.Drawing.Size(112, 45);
            this.goToUserBtn.TabIndex = 8;
            this.goToUserBtn.Text = "To user profile";
            this.goToUserBtn.UseVisualStyleBackColor = true;
            this.goToUserBtn.Click += new System.EventHandler(this.goToUserBtn_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 311);
            this.ControlBox = false;
            this.Controls.Add(this.goToUserBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.filterLbl);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.usersDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsersForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickname;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label filterLbl;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button goToUserBtn;
    }
}