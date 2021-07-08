
namespace PLWinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.viewsTSDDBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.yourProfileTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.filesTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.currentUserTSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.changeUserTSBtn = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewsTSDDBtn,
            this.toolStripSeparator1,
            this.toolStripSeparator3,
            this.currentUserTSBtn,
            this.toolStripSeparator4,
            this.changeUserTSBtn,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(757, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // viewsTSDDBtn
            // 
            this.viewsTSDDBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.viewsTSDDBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yourProfileTSMenuItem,
            this.toolStripSeparator2,
            this.filesTSMenuItem,
            this.usersTSMenuItem});
            this.viewsTSDDBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewsTSDDBtn.Name = "viewsTSDDBtn";
            this.viewsTSDDBtn.Size = new System.Drawing.Size(50, 22);
            this.viewsTSDDBtn.Text = "Views";
            // 
            // yourProfileTSMenuItem
            // 
            this.yourProfileTSMenuItem.Name = "yourProfileTSMenuItem";
            this.yourProfileTSMenuItem.Size = new System.Drawing.Size(135, 22);
            this.yourProfileTSMenuItem.Text = "Your Profile";
            this.yourProfileTSMenuItem.Click += new System.EventHandler(this.currentUserTSBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(132, 6);
            // 
            // filesTSMenuItem
            // 
            this.filesTSMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.filesTSMenuItem.Name = "filesTSMenuItem";
            this.filesTSMenuItem.Size = new System.Drawing.Size(135, 22);
            this.filesTSMenuItem.Text = "Files";
            this.filesTSMenuItem.Click += new System.EventHandler(this.filesTSMenuItem_Click);
            // 
            // usersTSMenuItem
            // 
            this.usersTSMenuItem.Name = "usersTSMenuItem";
            this.usersTSMenuItem.Size = new System.Drawing.Size(135, 22);
            this.usersTSMenuItem.Text = "Users";
            this.usersTSMenuItem.Click += new System.EventHandler(this.usersTSMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // currentUserTSBtn
            // 
            this.currentUserTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.currentUserTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.currentUserTSBtn.Name = "currentUserTSBtn";
            this.currentUserTSBtn.Size = new System.Drawing.Size(53, 22);
            this.currentUserTSBtn.Text = "CurUser";
            this.currentUserTSBtn.Click += new System.EventHandler(this.currentUserTSBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // changeUserTSBtn
            // 
            this.changeUserTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.changeUserTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.changeUserTSBtn.Name = "changeUserTSBtn";
            this.changeUserTSBtn.Size = new System.Drawing.Size(78, 22);
            this.changeUserTSBtn.Text = "Change User";
            this.changeUserTSBtn.Click += new System.EventHandler(this.changeUserTSBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 387);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Data Exchanger";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton viewsTSDDBtn;
        private System.Windows.Forms.ToolStripMenuItem filesTSMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton changeUserTSBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem usersTSMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem yourProfileTSMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton currentUserTSBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}