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

namespace LazyRename
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void main_form_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string filename in files)
            {
                string extension = Path.GetExtension(filename);
                string directory = Path.GetDirectoryName(filename);
                string name = Path.GetFileNameWithoutExtension(filename);

                string new_filename = directory;
                new_filename += "\\";
                new_filename += name;
                new_filename += System.IO.File.GetLastWriteTime(filename).ToString("D");
                new_filename += extension;
                System.IO.File.Move(filename, new_filename);
                
                Result_view.Rows.Insert(0, filename, Path.GetFileName(new_filename), "Undo");
            }
        }

        private void main_form_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // エクスプローラーからのファイルドロップであればTrue
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void main_form_Load(object sender, EventArgs e)
        {
        }

        private void Show_top_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = Show_top_checkBox.Checked;
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void result_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                string raw_before = Result_view[0, e.RowIndex].Value.ToString();
                string raw_after = Result_view[1, e.RowIndex].Value.ToString();
                string dir = Path.GetDirectoryName(raw_before);

                System.IO.File.Move(dir + "\\" + raw_after, raw_before);

                Result_view.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
