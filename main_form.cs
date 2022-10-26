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
using System.Text.RegularExpressions;

namespace LazyRename
{
    public partial class main_form : Form
    {
        private struct Rename_Format
        {
            public string display;
            public string format;
            public string example;
        }
        private List<Rename_Format> formats = new List<Rename_Format>();

        public main_form()
        {
            // >>> Add new format here <<<
            formats.Add(new Rename_Format
            {
                display = "Add updated date",
                format = "?f_?u",
                example = "example_2022-10-22.txt"
            });
            formats.Add(new Rename_Format
            {
                display = "Add updated date + time",
                format = "?f_?U",
                example = "example_2022-10-22_1108.txt"
            });
            formats.Add(new Rename_Format
            {
                display = "Add created date",
                format = "?f_?c",
                example = "example_2022-10-22.txt"
            });
            formats.Add(new Rename_Format
            {
                display = "Add created date + time",
                format = "?f_?C",
                example = "example_2022-10-22_1108.txt"
            });

            // Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.language);

            // Load
            InitializeComponent();
        }

        private void Main_form_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string filename in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                string extension = Path.GetExtension(filename);
                string directory = Path.GetDirectoryName(filename);

                string new_basename = formats[Preset_box.SelectedIndex].format;
                new_basename = new_basename.Replace("?f", Path.GetFileNameWithoutExtension(filename));
                new_basename = new_basename.Replace("?u", File.GetLastWriteTime(filename).ToString("yyyy-MM-dd"));
                new_basename = new_basename.Replace("?c", File.GetCreationTime(filename).ToString("yyyy-MM-dd"));
                new_basename = new_basename.Replace("?U", File.GetLastWriteTime(filename).ToString("yyyy-MM-dd_hhmm"));
                new_basename = new_basename.Replace("?C", File.GetCreationTime(filename).ToString("yyyy-MM-dd_hhmm"));

                string new_filename = directory + "\\" + new_basename + extension;
                File.Move(filename, new_filename);

                Result_view.Rows.Insert(0, filename, Path.GetFileName(new_filename), "Undo");
            }
        }

        private void Main_form_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) // If it was file dropping from explorer
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
            // Show window top most
            showTopMostToolStripMenuItem.Checked = true;
            TopMost = true;

            // Add formats into Preset display
            foreach (var item in formats)
            {
                Preset_box.Items.Add(item.display);
            }
            Preset_box.SelectedIndex = 0;

            Console.WriteLine(formats[1].display);
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void Result_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2) // When clicked the 3rd column, which is Undo button
            {
                string raw_before = Result_view[0, e.RowIndex].Value.ToString();
                string raw_after = Result_view[1, e.RowIndex].Value.ToString();
                string dir = Path.GetDirectoryName(raw_before);
                try
                {
                    File.Move(dir + "\\" + raw_after, raw_before);
                }
                catch
                {
                    MessageBox.Show("File missing");
                }
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
            Properties.Settings.Default["language"] = "ja";
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
            Example_Label.Text = formats[Preset_box.SelectedIndex].example;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
