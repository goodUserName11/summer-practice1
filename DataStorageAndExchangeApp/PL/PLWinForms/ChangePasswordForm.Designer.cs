
namespace PLWinForms
{
    partial class ChangePasswordForm
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
            this.newPasswordTB = new System.Windows.Forms.TextBox();
            this.newPasswordLbl = new System.Windows.Forms.Label();
            this.changeBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // newPasswordTB
            // 
            this.newPasswordTB.Location = new System.Drawing.Point(15, 73);
            this.newPasswordTB.Name = "newPasswordTB";
            this.newPasswordTB.Size = new System.Drawing.Size(214, 20);
            this.newPasswordTB.TabIndex = 0;
            this.newPasswordTB.Leave += new System.EventHandler(this.newPasswordTB_Leave);
            // 
            // newPasswordLbl
            // 
            this.newPasswordLbl.AutoSize = true;
            this.newPasswordLbl.Location = new System.Drawing.Point(15, 57);
            this.newPasswordLbl.Name = "newPasswordLbl";
            this.newPasswordLbl.Size = new System.Drawing.Size(77, 13);
            this.newPasswordLbl.TabIndex = 1;
            this.newPasswordLbl.Text = "New password";
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(15, 131);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(75, 23);
            this.changeBtn.TabIndex = 2;
            this.changeBtn.Text = "Change";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(154, 131);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 182);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.newPasswordLbl);
            this.Controls.Add(this.newPasswordTB);
            this.Name = "ChangePasswordForm";
            this.Text = "changePasswordForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newPasswordTB;
        private System.Windows.Forms.Label newPasswordLbl;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}