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

        private ProgressBar _bar;

        private Form f;

        private Dictionary<int, DownloadControl> controls;

        private DownloadControl dc;
        public DownloadHandler(Form ff)
        {
            f = ff;
            controls = new Dictionary<int, DownloadControl>();
        }



        public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {

            OnBeforeDownloadFired?.Invoke(this, downloadItem);

            dc = new DownloadControl(downloadItem.SuggestedFileName.ToString());

            controls.Add(downloadItem.Id, dc);
            dc.Show();
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

            //controls.Add(downloadItem.GetHashCode(), new DownloadControl());
            if (controls.TryGetValue(downloadItem.Id, out _))
                
                controls[downloadItem.Id].Invoke(new Action(() =>
                {
                    controls[downloadItem.Id].updateVals(downloadItem.PercentComplete);

                }));
            //controls[downloadItem.GetHashCode()].updateVals(downloadItem.PercentComplete);
            //_bar.Invoke(
            //    new Action(() =>
            //        {
            //        //Debug.Print(downloadItem);
            //        _bar.Value = downloadItem.PercentComplete;
            //        _bar.Maximum = (int)(100);
            //        }
            //));

            OnDownloadUpdatedFired?.Invoke(this, downloadItem);
        }

        
    }
}