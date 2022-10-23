
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropbox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Show_top_checkBox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.overwrite_checkBox = new System.Windows.Forms.CheckBox();
            this.Result_view = new System.Windows.Forms.DataGridView();
            this.Col_before = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_after = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_reset = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip.SuspendLayout();
            this.dropbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Result_view)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            resources.ApplyResources(this.displayToolStripMenuItem, "displayToolStripMenuItem");
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            resources.ApplyResources(this.infoToolStripMenuItem, "infoToolStripMenuItem");
            // 
            // dropbox
            // 
            this.dropbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dropbox.Controls.Add(this.label1);
            this.dropbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.dropbox, "dropbox");
            this.dropbox.Name = "dropbox";
            this.dropbox.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // Show_top_checkBox
            // 
            resources.ApplyResources(this.Show_top_checkBox, "Show_top_checkBox");
            this.Show_top_checkBox.Name = "Show_top_checkBox";
            this.Show_top_checkBox.UseVisualStyleBackColor = true;
            this.Show_top_checkBox.CheckedChanged += new System.EventHandler(this.Show_top_checkBox_CheckedChanged);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // overwrite_checkBox
            // 
            resources.ApplyResources(this.overwrite_checkBox, "overwrite_checkBox");
            this.overwrite_checkBox.Name = "overwrite_checkBox";
            this.overwrite_checkBox.UseVisualStyleBackColor = true;
            // 
            // Result_view
            // 
            this.Result_view.AllowUserToAddRows = false;
            this.Result_view.AllowUserToDeleteRows = false;
            this.Result_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_before,
            this.Col_after,
            this.Col_reset});
            resources.ApplyResources(this.Result_view, "Result_view");
            this.Result_view.Name = "Result_view";
            this.Result_view.RowHeadersVisible = false;
            this.Result_view.RowTemplate.Height = 21;
            this.Result_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.result_view_CellClick);
            // 
            // Col_before
            // 
            this.Col_before.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Col_before, "Col_before");
            this.Col_before.Name = "Col_before";
            this.Col_before.ReadOnly = true;
            // 
            // Col_after
            // 
            resources.ApplyResources(this.Col_after, "Col_after");
            this.Col_after.Name = "Col_after";
            this.Col_after.ReadOnly = true;
            // 
            // Col_reset
            // 
            resources.ApplyResources(this.Col_reset, "Col_reset");
            this.Col_reset.Name = "Col_reset";
            this.Col_reset.ReadOnly = true;
            this.Col_reset.Text = "Undo";
            // 
            // main_form
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.Result_view);
            this.Controls.Add(this.overwrite_checkBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Show_top_checkBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dropbox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "main_form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.main_form_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.main_form_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.main_form_DragEnter);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.dropbox.ResumeLayout(false);
            this.dropbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Result_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.GroupBox dropbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Show_top_checkBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.CheckBox overwrite_checkBox;
        private System.Windows.Forms.DataGridView Result_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_before;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_after;
        private System.Windows.Forms.DataGridViewButtonColumn Col_reset;
    }
}

