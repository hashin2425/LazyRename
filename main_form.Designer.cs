
namespace LazyRename
{
    partial class main_form
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.言語ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropbox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.dropbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.表示ToolStripMenuItem,
            this.言語ToolStripMenuItem,
            this.情報ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem1.Text = "ファイル";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 表示ToolStripMenuItem
            // 
            this.表示ToolStripMenuItem.Name = "表示ToolStripMenuItem";
            this.表示ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.表示ToolStripMenuItem.Text = "表示";
            // 
            // 言語ToolStripMenuItem
            // 
            this.言語ToolStripMenuItem.Name = "言語ToolStripMenuItem";
            this.言語ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.言語ToolStripMenuItem.Text = "言語";
            // 
            // 情報ToolStripMenuItem
            // 
            this.情報ToolStripMenuItem.Name = "情報ToolStripMenuItem";
            this.情報ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.情報ToolStripMenuItem.Text = "情報";
            // 
            // dropbox
            // 
            this.dropbox.Controls.Add(this.label1);
            this.dropbox.Location = new System.Drawing.Point(12, 27);
            this.dropbox.Name = "dropbox";
            this.dropbox.Size = new System.Drawing.Size(260, 222);
            this.dropbox.TabIndex = 2;
            this.dropbox.TabStop = false;
            this.dropbox.Text = "DropBox";
            this.dropbox.Enter += new System.EventHandler(this.dropbox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drop here!!";
            // 
            // main_form
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dropbox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LazyRename";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.main_form_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.main_form_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.main_form_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.dropbox.ResumeLayout(false);
            this.dropbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 言語ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 情報ToolStripMenuItem;
        private System.Windows.Forms.GroupBox dropbox;
        private System.Windows.Forms.Label label1;
    }
}

