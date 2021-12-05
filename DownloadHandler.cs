// Copyright © 2013 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Browser;

namespace CefSharp.Example.Handlers
{
    public class DownloadHandler : IDownloadHandler
    {
        public event EventHandler<DownloadItem> OnBeforeDownloadFired;

        public event EventHandler<DownloadItem> OnDownloadUpdatedFired;

        private Dictionary<int, DownloadControl> controls;

        private DownloadControl dc;
        public DownloadHandler()
        {
            controls = new Dictionary<int, DownloadControl>();
        }

        public void Form1_FormClosing(Object sender, FormClosedEventArgs e)
        {
            DownloadControl _dc = (DownloadControl)sender;
            if (!_dc.callback.IsDisposed)
                _dc.callback.Cancel();
            
            controls.Remove(_dc.id);
        }


        public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {

            OnBeforeDownloadFired?.Invoke(this, downloadItem);

            dc = new DownloadControl(downloadItem.Id, downloadItem.SuggestedFileName.ToString());

            controls.Add(downloadItem.Id, dc);
            dc.FormClosed += Form1_FormClosing;
            //dc.ControlBox = false;


            dc.Show();
            dc.BringToFront();
            dc.Activate();
            dc.TopMost = true;
           
            //controls[downloadItem.Id].Show();
            //f.Invoke(new Action(() =>
            //{

            //    f.Controls.Add(controls[downloadItem.Id]);

            //}
            //    ));



            if (!callback.IsDisposed)
            {
                using (callback)
                {
                    callback.Continue(downloadItem.SuggestedFileName, showDialog: true);
                }
            }
        }

        public void OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {

            if (controls.TryGetValue(downloadItem.Id, out _))
                controls[downloadItem.Id].Invoke(new Action(() =>
                {
                    controls[downloadItem.Id].updateVals(downloadItem.PercentComplete, callback);

                }));



            OnDownloadUpdatedFired?.Invoke(this, downloadItem);
        }


        public void showAll()
        {

            foreach (var item in controls.Keys)
            {
                controls[item].Invoke(new Action(()=>
                {
                    controls[item].Show();

                }));
            }

        }
        
    }
}