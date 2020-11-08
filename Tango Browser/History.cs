using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;


namespace Tango_Browser
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            MongoClient dbClient = new MongoClient("mongodb://localhost:27017/");
            IMongoDatabase db = dbClient.GetDatabase("TangoBrowser");
            var hist = db.GetCollection<BsonDocument>("History");
            var filter = Builders<BsonDocument>.Filter.Eq("user_id", "1");

            var doc = hist.Find(filter).ToList();
            foreach (BsonDocument docu in doc)
            {
                Console.WriteLine(docu.ToString());
                histList.Items.Add(docu.GetValue("url").ToString());
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void but_hist_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MongoClient dbClient = new MongoClient("mongodb://localhost:27017/");
            IMongoDatabase db = dbClient.GetDatabase("TangoBrowser");
            db.DropCollection("History");
            MessageBox.Show("History Cleared");
            histList.Items.Clear();
            
        }
    }
}
