namespace c_note1
{
    partial class C_main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C_main));
            this.BnoteL = new System.Windows.Forms.Button();
            this.BnoteR = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // BnoteL
            // 
            this.BnoteL.BackColor = System.Drawing.Color.White;
            this.BnoteL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BnoteL.BackgroundImage")));
            this.BnoteL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BnoteL.FlatAppearance.BorderSize = 0;
            this.BnoteL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BnoteL.Location = new System.Drawing.Point(387, 309);
            this.BnoteL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BnoteL.Name = "BnoteL";
            this.BnoteL.Size = new System.Drawing.Size(209, 217);
            this.BnoteL.TabIndex = 0;
            this.toolTip1.SetToolTip(this.BnoteL, "파일뷰어");
            this.BnoteL.UseVisualStyleBackColor = false;
            this.BnoteL.Click += new System.EventHandler(this.BnoteL_Click);
            // 
            // BnoteR
            // 
            this.BnoteR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BnoteR.AutoSize = true;
            this.BnoteR.BackColor = System.Drawing.Color.White;
            this.BnoteR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BnoteR.BackgroundImage")));
            this.BnoteR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BnoteR.FlatAppearance.BorderSize = 0;
            this.BnoteR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BnoteR.Location = new System.Drawing.Point(723, 296);
            this.BnoteR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BnoteR.Name = "BnoteR";
            this.BnoteR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BnoteR.Size = new System.Drawing.Size(247, 242);
            this.BnoteR.TabIndex = 0;
            this.toolTip2.SetToolTip(this.BnoteR, "생각노트");
            this.BnoteR.UseVisualStyleBackColor = false;
            this.BnoteR.Click += new System.EventHandler(this.BnoteR_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // toolTip2
            // 
            this.toolTip2.BackColor = System.Drawing.SystemColors.HotTrack;
            // 
            // C_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1256, 659);
            this.Controls.Add(this.BnoteL);
            this.Controls.Add(this.BnoteR);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "C_main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "성교수의 생각노트";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BnoteL;
        private System.Windows.Forms.Button BnoteR;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}