using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace LazyRename
{
    public partial class main_form : Form
    {
        public main_form()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.language);
            InitializeComponent();
        }

        private void Main_form_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string filename in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                string extension = Path.GetExtension(filename);
                string directory = Path.GetDirectoryName(filename);
                string name = Path.GetFileNameWithoutExtension(filename);

                string new_filename = directory;
                new_filename += "\\";
                new_filename += name;
                new_filename += System.IO.File.GetLastWriteTime(filename).ToString("_yyyy-MM-dd_hhmm");
                new_filename += extension;
                File.Move(filename, new_filename);

                Result_view.Rows.Insert(0, filename, Path.GetFileName(new_filename), "Undo");
            }
        }

        private void Main_form_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) // エクスプローラーからのファイルドロップであればTrue
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            showTopMostToolStripMenuItem.Checked = true;
            TopMost = true;
            Preset_box.SelectedIndex = 0;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void Result_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2) // Resetボタンが配置されている3列目であれば
            {
                string raw_before = Result_view[0, e.RowIndex].Value.ToString();
                string raw_after = Result_view[1, e.RowIndex].Value.ToString();
                string dir = Path.GetDirectoryName(raw_before);

                File.Move(dir + "\\" + raw_after, raw_before);

                Result_view.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void ExitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["language"] = "en";
            englishToolStripMenuItem.Checked = true;
            japaneseToolStripMenuItem.Checked = false;
        }

        private void JapaneseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["language "] = "ja";
            englishToolStripMenuItem.Checked = false;
            japaneseToolStripMenuItem.Checked = true;

        }

        private void ExampleLabel_Clicked(object sender, EventArgs e)
        {

        }

        private void showTopMostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showTopMostToolStripMenuItem.Checked = !showTopMostToolStripMenuItem.Checked;
            TopMost = !TopMost;
        }

        private void Preset_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(Preset_box.SelectedIndex);

        }
    }
}
