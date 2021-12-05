using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace Browser.Helpers
{
    class BrowserMenuHandler: IContextMenuHandler
    {

        private static Regex rgx = new Regex(@"http(s?):\/\/((www.)?)youtu(\.?)be((.com)?)\/(.{1,})");
        public void OnBeforeContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
        {

            // You can add a separator in case that there are more items on the list

            if (rgx.IsMatch(browserControl.Address))
            {
                if (model.Count > 0)
                {
                    model.AddSeparator();
                }
                model.AddItem((CefMenuCommand)26501, "Download Video");
            }
        }

        public bool OnContextMenuCommand(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
        {
            if (commandId == (CefMenuCommand)26501)
            {
                YTDownloader downloader = new YTDownloader(browserControl.Address);
                downloader.Show();
                return true;
            }

            return false;
        }

        public void OnContextMenuDismissed(IWebBrowser browserControl, IBrowser browser, IFrame frame)
        {

        }

        public bool RunContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
        {
            return false;
        }
    }
}
