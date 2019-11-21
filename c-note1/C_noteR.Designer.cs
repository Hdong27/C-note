namespace c_note1
{
    partial class C_noteR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C_noteR));
            this.BnoteT = new System.Windows.Forms.Button();
            this.BnoteP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BnoteT
            // 
            this.BnoteT.BackColor = System.Drawing.SystemColors.Info;
            this.BnoteT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BnoteT.BackgroundImage")));
            this.BnoteT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BnoteT.Location = new System.Drawing.Point(137, 149);
            this.BnoteT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BnoteT.Name = "BnoteT";
            this.BnoteT.Size = new System.Drawing.Size(174, 148);
            this.BnoteT.TabIndex = 0;
            this.BnoteT.UseVisualStyleBackColor = false;
            this.BnoteT.Click += new System.EventHandler(this.button1_Click);
            // 
            // BnoteP
            // 
            this.BnoteP.BackColor = System.Drawing.Color.Khaki;
            this.BnoteP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BnoteP.BackgroundImage")));
            this.BnoteP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BnoteP.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BnoteP.Location = new System.Drawing.Point(517, 155);
            this.BnoteP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BnoteP.Name = "BnoteP";
            this.BnoteP.Size = new System.Drawing.Size(153, 142);
            this.BnoteP.TabIndex = 1;
            this.BnoteP.UseVisualStyleBackColor = false;
            this.BnoteP.Click += new System.EventHandler(this.button2_Click);
            // 
            // C_noteR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::c_note1.Properties.Resources.cb26b9edcc7ea1370b4721751ad00159;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BnoteP);
            this.Controls.Add(this.BnoteT);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "C_noteR";
            this.Text = "c-note";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BnoteT;
        private System.Windows.Forms.Button BnoteP;
    }
}

