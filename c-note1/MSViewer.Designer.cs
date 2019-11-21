namespace c_note1
{
    partial class MSViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSViewer));
            this.axWebBrowser1 = new AxSHDocVw.AxWebBrowser();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BmsOpen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWebBrowser1
            // 
            this.axWebBrowser1.Enabled = true;
            this.axWebBrowser1.Location = new System.Drawing.Point(1, 23);
            this.axWebBrowser1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.axWebBrowser1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser1.OcxState")));
            this.axWebBrowser1.Size = new System.Drawing.Size(915, 542);
            this.axWebBrowser1.TabIndex = 0;
            this.axWebBrowser1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BmsOpen
            // 
            this.BmsOpen.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BmsOpen.FlatAppearance.BorderSize = 0;
            this.BmsOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BmsOpen.Location = new System.Drawing.Point(0, 0);
            this.BmsOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BmsOpen.Name = "BmsOpen";
            this.BmsOpen.Size = new System.Drawing.Size(79, 24);
            this.BmsOpen.TabIndex = 1;
            this.BmsOpen.Text = "Open";
            this.BmsOpen.UseVisualStyleBackColor = false;
            this.BmsOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.BmsOpen);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 24);
            this.panel1.TabIndex = 2;
            // 
            // MSViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axWebBrowser1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MSViewer";
            this.Text = "MS file viewer";
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser axWebBrowser1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BmsOpen;
        private System.Windows.Forms.Panel panel1;
    }
}