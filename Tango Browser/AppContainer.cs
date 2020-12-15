using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;
using CefSharp;
using CefSharp.WinForms;

namespace Tango_Browser
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();
           /* CefSharp.WinForms.CefSettings settings = new CefSharp.WinForms.CefSettings();
            settings.CefCommandLineArgs.Add("enable-media-stream", "1");
            settings.CefCommandLineArgs.Add("enable-silent-push", "1");
            settings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CEF";
            var _webViewSettings = new CefSettings();
            _webViewSettings.UserAgent = string.Format(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/{0} Mobile Safari/537.36", Cef.ChromiumVersion);


            Cef.Initialize(settings);*/
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);

        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new Main_Tab
                {
                    Text = "New Tab",
                    
                }
            };
        }
    }
}
