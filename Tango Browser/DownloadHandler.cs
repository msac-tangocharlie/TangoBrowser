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

       
        private Label _label;
         private PictureBox _picout,_picin;
        private int len;
        public DownloadHandler( Label label,PictureBox picout,PictureBox picin)
        {
            
            _label = label;
            _picout = picout;
            _picin = picin;
            len = picin.Height;
            
        }
      


        public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {

            _label.Visible = true;
            _picin.Visible = true;
            _picout.Visible = true;
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
            _label.Text = downloadItem.PercentComplete.ToString() + "%";
            
            _picin.Height = len-(downloadItem.PercentComplete * len)/100;
            
       
            if (downloadItem.IsComplete) { 
                _label.Text = "100%";
                MessageBox.Show("Download Finished");
            }
            
        }
    }
}