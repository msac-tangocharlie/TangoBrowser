// Copyright © 2013 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System;

using System.Windows.Forms;

namespace CefSharp.Example.Handlers
{
    public class DownloadHandler : IDownloadHandler
    {
        public event EventHandler<DownloadItem> OnBeforeDownloadFired;

        public event EventHandler<DownloadItem> OnDownloadUpdatedFired;

        private ProgressBar _bar;
        private Label _label;
        public DownloadHandler(ProgressBar bar, Label label)
        {
            _bar = bar;
            _label = label;
        }
      


        public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            
            _bar.ForeColor= System.Drawing.Color.Yellow;
            _bar.Visible = true;

            OnBeforeDownloadFired?.Invoke(this, downloadItem);

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

            OnDownloadUpdatedFired?.Invoke(this, downloadItem);
            _bar.Value = downloadItem.PercentComplete;
            _label.Text = downloadItem.PercentComplete.ToString() + "%";

            /*_bar.Maximum = Convert.ToInt32(downloadItem.TotalBytes);
            _bar.Value = Convert.ToInt32(downloadItem.ReceivedBytes);*/
           /* if(_bar.Maximum>0)_label.Text = (_bar.Value / _bar.Maximum).ToString() + "%";*/
            if (downloadItem.IsComplete) { 
                      _bar.ForeColor = System.Drawing.Color.Green;
                _label.Text = "Finished";
            }
        }
    }
}