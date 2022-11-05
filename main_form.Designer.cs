
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
            this.advance_tab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.advance_rename_table = new System.Windows.Forms.DataGridView();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.easy_tab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Result_view = new System.Windows.Forms.DataGridView();
            this.Col_before = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_after = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_reset = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Example_Label = new System.Windows.Forms.Label();
            this.Preset_box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mode_tab = new System.Windows.Forms.TabControl();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip.SuspendLayout();
            this.dropbox.SuspendLayout();
            this.advance_tab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advance_rename_table)).BeginInit();
            this.easy_tab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Result_view)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.mode_tab.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.showTopMostToolStripMenuItem.Click += new System.EventHandler(this.ShowTopMostToolStripMenuItem_Click);
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
            resources.ApplyResources(this.dropbox, "dropbox");
            this.dropbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dropbox.Name = "dropbox";
            this.dropbox.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // advance_tab
            // 
            this.advance_tab.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.advance_tab, "advance_tab");
            this.advance_tab.Name = "advance_tab";
            this.advance_tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.advance_rename_table, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // advance_rename_table
            // 
            this.advance_rename_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advance_rename_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Remove,
            this.name,
            this.title});
            resources.ApplyResources(this.advance_rename_table, "advance_rename_table");
            this.advance_rename_table.Name = "advance_rename_table";
            this.advance_rename_table.RowHeadersVisible = false;
            this.advance_rename_table.RowTemplate.Height = 21;
            // 
            // Remove
            // 
            resources.ApplyResources(this.Remove, "Remove");
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // title
            // 
            resources.ApplyResources(this.title, "title");
            this.title.Name = "title";
            // 
            // easy_tab
            // 
            this.easy_tab.BackColor = System.Drawing.Color.Transparent;
            this.easy_tab.Controls.Add(this.tableLayoutPanel2);
            resources.ApplyResources(this.easy_tab, "easy_tab");
            this.easy_tab.Name = "easy_tab";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.Result_view, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
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
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.Example_Label, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.Preset_box, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // Example_Label
            // 
            resources.ApplyResources(this.Example_Label, "Example_Label");
            this.Example_Label.Name = "Example_Label";
            // 
            // Preset_box
            // 
            resources.ApplyResources(this.Preset_box, "Preset_box");
            this.Preset_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Preset_box.FormattingEnabled = true;
            this.Preset_box.Name = "Preset_box";
            this.Preset_box.SelectedIndexChanged += new System.EventHandler(this.Preset_box_SelectedIndexChanged);
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
            // mode_tab
            // 
            this.mode_tab.Controls.Add(this.easy_tab);
            this.mode_tab.Controls.Add(this.advance_tab);
            resources.ApplyResources(this.mode_tab, "mode_tab");
            this.mode_tab.Name = "mode_tab";
            this.mode_tab.SelectedIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.dropbox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.mode_tab, 1, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // main_form
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.tableLayoutPanel4);
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
            this.advance_tab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advance_rename_table)).EndInit();
            this.easy_tab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Result_view)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.mode_tab.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem japaneseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitXToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showTopMostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage advance_tab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView advance_rename_table;
        private System.Windows.Forms.TabPage easy_tab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView Result_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_before;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_after;
        private System.Windows.Forms.DataGridViewButtonColumn Col_reset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label Example_Label;
        private System.Windows.Forms.ComboBox Preset_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl mode_tab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
    }
}

