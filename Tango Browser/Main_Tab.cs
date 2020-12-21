using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;
using CefSharp;
using MongoDB.Driver;
using MongoDB.Bson;
using System.IO;
using System.Net;
using Tango_Browser.Properties;
using CefSharp.Example.Handlers;


namespace Tango_Browser
{
    public partial class Main_Tab : Form
    {
        MongoClient dbClient = new MongoClient("mongodb://localhost:27017/");
        //String homepageUrl = "System.IO.Path.GetFullPath("index.html")";


        public Main_Tab()
        {
            InitializeComponent();
            RequestContextSettings req = new RequestContextSettings();
            req.CachePath = "";
            req.PersistSessionCookies = false;
            incogBrowse = new CefSharp.WinForms.ChromiumWebBrowser("www.google.com");
            incogBrowse.RequestContext = new RequestContext(req);

            // chromiumBrowser.Load("www.google.com");
            // chromiumBrowser.LoadUrlWithPostData(System.IO.Path.GetFullPath("index.html"));
            chromiumBrowser.Load(System.IO.Path.GetFullPath("index.html"));
            panel2.Controls.Add(chromiumBrowser);
            chromiumBrowser.Parent = panel2;
            chromiumBrowser.Dock = DockStyle.Fill;
            chromiumBrowser.MenuHandler = new MyCustomMenuHandler();
            chromiumBrowser.DownloadHandler = new DownloadHandler(downPercent,pictureBox5,pictureBox7);
            chromiumBrowser.LifeSpanHandler = new MyLifeHandler();
            chromiumBrowser.Load("about:blank");
            Address_textBox.Text = chromiumBrowser.Address;
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void Address_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && Address_textBox.Text.Contains(".") && !Address_textBox.Text.Contains(" ") && Address_textBox.Text.Length > 0)
            {
                if (inco==1)
                {
                    incogBrowse.Load(Address_textBox.Text);
                }
                else
                {
                    chromiumBrowser.Load(Address_textBox.Text);
                }

            }
            else if (e.KeyData == Keys.Enter)
            {
                if (inco==1)
                {
                    incogBrowse.Load("https://www.google.com/search?q=" + Address_textBox.Text.Replace(" ", "+"));
                }
                else
                {
                    chromiumBrowser.Load("https://www.google.com/search?q=" + Address_textBox.Text.Replace(" ", "+"));
                }
                
            }
            faviconLoaded = false;
        }

