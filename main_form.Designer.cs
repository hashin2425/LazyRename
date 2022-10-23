
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.japaneseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showTopMostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropbox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Result_view = new System.Windows.Forms.DataGridView();
            this.Col_before = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_after = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_reset = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Preset_box = new System.Windows.Forms.ComboBox();
            this.Example_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.dropbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Result_view)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.displayToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitXToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // exitXToolStripMenuItem
            // 
            this.exitXToolStripMenuItem.Name = "exitXToolStripMenuItem";
            resources.ApplyResources(this.exitXToolStripMenuItem, "exitXToolStripMenuItem");
            this.exitXToolStripMenuItem.Click += new System.EventHandler(this.ExitXToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.japaneseToolStripMenuItem,
            this.toolStripSeparator1,
            this.showTopMostToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            resources.ApplyResources(this.displayToolStripMenuItem, "displayToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItem_Click);
            // 
            // japaneseToolStripMenuItem
            // 
            this.japaneseToolStripMenuItem.Name = "japaneseToolStripMenuItem";
            resources.ApplyResources(this.japaneseToolStripMenuItem, "japaneseToolStripMenuItem");
            this.japaneseToolStripMenuItem.Click += new System.EventHandler(this.JapaneseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // showTopMostToolStripMenuItem
            // 
            this.showTopMostToolStripMenuItem.Name = "showTopMostToolStripMenuItem";
            resources.ApplyResources(this.showTopMostToolStripMenuItem, "showTopMostToolStripMenuItem");
            this.showTopMostToolStripMenuItem.Click += new System.EventHandler(this.showTopMostToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            resources.ApplyResources(this.infoToolStripMenuItem, "infoToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
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
            this.Result_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Result_view_CellClick);
            // 
            // Col_before
            // 
            this.Col_before.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_before.FillWeight = 225F;
            resources.ApplyResources(this.Col_before, "Col_before");
            this.Col_before.Name = "Col_before";
            this.Col_before.ReadOnly = true;
            // 
            // Col_after
            // 
            this.Col_after.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_after.FillWeight = 120F;
            resources.ApplyResources(this.Col_after, "Col_after");
            this.Col_after.Name = "Col_after";
            this.Col_after.ReadOnly = true;
            // 
            // Col_reset
            // 
            resources.ApplyResources(this.Col_reset, "Col_reset");
            this.Col_reset.Name = "Col_reset";
            this.Col_reset.ReadOnly = true;
            this.Col_reset.Text = "戻す";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Preset_box);
            this.groupBox1.Controls.Add(this.Example_Label);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // Preset_box
            // 
            this.Preset_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Preset_box.FormattingEnabled = true;
            this.Preset_box.Items.AddRange(new object[] {
            resources.GetString("Preset_box.Items"),
            resources.GetString("Preset_box.Items1"),
            resources.GetString("Preset_box.Items2"),
            resources.GetString("Preset_box.Items3")});
            resources.ApplyResources(this.Preset_box, "Preset_box");
            this.Preset_box.Name = "Preset_box";
            this.Preset_box.SelectedIndexChanged += new System.EventHandler(this.Preset_box_SelectedIndexChanged);
            // 
            // Example_Label
            // 
            resources.ApplyResources(this.Example_Label, "Example_Label");
            this.Example_Label.Name = "Example_Label";
            this.Example_Label.Click += new System.EventHandler(this.ExampleLabel_Clicked);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // main_form
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.Result_view);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dropbox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "main_form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_form_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_form_DragEnter);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.dropbox.ResumeLayout(false);
            this.dropbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Result_view)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.GroupBox dropbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.DataGridView Result_view;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem japaneseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitXToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Example_Label;
        private System.Windows.Forms.ComboBox Preset_box;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showTopMostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_before;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_after;
        private System.Windows.Forms.DataGridViewButtonColumn Col_reset;
    }
}

