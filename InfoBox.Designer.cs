
namespace RemoveInternet3
{
    partial class InfoBox
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
            this.infoText_lbl = new System.Windows.Forms.Label();
            this.copyTextInfo_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoText_lbl
            // 
            this.infoText_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText_lbl.Location = new System.Drawing.Point(12, 9);
            this.infoText_lbl.Name = "infoText_lbl";
            this.infoText_lbl.Size = new System.Drawing.Size(325, 282);
            this.infoText_lbl.TabIndex = 0;
            this.infoText_lbl.Text = "infotext";
            // 
            // copyTextInfo_lbl
            // 
            this.copyTextInfo_lbl.AutoSize = true;
            this.copyTextInfo_lbl.Location = new System.Drawing.Point(12, 291);
            this.copyTextInfo_lbl.Name = "copyTextInfo_lbl";
            this.copyTextInfo_lbl.Size = new System.Drawing.Size(132, 13);
            this.copyTextInfo_lbl.TabIndex = 1;
            this.copyTextInfo_lbl.Text = "Double click text to copy it";
            // 
            // InfoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 313);
            this.Controls.Add(this.copyTextInfo_lbl);
            this.Controls.Add(this.infoText_lbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "InfoBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label copyTextInfo_lbl;
        public System.Windows.Forms.Label infoText_lbl;
    }
}