        private bool faviconLoaded = false;

        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }
       
        private void Pic_back_Click(object sender, EventArgs e)
        {
            if (inco==1)
            {
                if (incogBrowse.CanGoBack) incogBrowse.Back();
            }
            else if (chromiumBrowser.CanGoBack) chromiumBrowser.Back();
        }

        private void Pic_forward_Click(object sender, EventArgs e)
        {
            if (inco==1)
            {
                if (incogBrowse.CanGoForward) incogBrowse.Forward();
            }
            else if (chromiumBrowser.CanGoForward) chromiumBrowser.Forward();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (inco==1)
            {
                incogBrowse.Load("www.google.com");
            }
            else
            {
                chromiumBrowser.Load("www.google.com");
            }
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
                var star = db.GetCollection<BsonDocument>("Pinned");
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
                IMongoDatabase db = dbClient.GetDatabase("TangoBrowser");
                var pinif = db.GetCollection<BsonDocument>("Pinned");
                var filter = Builders<BsonDocument>.Filter.Eq("url", Address_textBox.Text);
                pinif.DeleteOne(filter);
                Pic_pin.Image = Resources.pin;
                pinned = false;
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            if(inco==0) chromiumBrowser.Load(Address_textBox.Text);
            else incogBrowse.Load(Address_textBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            findbox.Visible = false;
            if (inco == 0) chromiumBrowser.StopFinding(true);
            else incogBrowse.StopFinding(true);
            
        }

        private void but_Find_Click(object sender, EventArgs e)
        {
            Find(true);
        }
        private void Find(bool next)
        {
            if (!string.IsNullOrEmpty(find_textbox.Text))
            {
                if(inco==0) chromiumBrowser.Find(0, find_textbox.Text, next, false, true);
                else incogBrowse.Find(0, find_textbox.Text, next, false, true);
            }
        }

        private void find_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            Find(true);
        }

        private void find_next_Click(object sender, EventArgs e)
        {
            Find(true);
        }

        private void find_prev_Click(object sender, EventArgs e)
        {
            Find(false);
        }

        private void Address_textBox_Click(object sender, EventArgs e)
        {
            Address_textBox.SelectAll();
        }

       
        
        private async void chromiumBrowser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            Address_textBox.Text = chromiumBrowser.Address;
            if (e.IsLoading)
            {
                await Task.Delay(50);
                int val= siteLoading.Value + siteLoading.Value / 2;
                if (val <= 100) siteLoading.Value = val;
            }
        }

        private void chromiumBrowser_FrameLoadEnd_1(object sender, FrameLoadEndEventArgs e)
        {
            siteLoading.Value = 100;
            Address_textBox.Text = chromiumBrowser.Address;
            Pic_load.Image = Resources.refresh;
            IMongoDatabase db = dbClient.GetDatabase("TangoBrowser");
            var pinif = db.GetCollection<BsonDocument>("Pinned");
            var filter = Builders<BsonDocument>.Filter.Eq("url", Address_textBox.Text);
            if (pinif.CountDocuments(filter) != 0)
            {
                Pic_pin.Image = Resources.pinned;
                pinned = true;
            }
            

        }

        private void chromiumBrowser_FrameLoadStart(object sender, FrameLoadStartEventArgs e)
        {
            Pic_load.Image = Resources.cancel;
            siteLoading.Value = 40;
        }

        private void chromiumBrowser_TitleChanged_1(object sender, TitleChangedEventArgs e)
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

        private void chromiumBrowser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            Invoke(new Action(() => Address_textBox.Text = e.Address));
            Pic_pin.Image = Resources.pin;
            pinned = false;
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
                        /*Invoke(new Action(() => Icon = Resources.DefaultIcon));*/
                    }
                }

                Invoke(new Action(() => Parent.Refresh()));
                faviconLoaded = true;
            }
        }


        private void incogBrowse_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            Invoke(new Action(() => Address_textBox.Text = e.Address));
            Console.WriteLine("Reached here");
            Pic_pin.Image = Resources.pin;
            pinned = false;
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
                        /*Invoke(new Action(() => Icon = Resources.DefaultIcon));*/
                    }
                }

                Invoke(new Action(() => Parent.Refresh()));
                faviconLoaded = true;
            }
        }

        private void incogBrowse_FrameLoadStart(object sender, FrameLoadStartEventArgs e)
        {
            Address_textBox.Text = incogBrowse.Address;
            Pic_load.Image = Resources.cancel;
            siteLoading.Value = 40;
        }

        private void incogBrowse_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            siteLoading.Value = 100;
            Address_textBox.Text = incogBrowse.Address;
            Pic_load.Image = Resources.refresh;
        }

        private async void incogBrowse_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            
            if (e.IsLoading)
            {
                await Task.Delay(50);
                int val = siteLoading.Value + siteLoading.Value / 2;
                if (val <= 100) siteLoading.Value = val;
            }
        }
        int panel = 0;
        private void pictureBox4_Click_2(object sender, EventArgs e)
        {
            if (panel==0)
            {
                pictureBox4.Image = Resources.on1;
                panel = 1;
                panel1.Visible = true;
                panel2.Padding = new Padding(60, 0, 0, 0);
            }
            else
            {
                pictureBox4.Image = Resources.off;
                panel = 0;
                panel1.Visible = false;
                panel2.Padding = new Padding(0, 0, 0, 0);
            }
        }
        int inco = 0;
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (inco==0)
            {
                pictureBox6.Image = Resources.IncognitoOn;
                inco = 1;
                incogBrowse.Load(chromiumBrowser.Address);
                panel2.Controls.Remove(chromiumBrowser);
                panel2.Controls.Add(incogBrowse);
            }
            else
            {
                pictureBox6.Image = Resources.Incognito;
                inco = 0;
                chromiumBrowser.Load(incogBrowse.Address);
                panel2.Controls.Remove(incogBrowse);
                panel2.Controls.Add(chromiumBrowser);
            }
        }


        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (inco == 0)
            {
                chromiumBrowser.ShowDevTools();
            }
            else
            {
                incogBrowse.ShowDevTools();
            }
        }
     
        int ischrome;
        
        private void pictureBox9_Click(object sender, EventArgs e)
        {


            if (!(panel2.Contains(histListt)))
            {
                histListt.Visible = true;
                Address_textBox.Text = "History";
                histListt.Items.Clear();
                histListt.GridLines = false;
                histListt.View = System.Windows.Forms.View.List;
                panel2.Padding = new Padding(70, 15, 10, 10);
                IMongoDatabase db = dbClient.GetDatabase("TangoBrowser");
                var hist = db.GetCollection<BsonDocument>("History");
                var filter = Builders<BsonDocument>.Filter.Eq("user_id", "1");
                var doc = hist.Find(filter).ToList();
                foreach (BsonDocument docu in doc)
                {
                    histListt.Items.Add(docu.GetValue("url").ToString());
                    
                }
                if (panel2.Contains(incogBrowse))
                {
                    ischrome = 1;
                    panel2.Controls.Remove(incogBrowse);
                    panel2.Controls.Add(histListt);
                }
                if (panel2.Controls.Contains(chromiumBrowser))
                {
                    ischrome = 0;
                    panel2.Controls.Remove(chromiumBrowser);
                    panel2.Controls.Add(histListt);
                }
                if (panel2.Controls.Contains(pinnedList))
                {
                    
                    panel2.Controls.Remove(pinnedList);
                    panel2.Controls.Add(histListt);
                }
                histListt.Dock = DockStyle.Fill;
            }
            else
            {
                panel2.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
                panel2.Controls.Remove(histListt);
                if (ischrome != 1)
                {
                    Address_textBox.Text = chromiumBrowser.Address;
                    panel2.Controls.Add(chromiumBrowser);
                }
                else
                {
                    Address_textBox.Text = incogBrowse.Address;
                    panel2.Controls.Add(incogBrowse);
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (findbox.Visible)
            {
                findbox.Visible = false;
                if (inco == 0) chromiumBrowser.StopFinding(true);
                else incogBrowse.StopFinding(true);
            }
            else findbox.Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FormBackGround = colorDlg.Color;
                Properties.Settings.Default.Save();
                this.BackColor = colorDlg.Color;
            }
        }

        private void clearHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IMongoDatabase db = dbClient.GetDatabase("TangoBrowser");
            db.DropCollection("History");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            settingBox.Padding = new Padding(0, 0, 0, 0);
            settingBox.Visible=false;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (settingBox.Visible)
            {
                settingBox.Padding = new Padding(0, 0, 0, 0);
                settingBox.Visible = false;
            }
            else 
                settingBox.Visible = true;
        }
        /*ListView pinnedList = new ListView();*/
        
        
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            
            if (!(panel2.Contains(pinnedList)))
            {
                Address_textBox.Text = "Pinned Pages";
                pinnedList.Items.Clear();
                pinnedList.GridLines = false;
                pinnedList.Visible = true;
                pinnedList.View = System.Windows.Forms.View.List;
                panel2.Padding = new Padding(70, 15, 10, 10);
                IMongoDatabase db = dbClient.GetDatabase("TangoBrowser");
                var pin = db.GetCollection<BsonDocument>("Pinned");
                var filter = Builders<BsonDocument>.Filter.Eq("user_id", "1");
                var doc = pin.Find(filter).ToList();
                foreach (BsonDocument docu in doc)
                {
                    pinnedList.Items.Add(docu.GetValue("url").ToString());
                }
                if (panel2.Contains(incogBrowse))
                {
                    ischrome = 1;
                    panel2.Controls.Remove(incogBrowse);
                    panel2.Controls.Add(pinnedList);
                }
                if (panel2.Controls.Contains(chromiumBrowser))
                {
                    ischrome = 0;
                    panel2.Controls.Remove(chromiumBrowser);
                    panel2.Controls.Add(pinnedList);
                }
                if (panel2.Controls.Contains(histListt))
                {

                    panel2.Controls.Remove(histListt);
                    panel2.Controls.Add(pinnedList);
                }
                pinnedList.Dock = DockStyle.Fill;
            }
            else
            {
                panel2.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
                
                panel2.Controls.Remove(pinnedList);
                if (ischrome != 1)
                {
                    
                    Address_textBox.Text = chromiumBrowser.Address;
                    panel2.Controls.Add(chromiumBrowser);
                }
                else
                {
                    
                    Address_textBox.Text = incogBrowse.Address;
                    panel2.Controls.Add(incogBrowse);
                }
            }
        }
        
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            
        }

        private void pinnedList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (ischrome != 1)
            {
                chromiumBrowser.Load(e.Item.Text);
                panel2.Controls.Remove(pinnedList);
                panel2.Controls.Add(chromiumBrowser);
            }
            else
            {
                incogBrowse.Load(e.Item.Text);
                panel2.Controls.Remove(pinnedList);
                panel2.Controls.Add(incogBrowse);
            }
           
        }

        private void histListt_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (ischrome != 1)
            {
                chromiumBrowser.Load(e.Item.Text);
                panel2.Controls.Remove(histListt);
                panel2.Controls.Add(chromiumBrowser);
            }
            else
            {
                incogBrowse.Load(e.Item.Text);
                panel2.Controls.Remove(histListt);
                panel2.Controls.Add(incogBrowse);
            }
        }
    }
}
