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
using CefSharp.WinForms;
using CefSharp;
using MongoDB.Driver;
using MongoDB.Bson;
using CefSharp.Wpf;
using CefSharp.DevTools.Network;
using System.IO;
using System.Net;
using Tango_Browser.Properties;

namespace Tango_Browser
{
    public partial class Main_Tab : Form
    {
        MongoClient dbClient = new MongoClient("mongodb://localhost:27017/");

        public Main_Tab()
        {
            InitializeComponent();


            // Add the --enable-media-stream flag


            chromiumBrowser.Load("about:blank");

            Address_textBox.Text = chromiumBrowser.Address;
            TextBox.CheckForIllegalCrossThreadCalls = false;

        }

        private void Address_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && Address_textBox.Text.Contains(".") && !Address_textBox.Text.Contains(" ") && Address_textBox.Text.Length > 0)
            {
                chromiumBrowser.Load(Address_textBox.Text);

            }
            else if (e.KeyData == Keys.Enter)
            {
                chromiumBrowser.Load("https://www.google.com/search?q=" + Address_textBox.Text.Replace(" ", "+"));
            }
            faviconLoaded = false;
        }

        private void chromiumBrowser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            Address_textBox.Text = chromiumBrowser.Address;
            Pic_load.Image = Resources.refresh;

        }

        private void printThisPageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            chromiumBrowser.Print();
        }

        private void inspectElementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumBrowser.ShowDevTools();
        }

        private void starredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Starred starred = new Starred();
            starred.Tag = this;
            starred.Show(this);
        }

        private void chromiumBrowser_TitleChanged(object sender, TitleChangedEventArgs e)
        {

            if (Text != e.Title)
            {
                Text = e.Title;
                if (Text != "about:blank")
                {
                    IMongoDatabase db = dbClient.GetDatabase("TangoBrowser");
                    var hist = db.GetCollection<BsonDocument>("History");
                    var doc = new BsonDocument
                    {
                        {"url", chromiumBrowser.Address},
                        { "user_id","1"}
                    };
                    hist.InsertOne(doc);
                }
            }

        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* History history = new History();
             history.Tag = this;
             history.Show(this);*/
            AppContainer container = new AppContainer();
            container.Tabs.Add(
                    new TitleBarTab(container)
                    {
                        Content = new History
                        {
                            Text = "History"
                        }
                    }
                );
            container.SelectedTabIndex = 0;

            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(container);
        }

        private void Main_Tab_Load(object sender, EventArgs e)
        {

        }
        private bool faviconLoaded = false;

        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }
        private void chromiumBrowser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            Invoke(new Action(() => Address_textBox.Text = e.Address));

            if (e.Address != "about.blank" && !faviconLoaded)
            {
                Uri uri = new Uri(e.Address);

                if (uri.Scheme == "http" || uri.Scheme == "https")
                {
                    try
                    {
                        HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(uri.Scheme + "://" + uri.Host + "/favicon.ico");
                        webRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.83 Safari/537.36";
                        webRequest.KeepAlive = false;
                        webRequest.AllowAutoRedirect = true;

                        WebResponse response = webRequest.GetResponse();
                        Stream stream = response.GetResponseStream();

                        if (stream != null)
                        {
                            byte[] buffer = new byte[1024];

                            using (MemoryStream ms = new MemoryStream())
                            {
                                int read;

                                while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                                    ms.Write(buffer, 0, read);

                                ms.Seek(0, SeekOrigin.Begin);

                                Invoke(new Action(() =>
                                {
                                    Icon = new Icon(ms);

                                    ParentTabs.UpdateThumbnailPreviewIcon(ParentTabs.Tabs.Single(t => t.Content == this));
                                    ParentTabs.RedrawTabs();
                                }));
                            }
                        }
                    }

                    catch
                    {
                        Invoke(new Action(() => Icon = Resources.DefaultIcon));
                    }
                }

                Invoke(new Action(() => Parent.Refresh()));
                faviconLoaded = true;
            }
        }

        private void Pic_back_Click(object sender, EventArgs e)
        {
            if (chromiumBrowser.CanGoBack) chromiumBrowser.Back();
        }

        private void Pic_forward_Click(object sender, EventArgs e)
        {
            if (chromiumBrowser.CanGoBack) chromiumBrowser.Forward();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            chromiumBrowser.Load("www.google.com");
        }



        private void Pic_back_MouseEnter(object sender, EventArgs e)
        {
            Pic_back.BackgroundImage = Resources.ButtonHoverBackground;
        }

        private void Pic_back_MouseLeave(object sender, EventArgs e)
        {
            Pic_back.BackgroundImage = null;

        }

        private void Pic_forward_MouseLeave(object sender, EventArgs e)
        {
            Pic_forward.BackgroundImage = null;
        }

        private void Pic_forward_MouseEnter(object sender, EventArgs e)
        {
            Pic_forward.BackgroundImage = Resources.ButtonHoverBackground;
        }

        private void Pic_home_MouseEnter(object sender, EventArgs e)
        {
            Pic_home.BackgroundImage = Resources.ButtonHoverBackground;
        }

        private void Pic_home_MouseLeave(object sender, EventArgs e)
        {
            Pic_home.BackgroundImage = Resources.ButtonHoverBackground;
        }
        bool pinned = false;
        private void Pic_pin_Click(object sender, EventArgs e)
        {
            if (!pinned)
            {
                IMongoDatabase db = dbClient.GetDatabase("TangoBrowser");
                var star = db.GetCollection<BsonDocument>("Starred");
                var doc = new BsonDocument
            {
                {"url", chromiumBrowser.Address},
                { "user_id","1"}
            };
                star.InsertOne(doc);
                pinned = true;
                Pic_pin.Image = Resources.pinned;
            }
            else
            {
                Pic_pin.Image = Resources.pin;
                pinned = false;
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            chromiumBrowser.Load(Address_textBox.Text);
        }

        private void chromiumBrowser_FrameLoadStart(object sender, FrameLoadStartEventArgs e)
        {
            Pic_load.Image = Resources.cancel;
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            menuToolStripMenuItem.ShowDropDown();
        }

        private void backgorundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FormBackGround = colorDlg.Color;
                Properties.Settings.Default.Save();
                this.BackColor = colorDlg.Color;
                Menu.BackColor = colorDlg.Color;
               
                    IMongoDatabase db = dbClient.GetDatabase("TangoBrowser");
                    var colDlg = db.GetCollection<BsonDocument>("Background");
                    var doc = new BsonDocument
                        {
                           {"url", chromiumBrowser.Address},
                           { "user_id","1"}
                         };
                    colDlg.InsertOne(doc);
               

            }
        }
    }
}
