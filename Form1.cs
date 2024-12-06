using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Lab03_02
{
    public partial class Form1 : Form
    {
        private bool isBoldPressed = false;
        private bool isItalicPressed = false;
        private bool isUnderlinePressed = false;


        public Form1()
        {
            InitializeComponent();
            
        }

        private void ToggleFontStyle(FontStyle style)
        {
            Font cf = richTextBox1.SelectionFont;
            if (cf != null)
            {
                FontStyle newFontStyle;

                // Toggle the selected style
                if (cf.Style.HasFlag(style))
                {
                    newFontStyle = cf.Style & ~style; 
                }
                else
                {
                    newFontStyle = cf.Style | style; 
                }

                richTextBox1.SelectionFont = new Font(cf, newFontStyle);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            tscmbFont.Text = "Tamoha";
            tscmbSize.Text = "14";
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                tscmbFont.Items.Add(font.Name);
            }
            List<int> listSize = new List<int> { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var s in listSize)
            {
                tscmbSize.Items.Add(s);
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            isBoldPressed = !isBoldPressed;
            ToggleFontStyle(FontStyle.Bold);

            if (isBoldPressed) {
                btnBold.BackColor = Color.LightGray;
            }
            else
            {
                btnBold.BackColor = SystemColors.ButtonFace;
            }
        }
        

        private void tsbItalic_Click(object sender, EventArgs e)
        {
            isItalicPressed = !isItalicPressed;
            ToggleFontStyle(FontStyle.Italic);

            
            if (isItalicPressed)
            {
                tsbItalic.BackColor = Color.LightGray; 
            }
            else
            {
                tsbItalic.BackColor = SystemColors.ButtonFace; 
            }
        }

        private void tsbUnderline_Click(object sender, EventArgs e)
        {
            isUnderlinePressed = !isUnderlinePressed;
            ToggleFontStyle(FontStyle.Underline);

            
            if (isUnderlinePressed)
            {
                tsbUnderline.BackColor = Color.LightGray;
            }
            else
            {
                tsbUnderline.BackColor = SystemColors.ButtonFace; 
            }
        }

        private void tạoSảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void tscmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tscmbSize.SelectedItem != null)
            {
                float newSize;
                
                if (float.TryParse(tscmbSize.SelectedItem.ToString(), out newSize))
                {
                    
                    if (richTextBox1.SelectionFont != null)
                    {
                       
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, newSize, richTextBox1.SelectionFont.Style);
                    }
                }
            }
        }

        private void tsbNewFile_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void tscmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscmbFont.SelectedItem != null)
            {
                richTextBox1.SelectionFont = new Font(tscmbFont.SelectedItem.ToString(), richTextBox1.SelectionFont.Size);
            }
        }

        private void tsbSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = "c:\\";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // Bộ lọc file
            saveFileDialog.FileName = "default.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, richTextBox1.Text); // Lưu nội dung từ TextBox
            }
        }


        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\"; 
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // Bộ lọc file

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                string filePath = openFileDialog.FileName;
                string fileContent = File.ReadAllText(filePath);

                richTextBox1.Text = fileContent;
            }
        }

        private void lưuTậpTinTooltripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            
                saveFileDialog.InitialDirectory = "c:\\"; 
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // Bộ lọc file
                saveFileDialog.FileName = "default.txt"; 

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    string filePath = saveFileDialog.FileName;
                    File.WriteAllText(filePath, richTextBox1.Text); // Lưu nội dung từ TextBox
                }
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
            }
        }
    }
}
