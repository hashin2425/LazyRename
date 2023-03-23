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
using System.Runtime.InteropServices;

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
        private readonly List<Rename_Format> formats = new List<Rename_Format>();
        private readonly IFELanguage ife_lang = Activator.CreateInstance(Type.GetTypeFromProgID("MSIME.Japan")) as IFELanguage;

        private readonly Dictionary<string, string> RomajiHiraDict = new Dictionary<string, string>()
        {
            {"a", "あ"},{ "ba", "ば"},{ "da", "だ"}, { "fa", "ふぁ"}, { "ga", "が"}, { "ha", "は"},
            { "ja", "じゃ"}, { "ka", "か"}, { "ma", "ま"}, { "na", "な"}, { "pa", "ぱ"}, { "ra", "ら"},
            { "sa", "さ"}, { "ta", "た"}, { "wa", "わ"}, { "ya", "や"}, { "za", "ざ"}, { "cha", "ちゃ"},
            { "sha", "しゃ"}, { "xwa", "ゎ"}, { "n", "ん"}, { "nn", "ん"}, { "nxa", "んぁ"}, { "bya", "びゃ"},
            { "dya", "ぢゃ"}, { "gya", "ぎゃ"}, { "hya", "ひゃ"}, { "kya", "きゃ"}, { "mya", "みゃ"},
            { "nya", "にゃ"}, { "pya", "ぴゃ"}, { "rya", "りゃ"}, { "sya", "しゃ"}, { "tya", "ちゃ"},
            { "zya", "じゃ"}, { "i", "い"}, { "bi", "び"}, { "di", "ぢ"}, { "fi", "ふぃ"}, { "gi", "ぎ"},
            { "hi", "ひ"}, { "ji", "じ"}, { "ki", "き"}, { "mi", "み"}, { "ni", "に"}, { "pi", "ぴ"},
            { "ri", "り"}, { "si", "し"}, { "ti", "ち"}, { "wi", "うぃ"}, { "zi", "じ"}, { "chi", "ち"},
            { "shi", "し"}, { "nxi", "んぃ"}, { "dyi", "でぃ"}, { "u", "う"}, { "bu", "ぶ"}, { "du", "づ"},
            { "fu", "ふ"}, { "gu", "ぐ"}, { "hu", "ふ"}, { "ju", "じゅ"}, { "ku", "く"}, { "mu", "む"},
            { "nu", "ぬ"}, { "pu", "ぷ"}, { "ru", "る"}, { "su", "す"}, { "tu", "つ"}, { "yu", "ゆ"},
            { "zu", "ず"}, { "chu", "ちゅ"}, { "shu", "しゅ"}, { "tsu", "つ"}, { "xtu", "っ"}, { "nxu", "んぅ"},
            { "byu", "びゅ"}, { "dyu", "ぢゅ"}, { "gyu", "ぎゅ"}, { "hyu", "ひゅ"}, { "kyu", "きゅ"},
            { "myu", "みゅ"}, { "nyu", "にゅ"}, { "pyu", "ぴゅ"}, { "ryu", "りゅ"}, { "syu", "しゅ"},
            { "tyu", "ちゅ"}, { "zyu", "じゅ"}, { "e", "え"}, { "be", "べ"}, { "de", "で"}, { "fe", "ふぇ"},
            { "ge", "げ"}, { "he", "へ"}, { "je", "じぇ"}, { "ke", "け"}, { "me", "め"}, { "ne", "ね"},
            { "pe", "ぺ"}, { "re", "れ"}, { "se", "せ"}, { "te", "て"}, { "we", "うぇ"}, { "ze", "ぜ"},
            { "che", "ちぇ"}, { "nxe", "んぇ"}, { "tye", "ちぇ"}, { "zye", "じぇ"}, { "o", "お"},
            { "bo", "ぼ"}, { "do", "ど"}, { "fo", "ふぉ"}, { "go", "ご"}, { "ho", "ほ"},
            { "jo", "じょ"}, { "ko", "こ"}, { "mo", "も"}, { "no", "の"}, { "po", "ぽ"},
            { "ro", "ろ"}, { "so", "そ"}, { "to", "と"}, { "wo", "を"}, { "yo", "よ"},
            { "zo", "ぞ"}, { "cho", "ちょ"}, { "sho", "しょ"}, { "nxo", "んぉ"}, { "byo", "びょ"},
            { "dyo", "ぢょ"}, { "gyo", "ぎょ"}, { "hyo", "ひょ"}, { "kyo", "きょ"}, { "myo", "みょ"},
            { "nyo", "にょ"}, { "pyo", "ぴょ"}, { "ryo", "りょ"}, { "syo", "しょ"}, { "tyo", "ちょ"},
            { "zyo", "じょ"}, {"-", "ー"}
        };

        public main_form()
        {
            // >>> Add new format here <<<
            formats.Add(new Rename_Format
            {
                display = "末尾に更新日を追加",
                format = "?f_?u",
                example = "example_2022-10-22.txt"
            });
            formats.Add(new Rename_Format
            {
                display = "末尾に更新日時を追加",
                format = "?f_?U",
                example = "example_2022-10-22_1108.txt"
            });
            formats.Add(new Rename_Format
            {
                display = "末尾に作成日を追加",
                format = "?f_?c",
                example = "example_2022-10-22.txt"
            });
            formats.Add(new Rename_Format
            {
                display = "末尾に作成日時を追加",
                format = "?f_?C",
                example = "example_2022-10-22_1108.txt"
            });
            formats.Add(new Rename_Format
            {
                display = "ローマ字 -> ひらがな",
                format = "?rh",
                example = "えぁｍｐぇ.txt"
            });
            formats.Add(new Rename_Format
            {
                display = "ひらがな -> ローマ字",
                format = "?hr",
                example = "example.txt"
            });

            // IFE Interface読み込み
            int response = ife_lang.Open();
            if (response == 0)
            {
                formats.Add(new Rename_Format
                {
                    display = "ふりがなを付ける",
                    format = "?ym",
                    example = "例_れい.txt"
                });
            }

            // Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.language);

            // Load
            InitializeComponent();
        }

        private void Main_form_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string f in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                string GetExtension = Path.GetExtension(f);
                string GetDirectoryName = Path.GetDirectoryName(f);
                string GetFileNameWithoutExtension = Path.GetFileNameWithoutExtension(f);
                string GetFileName = Path.GetFileName(f);
                var GetLastWriteTime = File.GetLastWriteTime(f);
                var GetCreationTime = File.GetCreationTime(f);
                var GetAttributes = File.GetAttributes(f);

                if (mode_tab.SelectedIndex == 0)
                {
                    // Easy mode
                    string new_basename = formats[Preset_box.SelectedIndex].format;
                    new_basename = new_basename.Replace("?f", GetFileNameWithoutExtension);
                    new_basename = new_basename.Replace("?u", GetLastWriteTime.ToString("yyyy-MM-dd"));
                    new_basename = new_basename.Replace("?c", GetCreationTime.ToString("yyyy-MM-dd"));
                    new_basename = new_basename.Replace("?U", GetLastWriteTime.ToString("yyyy-MM-dd_hhmm"));
                    new_basename = new_basename.Replace("?C", GetCreationTime.ToString("yyyy-MM-dd_hhmm"));
                    if (new_basename.Contains("?rh")) { new_basename = new_basename.Replace("?rh", Romaji2Hira(GetFileNameWithoutExtension, false)); }
                    if (new_basename.Contains("?hr")) { new_basename = new_basename.Replace("?hr", Romaji2Hira(GetFileNameWithoutExtension, true)); }
                    if (new_basename.Contains("?ym")) { new_basename = new_basename.Replace("?ym", KanjiYomi(GetFileNameWithoutExtension)); }

                    string new_filename = GetDirectoryName + "\\" + new_basename + GetExtension;
                    File.Move(f, new_filename);

                    Result_view.Rows.Insert(0, f, Path.GetFileName(new_filename), "Undo");
                }
                else if (mode_tab.SelectedIndex == 1)
                {
                    //Advanced mode
                    advance_rename_table.Rows.Insert(0, "X", GetFileName, "");
                    Console.WriteLine(GetAttributes);
                }
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
            // temporary code here
            Console.WriteLine("今日は晴れです");
            Console.WriteLine(KanjiYomi("今日は晴れです"));
            //

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

        private void ShowTopMostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showTopMostToolStripMenuItem.Checked = !showTopMostToolStripMenuItem.Checked;
            TopMost = !TopMost;
        }

        private void Preset_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Example_Label.Text = formats[Preset_box.SelectedIndex].example;
        }

        private string Romaji2Hira(string input, bool Hira2Romaji)
        {
            foreach (var convert_set in RomajiHiraDict.OrderByDescending(item => item.Key.Length))
            {
                if (Hira2Romaji)
                {
                    input = input.Replace(convert_set.Value, convert_set.Key);
                }
                else
                {
                    input = input.Replace(convert_set.Key, convert_set.Value);
                }
            }
            return input; // ro-majiwohiragananihennkannsitehyoujisuru -> ろ-まじをひらがなにへんかんしてひょうじする
        }

        private string KanjiYomi(string kanji)
        {
            // 今日の天気ははれ -> きょうのてんきははれ

            int response = ife_lang.GetPhonetic(kanji, 1, -1, out string yomi);
            if (response == 0)
            {
                return yomi;
            }
            else
            {
                Console.WriteLine(response);
                return "";
            }
        }
    }

    [ComImport]
    [Guid("019F7152-E6DB-11d0-83C3-00C04FDDB82E")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IFELanguage
    {
        int Open();
        int Close();
        int GetJMorphResult(uint dwRequest, uint dwCMode, int cwchInput, [MarshalAs(UnmanagedType.LPWStr)] string pwchInput, IntPtr pfCInfo, out object ppResult);
        int GetConversionModeCaps(ref uint pdwCaps);
        int GetPhonetic([MarshalAs(UnmanagedType.BStr)] string @string, int start, int length, [MarshalAs(UnmanagedType.BStr)] out string result);
        int GetConversion([MarshalAs(UnmanagedType.BStr)] string @string, int start, int length, [MarshalAs(UnmanagedType.BStr)] out string result);
    }
}

