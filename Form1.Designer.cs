namespace Lab03_02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoSảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởTậpTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuTậpTinTooltripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địnhDạngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewFile = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveFile = new System.Windows.Forms.ToolStripButton();
            this.tscmbFont = new System.Windows.Forms.ToolStripComboBox();
            this.tscmbSize = new System.Windows.Forms.ToolStripComboBox();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.tsbItalic = new System.Windows.Forms.ToolStripButton();
            this.tsbUnderline = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.địnhDạngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoSảnToolStripMenuItem,
            this.mởTậpTinToolStripMenuItem,
            this.lưuTậpTinTooltripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // tạoSảnToolStripMenuItem
            // 
            this.tạoSảnToolStripMenuItem.Name = "tạoSảnToolStripMenuItem";
            this.tạoSảnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tạoSảnToolStripMenuItem.Text = "Tạo văn bản mới";
            this.tạoSảnToolStripMenuItem.Click += new System.EventHandler(this.tạoSảnToolStripMenuItem_Click);
            // 
            // mởTậpTinToolStripMenuItem
            // 
            this.mởTậpTinToolStripMenuItem.Name = "mởTậpTinToolStripMenuItem";
            this.mởTậpTinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mởTậpTinToolStripMenuItem.Text = "Mở tập tin";
            this.mởTậpTinToolStripMenuItem.Click += new System.EventHandler(this.mởTậpTinToolStripMenuItem_Click);
            // 
            // lưuTậpTinTooltripMenuItem
            // 
            this.lưuTậpTinTooltripMenuItem.Name = "lưuTậpTinTooltripMenuItem";
            this.lưuTậpTinTooltripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lưuTậpTinTooltripMenuItem.Text = "Lưu văn bản";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // địnhDạngToolStripMenuItem
            // 
            this.địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            this.địnhDạngToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.địnhDạngToolStripMenuItem.Text = "Định dạng";
            this.địnhDạngToolStripMenuItem.Click += new System.EventHandler(this.địnhDạngToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewFile,
            this.tsbSaveFile,
            this.tscmbFont,
            this.tscmbSize,
            this.btnBold,
            this.tsbItalic,
            this.tsbUnderline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(612, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNewFile
            // 
            this.tsbNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewFile.Image")));
            this.tsbNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewFile.Name = "tsbNewFile";
            this.tsbNewFile.Size = new System.Drawing.Size(23, 22);
            this.tsbNewFile.Text = "toolStripButton1";
            this.tsbNewFile.Click += new System.EventHandler(this.tsbNewFile_Click);
            // 
            // tsbSaveFile
            // 
            this.tsbSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveFile.Image")));
            this.tsbSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveFile.Name = "tsbSaveFile";
            this.tsbSaveFile.Size = new System.Drawing.Size(23, 22);
            this.tsbSaveFile.Text = "toolStripButton2";
            this.tsbSaveFile.Click += new System.EventHandler(this.tsbSaveFile_Click);
            // 
            // tscmbFont
            // 
            this.tscmbFont.Name = "tscmbFont";
            this.tscmbFont.Size = new System.Drawing.Size(121, 25);
            this.tscmbFont.SelectedIndexChanged += new System.EventHandler(this.tscmbFont_SelectedIndexChanged);
            // 
            // tscmbSize
            // 
            this.tscmbSize.Name = "tscmbSize";
            this.tscmbSize.Size = new System.Drawing.Size(121, 25);
            this.tscmbSize.SelectedIndexChanged += new System.EventHandler(this.tscmbSize_SelectedIndexChanged);
            // 
            // btnBold
            // 
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBold.Image = ((System.Drawing.Image)(resources.GetObject("btnBold.Image")));
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(23, 22);
            this.btnBold.Text = "toolStripButton3";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // tsbItalic
            // 
            this.tsbItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbItalic.Image = ((System.Drawing.Image)(resources.GetObject("tsbItalic.Image")));
            this.tsbItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbItalic.Name = "tsbItalic";
            this.tsbItalic.Size = new System.Drawing.Size(23, 22);
            this.tsbItalic.Text = "toolStripButton4";
            this.tsbItalic.Click += new System.EventHandler(this.tsbItalic_Click);
            // 
            // tsbUnderline
            // 
            this.tsbUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUnderline.Image = ((System.Drawing.Image)(resources.GetObject("tsbUnderline.Image")));
            this.tsbUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUnderline.Name = "tsbUnderline";
            this.tsbUnderline.Size = new System.Drawing.Size(23, 22);
            this.tsbUnderline.Text = "toolStripButton5";
            this.tsbUnderline.Click += new System.EventHandler(this.tsbUnderline_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(614, 242);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 294);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địnhDạngToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNewFile;
        private System.Windows.Forms.ToolStripButton tsbSaveFile;
        private System.Windows.Forms.ToolStripComboBox tscmbFont;
        private System.Windows.Forms.ToolStripComboBox tscmbSize;
        private System.Windows.Forms.ToolStripButton btnBold;
        private System.Windows.Forms.ToolStripButton tsbItalic;
        private System.Windows.Forms.ToolStripButton tsbUnderline;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem tạoSảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởTậpTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuTậpTinTooltripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}

