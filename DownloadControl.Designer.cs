
namespace Browser
{
    partial class DownloadControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.filename = new System.Windows.Forms.Label();
            this.percentage = new System.Windows.Forms.Label();
            this.pause = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 29);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(342, 32);
            this.progressBar1.TabIndex = 0;
            // 
            // filename
            // 
            this.filename.AutoSize = true;
            this.filename.Location = new System.Drawing.Point(13, 13);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(35, 13);
            this.filename.TabIndex = 1;
            this.filename.Text = "Name";
            // 
            // percentage
            // 
            this.percentage.AutoSize = true;
            this.percentage.Location = new System.Drawing.Point(147, 39);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(62, 13);
            this.percentage.TabIndex = 2;
            this.percentage.Text = "Percentage";
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(182, 71);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 23);
            this.pause.TabIndex = 3;
            this.pause.Text = "pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(279, 71);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // DownloadControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 106);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.progressBar1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DownloadControl";
            this.Load += new System.EventHandler(this.DownloadControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label filename;
        private System.Windows.Forms.Label percentage;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button cancel;
    }
}
