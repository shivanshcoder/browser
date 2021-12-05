
namespace Browser
{
    partial class frameBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frameBrowser));
            this.panelBody = new System.Windows.Forms.Panel();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lockIcon = new System.Windows.Forms.Button();
            this.textURL = new System.Windows.Forms.TextBox();
            this.browser_panel = new System.Windows.Forms.Panel();
            this.panelBody.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.downloadBtn);
            this.panelBody.Controls.Add(this.refreshBtn);
            this.panelBody.Controls.Add(this.forwardBtn);
            this.panelBody.Controls.Add(this.backBtn);
            this.panelBody.Controls.Add(this.panel4);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(947, 58);
            this.panelBody.TabIndex = 1;
            // 
            // downloadBtn
            // 
            this.downloadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.downloadBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("downloadBtn.BackgroundImage")));
            this.downloadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downloadBtn.FlatAppearance.BorderSize = 0;
            this.downloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadBtn.Location = new System.Drawing.Point(905, 12);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(30, 33);
            this.downloadBtn.TabIndex = 4;
            this.downloadBtn.UseVisualStyleBackColor = false;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.refreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshBtn.BackgroundImage")));
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Location = new System.Drawing.Point(84, 12);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(30, 33);
            this.refreshBtn.TabIndex = 2;
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // forwardBtn
            // 
            this.forwardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.forwardBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forwardBtn.BackgroundImage")));
            this.forwardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forwardBtn.FlatAppearance.BorderSize = 0;
            this.forwardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardBtn.Location = new System.Drawing.Point(48, 12);
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(30, 33);
            this.forwardBtn.TabIndex = 1;
            this.forwardBtn.UseVisualStyleBackColor = false;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(30, 33);
            this.backBtn.TabIndex = 0;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.lockIcon);
            this.panel4.Controls.Add(this.textURL);
            this.panel4.Location = new System.Drawing.Point(125, 12);
            this.panel4.Margin = new System.Windows.Forms.Padding(30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(772, 33);
            this.panel4.TabIndex = 0;
            // 
            // lockIcon
            // 
            this.lockIcon.BackColor = System.Drawing.Color.Transparent;
            this.lockIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lockIcon.BackgroundImage")));
            this.lockIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lockIcon.FlatAppearance.BorderSize = 0;
            this.lockIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lockIcon.Location = new System.Drawing.Point(3, 7);
            this.lockIcon.Name = "lockIcon";
            this.lockIcon.Size = new System.Drawing.Size(20, 22);
            this.lockIcon.TabIndex = 5;
            this.lockIcon.UseVisualStyleBackColor = false;
            // 
            // textURL
            // 
            this.textURL.AcceptsTab = true;
            this.textURL.AccessibleName = "";
            this.textURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textURL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textURL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.textURL.BackColor = System.Drawing.Color.Gray;
            this.textURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textURL.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textURL.Font = new System.Drawing.Font("Leelawadee UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textURL.Location = new System.Drawing.Point(31, 3);
            this.textURL.Margin = new System.Windows.Forms.Padding(5);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(722, 26);
            this.textURL.TabIndex = 0;
            this.textURL.Text = "Enter Address";
            this.textURL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textURL_MouseClick);
            this.textURL.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textURL_KeyUp);
            // 
            // browser_panel
            // 
            this.browser_panel.BackColor = System.Drawing.Color.Gray;
            this.browser_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser_panel.Location = new System.Drawing.Point(0, 58);
            this.browser_panel.Name = "browser_panel";
            this.browser_panel.Size = new System.Drawing.Size(947, 475);
            this.browser_panel.TabIndex = 3;
            // 
            // frameBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(947, 533);
            this.Controls.Add(this.browser_panel);
            this.Controls.Add(this.panelBody);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frameBrowser";
            this.Text = "frameBrowser";
            this.panelBody.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel browser_panel;
        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button forwardBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.Button lockIcon;
    }
}