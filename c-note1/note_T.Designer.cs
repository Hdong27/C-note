namespace c_note1
{
    partial class note_T
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(note_T));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Style = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Font = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(887, 652);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 652);
            this.panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_File,
            this.ToolStripMenu_Style});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(107, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenu_File
            // 
            this.ToolStripMenu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_Open,
            this.ToolStripMenu_Save,
            this.ToolStripMenu_Print,
            this.ToolStripMenu_Exit});
            this.ToolStripMenu_File.Name = "ToolStripMenu_File";
            this.ToolStripMenu_File.Size = new System.Drawing.Size(51, 24);
            this.ToolStripMenu_File.Text = "파일";
            // 
            // ToolStripMenu_Open
            // 
            this.ToolStripMenu_Open.Name = "ToolStripMenu_Open";
            this.ToolStripMenu_Open.Size = new System.Drawing.Size(114, 26);
            this.ToolStripMenu_Open.Text = "열기";
            this.ToolStripMenu_Open.Click += new System.EventHandler(this.ToolStripMenu_Open_Click);
            // 
            // ToolStripMenu_Save
            // 
            this.ToolStripMenu_Save.Name = "ToolStripMenu_Save";
            this.ToolStripMenu_Save.Size = new System.Drawing.Size(114, 26);
            this.ToolStripMenu_Save.Text = "저장";
            this.ToolStripMenu_Save.Click += new System.EventHandler(this.ToolStripMenu_Save_Click);
            // 
            // ToolStripMenu_Print
            // 
            this.ToolStripMenu_Print.Name = "ToolStripMenu_Print";
            this.ToolStripMenu_Print.Size = new System.Drawing.Size(114, 26);
            this.ToolStripMenu_Print.Text = "출력";
            this.ToolStripMenu_Print.Click += new System.EventHandler(this.ToolStripMenu_Print_Click);
            // 
            // ToolStripMenu_Exit
            // 
            this.ToolStripMenu_Exit.Name = "ToolStripMenu_Exit";
            this.ToolStripMenu_Exit.Size = new System.Drawing.Size(114, 26);
            this.ToolStripMenu_Exit.Text = "종료";
            this.ToolStripMenu_Exit.Click += new System.EventHandler(this.ToolStripMenu_Exit_Click);
            // 
            // ToolStripMenu_Style
            // 
            this.ToolStripMenu_Style.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_Font});
            this.ToolStripMenu_Style.Name = "ToolStripMenu_Style";
            this.ToolStripMenu_Style.Size = new System.Drawing.Size(51, 24);
            this.ToolStripMenu_Style.Text = "서식";
            // 
            // ToolStripMenu_Font
            // 
            this.ToolStripMenu_Font.Name = "ToolStripMenu_Font";
            this.ToolStripMenu_Font.Size = new System.Drawing.Size(114, 26);
            this.ToolStripMenu_Font.Text = "글꼴";
            this.ToolStripMenu_Font.Click += new System.EventHandler(this.ToolStripMenu_Font_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // note_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 686);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "note_T";
            this.Text = "메모장";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Open;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Save;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Style;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Font;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Print;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Exit;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}