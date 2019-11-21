namespace c_note1
{
    partial class note_P
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(note_P));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.color2 = new System.Windows.Forms.Panel();
            this.ChangeColor = new System.Windows.Forms.Button();
            this.color1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.color4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.color3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메모장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtBoxReceive = new System.Windows.Forms.TextBox();
            this.txtBoxRecievePort = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTConnet = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.color2);
            this.panel1.Controls.Add(this.ChangeColor);
            this.panel1.Controls.Add(this.color1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.color4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.color3);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 996);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(32, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 59);
            this.button2.TabIndex = 15;
            this.toolTip1.SetToolTip(this.button2, "현재색상");
            this.button2.UseVisualStyleBackColor = false;
            // 
            // color2
            // 
            this.color2.BackColor = System.Drawing.Color.Yellow;
            this.color2.Location = new System.Drawing.Point(10, 401);
            this.color2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(16, 24);
            this.color2.TabIndex = 10;
            this.toolTip1.SetToolTip(this.color2, "2번째 색상");
            this.color2.Click += new System.EventHandler(this.color2_Click);
            // 
            // ChangeColor
            // 
            this.ChangeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ChangeColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeColor.BackgroundImage")));
            this.ChangeColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChangeColor.FlatAppearance.BorderSize = 0;
            this.ChangeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeColor.Location = new System.Drawing.Point(2, 526);
            this.ChangeColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeColor.Name = "ChangeColor";
            this.ChangeColor.Size = new System.Drawing.Size(60, 51);
            this.ChangeColor.TabIndex = 13;
            this.toolTip1.SetToolTip(this.ChangeColor, "색변경");
            this.ChangeColor.UseVisualStyleBackColor = false;
            this.ChangeColor.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // color1
            // 
            this.color1.BackColor = System.Drawing.Color.Red;
            this.color1.Location = new System.Drawing.Point(10, 354);
            this.color1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(16, 24);
            this.color1.TabIndex = 8;
            this.toolTip1.SetToolTip(this.color1, "1번째 색상");
            this.color1.Click += new System.EventHandler(this.color1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(10, 284);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 24);
            this.panel2.TabIndex = 7;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // color4
            // 
            this.color4.BackColor = System.Drawing.Color.Blue;
            this.color4.Location = new System.Drawing.Point(10, 494);
            this.color4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.color4.Name = "color4";
            this.color4.Size = new System.Drawing.Size(16, 24);
            this.color4.TabIndex = 12;
            this.toolTip1.SetToolTip(this.color4, "4번째 색상");
            this.color4.Click += new System.EventHandler(this.color4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImage = global::c_note1.Properties.Resources.KakaoTalk_20180619_133500620;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 52);
            this.button1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button1, "연필");
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.trackBar1.Location = new System.Drawing.Point(2, 230);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(108, 56);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip1.SetToolTip(this.trackBar1, "굵기");
            this.trackBar1.Value = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.BackgroundImage = global::c_note1.Properties.Resources.KakaoTalk_20180619_133500736;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(3, 80);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 56);
            this.button4.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button4, "지우개");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.BackgroundImage = global::c_note1.Properties.Resources.KakaoTalk_20180619_134337373;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(2, 142);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(59, 67);
            this.button6.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button6, "저장");
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // color3
            // 
            this.color3.BackColor = System.Drawing.Color.Lime;
            this.color3.Location = new System.Drawing.Point(10, 449);
            this.color3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(16, 24);
            this.color3.TabIndex = 12;
            this.toolTip1.SetToolTip(this.color3, "3번째 색상");
            this.color3.Click += new System.EventHandler(this.color3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.메모장ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1253, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.저장ToolStripMenuItem.Text = "저장";
            this.저장ToolStripMenuItem.Click += new System.EventHandler(this.저장ToolStripMenuItem_Click);
            // 
            // 메모장ToolStripMenuItem
            // 
            this.메모장ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem1});
            this.메모장ToolStripMenuItem.Name = "메모장ToolStripMenuItem";
            this.메모장ToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.메모장ToolStripMenuItem.Text = "메모장";
            // 
            // 열기ToolStripMenuItem1
            // 
            this.열기ToolStripMenuItem1.Name = "열기ToolStripMenuItem1";
            this.열기ToolStripMenuItem1.Size = new System.Drawing.Size(114, 26);
            this.열기ToolStripMenuItem1.Text = "열기";
            this.열기ToolStripMenuItem1.Click += new System.EventHandler(this.열기ToolStripMenuItem1_Click);
            // 
            // txtBoxReceive
            // 
            this.txtBoxReceive.Location = new System.Drawing.Point(869, 80);
            this.txtBoxReceive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxReceive.Multiline = true;
            this.txtBoxReceive.Name = "txtBoxReceive";
            this.txtBoxReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxReceive.Size = new System.Drawing.Size(230, 542);
            this.txtBoxReceive.TabIndex = 3;
            this.txtBoxReceive.UseWaitCursor = true;
            this.txtBoxReceive.Visible = false;
            // 
            // txtBoxRecievePort
            // 
            this.txtBoxRecievePort.Location = new System.Drawing.Point(1019, 46);
            this.txtBoxRecievePort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxRecievePort.Name = "txtBoxRecievePort";
            this.txtBoxRecievePort.Size = new System.Drawing.Size(54, 25);
            this.txtBoxRecievePort.TabIndex = 4;
            this.txtBoxRecievePort.Text = "COM4";
            this.txtBoxRecievePort.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(114, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1253, 722);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // BTConnet
            // 
            this.BTConnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTConnet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTConnet.BackgroundImage")));
            this.BTConnet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTConnet.FlatAppearance.BorderSize = 0;
            this.BTConnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTConnet.Location = new System.Drawing.Point(114, 0);
            this.BTConnet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTConnet.Name = "BTConnet";
            this.BTConnet.Size = new System.Drawing.Size(62, 28);
            this.BTConnet.TabIndex = 14;
            this.toolTip1.SetToolTip(this.BTConnet, "블루투스연결");
            this.BTConnet.UseVisualStyleBackColor = false;
            this.BTConnet.Click += new System.EventHandler(this.BTConnet_Click);
            // 
            // note_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 750);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTConnet);
            this.Controls.Add(this.txtBoxRecievePort);
            this.Controls.Add(this.txtBoxReceive);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1129, 797);
            this.Name = "note_P";
            this.Text = "그림판";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel color4;
        private System.Windows.Forms.Panel color3;
        private System.Windows.Forms.Panel color2;
        private System.Windows.Forms.Panel color1;
        private System.Windows.Forms.Button ChangeColor;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button BTConnet;
        private System.Windows.Forms.TextBox txtBoxReceive;
        private System.Windows.Forms.TextBox txtBoxRecievePort;
        private System.Windows.Forms.ToolStripMenuItem 메모장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
