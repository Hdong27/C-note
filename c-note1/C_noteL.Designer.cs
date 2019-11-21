namespace c_note1
{
    partial class C_noteL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C_noteL));
            this.Bpdf = new System.Windows.Forms.Button();
            this.Bms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bpdf
            // 
            this.Bpdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bpdf.BackgroundImage")));
            this.Bpdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bpdf.Location = new System.Drawing.Point(179, 187);
            this.Bpdf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bpdf.Name = "Bpdf";
            this.Bpdf.Size = new System.Drawing.Size(170, 162);
            this.Bpdf.TabIndex = 0;
            this.Bpdf.UseVisualStyleBackColor = true;
            this.Bpdf.Click += new System.EventHandler(this.Bpdf_Click);
            // 
            // Bms
            // 
            this.Bms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bms.BackgroundImage")));
            this.Bms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bms.Location = new System.Drawing.Point(584, 195);
            this.Bms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bms.Name = "Bms";
            this.Bms.Size = new System.Drawing.Size(179, 154);
            this.Bms.TabIndex = 0;
            this.Bms.UseVisualStyleBackColor = true;
            this.Bms.Click += new System.EventHandler(this.Bms_Click);
            // 
            // C_noteL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::c_note1.Properties.Resources.cb26b9edcc7ea1370b4721751ad00159;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.Bms);
            this.Controls.Add(this.Bpdf);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "C_noteL";
            this.Text = "File viewer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bpdf;
        private System.Windows.Forms.Button Bms;
    }
}