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
    public partial class DownloadControl : UserControl
    {
        public DownloadControl()
        {
            InitializeComponent();
        }

        private void DownloadControl_Load(object sender, EventArgs e)
        {

        }

        public void updateVals(int percent)
        {
            progressBar1.Value = percent;
            progressBar1.Maximum = 100;
        }
    }
}
