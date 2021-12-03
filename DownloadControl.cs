using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class DownloadControl : Form
    {
        public int id;
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

        public void updateVals(int percent)
        {
            progressBar1.Value = percent;
            progressBar1.Maximum = 100;
            percentage.Text = percent.ToString();
        }
    }
}
