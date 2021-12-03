
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
            this.speed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 61);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(342, 23);
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
            this.percentage.Location = new System.Drawing.Point(150, 61);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(62, 13);
            this.percentage.TabIndex = 2;
            this.percentage.Text = "Percentage";
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Location = new System.Drawing.Point(13, 36);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(38, 13);
            this.speed.TabIndex = 3;
            this.speed.Text = "Speed";
            // 
            // DownloadControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 96);
            this.Controls.Add(this.speed);
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
        private System.Windows.Forms.Label speed;
    }
}
