
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.changeUserTSBtn = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.filesTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.yourProfileTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.currentUserTSLbl = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewsTSDDBtn,
            this.toolStripSeparator1,
            this.toolStripSeparator3,
            this.currentUserTSLbl,
            this.toolStripSeparator4,
            this.changeUserTSBtn});
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
            this.viewsTSDDBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewsTSDDBtn.Image")));
            this.viewsTSDDBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewsTSDDBtn.Name = "viewsTSDDBtn";
            this.viewsTSDDBtn.Size = new System.Drawing.Size(50, 22);
            this.viewsTSDDBtn.Text = "Views";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // changeUserTSBtn
            // 
            this.changeUserTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.changeUserTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("changeUserTSBtn.Image")));
            this.changeUserTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.changeUserTSBtn.Name = "changeUserTSBtn";
            this.changeUserTSBtn.Size = new System.Drawing.Size(78, 22);
            this.changeUserTSBtn.Text = "Change User";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // filesTSMenuItem
            // 
            this.filesTSMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.filesTSMenuItem.Name = "filesTSMenuItem";
            this.filesTSMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filesTSMenuItem.Text = "Files";
            // 
            // usersTSMenuItem
            // 
            this.usersTSMenuItem.Name = "usersTSMenuItem";
            this.usersTSMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usersTSMenuItem.Text = "Users";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // yourProfileTSMenuItem
            // 
            this.yourProfileTSMenuItem.Name = "yourProfileTSMenuItem";
            this.yourProfileTSMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yourProfileTSMenuItem.Text = "Your Profile";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // currentUserTSLbl
            // 
            this.currentUserTSLbl.Name = "currentUserTSLbl";
            this.currentUserTSLbl.Size = new System.Drawing.Size(49, 22);
            this.currentUserTSLbl.Text = "CurUser";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 387);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
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
        private System.Windows.Forms.ToolStripLabel currentUserTSLbl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

