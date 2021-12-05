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
using System.Text.RegularExpressions;
using Browser.Helpers;

namespace Browser
{
    public partial class frameBrowser : Form
    {
        static DownloadHandler static_download = new DownloadHandler();

        public ChromiumWebBrowser browser;

        // Used for checking if the url is a website or a search query
        static private Regex urlRgx = new Regex(@"[(http(s)?):\/\/(www\.)?a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)");

        public frameBrowser()
        {
            
            InitializeComponent();
            InitializeChromium();

        }

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();

            if(!Cef.IsInitialized)
                Cef.Initialize(settings);

            browser = new ChromiumWebBrowser("https://google.com");

            browser.MenuHandler = new BrowserMenuHandler();

            browser.DownloadHandler = static_download;

            

            browser_panel.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;

            browser.LoadingStateChanged += Browser_LoadingStateChanged;
        }

        private void Browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            // Update the browser address after loading
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
            //if (url.StartsWith("http"))
            if(urlRgx.IsMatch(url))
            {
                s = url;
            }
            else
            {
                s = $"https://www.google.com/search?q={url}";
            }
            browser.Load(s);
        }

        // On click of URL text box
        private void textURL_MouseClick(object sender, MouseEventArgs e)
        {
            // Select the URL text
            if (!String.IsNullOrEmpty(textURL.Text))
            {
                textURL.SelectionStart = 0;
                textURL.SelectionLength = textURL.Text.Length;
            }
        }

        // Shows all the downloads
        private void downloadBtn_Click(object sender, EventArgs e)
        {
            static_download.showAll();
        }


       

        // Browser Go Back
        private void backBtn_Click(object sender, EventArgs e)
        {
            if (browser.CanGoBack)
            {
                browser.Back();
            }
        }

        // Browser Go Forward
        private void forwardBtn_Click(object sender, EventArgs e)
        {
            if (browser.CanGoForward)
            {
                browser.Forward();
            }
        }

        // Page Refresh
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            browser.Reload();
        }
    }
}
