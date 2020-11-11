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

namespace Tango_Browser
{
    public partial class Main_Tab : Form
    {
        MongoClient dbClient = new MongoClient("mongodb://localhost:27017/");
        public Main_Tab()
        {
            InitializeComponent();
            

            // Add the --enable-media-stream flag
            
            chromiumBrowser.Load("www.google.com");
            Address_textBox.Text = chromiumBrowser.Address;
            TextBox.CheckForIllegalCrossThreadCalls = false;

        }
        
        protected TitleBarTabs ParentsTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
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
        }

        private void but_go_Click(object sender, EventArgs e)
        {
            if ( Address_textBox.Text.Contains(".") && !Address_textBox.Text.Contains(" ") && Address_textBox.Text.Length > 0)
            {
                chromiumBrowser.Load(Address_textBox.Text);

            }
            else
            {
                chromiumBrowser.Load("https://www.google.com/search?q=" + Address_textBox.Text.Replace(" ", "+"));

            }
        }

        private void chromiumBrowser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            Address_textBox.Text = chromiumBrowser.Address;
            IMongoDatabase db = dbClient.GetDatabase("TangoBrowser");
            var hist = db.GetCollection<BsonDocument>("History");
            var doc = new BsonDocument
            {
                {"url", chromiumBrowser.Address},
                { "user_id","1"}
            };
            hist.InsertOne(doc);
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            if(chromiumBrowser.CanGoBack) chromiumBrowser.Back();
        }

        private void but_forward_Click(object sender, EventArgs e)
        {
            if(chromiumBrowser.CanGoForward) chromiumBrowser.Forward();
        }

        private void but_Home_Click(object sender, EventArgs e)
        {
            chromiumBrowser.Load("www.google.com");
        }

        private void but_refresh_Click(object sender, EventArgs e)
        {
            chromiumBrowser.Load(Address_textBox.Text);
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
            Starred starred=new Starred();
            starred.Tag = this;
            starred.Show(this);
        }

        private void chromiumBrowser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            Text = e.Title;
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Tag = this;
            history.Show(this);
            
        }

        private void starThisPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IMongoDatabase db = dbClient.GetDatabase("TangoBrowser");
            var star = db.GetCollection<BsonDocument>("Starred");
            var doc = new BsonDocument
            {
                {"url", chromiumBrowser.Address},
                { "user_id","1"}
            };
            star.InsertOne(doc);
            MessageBox.Show("Page is Starred");
        }
    }
}
