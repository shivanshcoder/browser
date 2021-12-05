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
    public partial class DownloadWindow : Form
    {

        private Dictionary<int, DownloadControl> download_controls;

        private Dictionary<int, DownloadItem> items_list;

        public DownloadWindow(Dictionary<int, DownloadItem> items)
        {
            InitializeComponent();
            items_list = items;
        }

        public void add_download(DownloadItem downloadItem)
        {

        }

        public void update_values(DownloadItem downloadItem)
        {

        }
    }
}
