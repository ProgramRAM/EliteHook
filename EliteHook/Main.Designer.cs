namespace EliteHook
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.txtCommander = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUrl.Location = new System.Drawing.Point(12, 34);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(404, 25);
            this.txtUrl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "webhook url";
            // 
            // btnTest
            // 
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.btnTest.ForeColor = System.Drawing.Color.Gray;
            this.btnTest.Location = new System.Drawing.Point(276, 65);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(140, 36);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "send test message";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.btnToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnToggle.Location = new System.Drawing.Point(12, 304);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(98, 36);
            this.btnToggle.TabIndex = 5;
            this.btnToggle.Text = "turn on";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // txtCommander
            // 
            this.txtCommander.BackColor = System.Drawing.Color.Transparent;
            this.txtCommander.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.txtCommander.ForeColor = System.Drawing.Color.Gray;
            this.txtCommander.Location = new System.Drawing.Point(117, 12);
            this.txtCommander.Name = "txtCommander";
            this.txtCommander.Size = new System.Drawing.Size(299, 19);
            this.txtCommander.TabIndex = 6;
            this.txtCommander.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.txtLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLog.Location = new System.Drawing.Point(12, 107);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtLog.Size = new System.Drawing.Size(404, 191);
            this.txtLog.TabIndex = 7;
            this.txtLog.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(430, 349);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtCommander);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "EliteHook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Label txtCommander;
        private System.Windows.Forms.RichTextBox txtLog;
    }
}