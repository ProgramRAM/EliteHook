namespace EliteHook
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.txtCredit = new System.Windows.Forms.Label();
            this.txtProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCredit
            // 
            this.txtCredit.AutoSize = true;
            this.txtCredit.BackColor = System.Drawing.Color.Transparent;
            this.txtCredit.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.txtCredit.ForeColor = System.Drawing.Color.Gray;
            this.txtCredit.Location = new System.Drawing.Point(12, 9);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(126, 19);
            this.txtCredit.TabIndex = 2;
            this.txtCredit.Text = "github.com/EliteAPI";
            // 
            // txtProgress
            // 
            this.txtProgress.BackColor = System.Drawing.Color.Transparent;
            this.txtProgress.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.txtProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtProgress.Location = new System.Drawing.Point(12, 477);
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.Size = new System.Drawing.Size(527, 40);
            this.txtProgress.TabIndex = 3;
            this.txtProgress.Text = "EliteHook by Somfic";
            this.txtProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 546);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.txtCredit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliteHook";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCredit;
        private System.Windows.Forms.Label txtProgress;
    }
}

