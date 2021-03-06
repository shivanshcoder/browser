using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;

namespace Browser
{
    public partial class DownloadControl : Form
    {

        public IDownloadItemCallback callback;

        public int id;
        bool paused = false;
        public DownloadControl(int id, string filename)
        {
            InitializeComponent();
            this.filename.Text = filename;
            this.id = id;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void DownloadControl_Load(object sender, EventArgs e)
        {

        }

        public void updateVals(int percent, IDownloadItemCallback callback)
        {
            
            this.callback = callback;
            progressBar1.Value = percent;
            if (percent == 100)
            {
                MessageBox.Show( "File Downloaded", "Success", MessageBoxButtons.OK);
                this.Close();
            }
            progressBar1.Maximum = 100;
            percentage.Text = percent.ToString();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            if (paused)
            {
                callback.Resume();
                this.pause.Text = "Pause";
            }
            else
            {
                callback.Pause();
                this.pause.Text = "Resume";
            }
            paused = paused ^ true;
        }

        private void hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            callback.Cancel();
            this.Close();
        }
    }
}
