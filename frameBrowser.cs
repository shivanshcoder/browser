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
namespace Browser
{
    public partial class frameBrowser : Form
    {
        public frameBrowser()
        {
            InitializeComponent();
            InitializeChromium();
        }

        public ChromiumWebBrowser browser;

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();

            if(!Cef.IsInitialized)
                Cef.Initialize(settings);

            browser = new ChromiumWebBrowser("https://youtube.com");

            browser.DownloadHandler = new DownloadHandler(this);



            browser_panel.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;

            browser.LoadingStateChanged += Browser_LoadingStateChanged;
        }

        private void Browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textURL_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                loadURL(textURL.Text.Trim());
                //textURL.ForeColor = Color.Green;
            }
        }

        void loadURL(string url)
        {
            if (url.StartsWith("http"))
            {
                browser.Load(url);
            }
            else
            {
                browser.Load($"https://www.google.com/search?q={url}");
            }
        }

        private void textURL_MouseClick(object sender, MouseEventArgs e)
        {

            textURL.Text = "";
            //textURL.ForeColor = Color.Red;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
