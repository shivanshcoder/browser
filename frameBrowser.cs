using System;
using EasyTabs;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;
using CefSharp.Example.Handlers;

using Browser.Helpers;

namespace Browser
{
    public partial class frameBrowser : Form
    {
        static DownloadHandler static_download = new DownloadHandler();

        public ChromiumWebBrowser browser;
        public DownloadControl control_;


        //static List<Tuple<String, DateTime>> history;
        //static List<String> bookmarks;

        private Dictionary<int, DownloadControl> __controls;
        public frameBrowser()
        {
            __controls = new Dictionary<int, DownloadControl>();
            
            InitializeComponent();
            InitializeChromium();

            LoadHistory();
            LoadBookmarks();
        }

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();

            if(!Cef.IsInitialized)
                Cef.Initialize(settings);

            browser = new ChromiumWebBrowser("https://youtube.com");

            browser.MenuHandler = new BrowserMenuHandler();

            browser.DownloadHandler = static_download;

            

            browser_panel.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;

            browser.LoadingStateChanged += Browser_LoadingStateChanged;
        }

        private void Browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            // https://youtu.be/jn77B
            // https://www.youtube.com/watch?v=
            // Regex Pattern for youtube
            // http(s?):\/\/((www.)?)youtu(\.?)be
            // http(s ?):\/\/ ((www.) ?)youtu(\.?)be((.com) ?)\/ (.{ 1,})

            //if (rgx.IsMatch(browser.Address))
            //{
            //    contextMenuStrip.Enabled = true;
            //}
            //else
            //{
            //    contextMenuStrip.Enabled = true;
            //}
            this.Invoke((Action)delegate
            {
                textURL.Text = browser.Address;
            });
        }


        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }

        private void textURL_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                loadURL(textURL.Text.Trim());
            }
        }

        void loadURL(string url)
        {
            String s;
            if (url.StartsWith("http"))
            {
                s = url;
            }
            else
            {
                s = $"https://www.google.com/search?q={url}";
            }
            append_history(s);
            browser.Load(s);
        }

        void append_history(string url)
        {

        }

        void LoadHistory()
        {

        }

        void LoadBookmarks()
        {

        }

        private void textURL_MouseClick(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(textURL.Text))
            {
                textURL.SelectionStart = 0;
                textURL.SelectionLength = textURL.Text.Length;
            }
            //textURL.ForeColor = Color.Red;
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            static_download.showAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void downloadVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("DOWNLOAD THE DAMN VIDEO");
        }
    }
}
