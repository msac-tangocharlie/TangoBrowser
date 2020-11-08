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
    public partial class Starred : Form
    {
        public Starred()
        {
            InitializeComponent();
            MongoClient dbClient = new MongoClient("mongodb://localhost:27017/");
            IMongoDatabase db = dbClient.GetDatabase("TangoBrowser");
            var star = db.GetCollection<BsonDocument>("Starred");
            var filter = Builders<BsonDocument>.Filter.Eq("user_id", "1");

            var doc = star.Find(filter).ToList();
            foreach (BsonDocument docu in doc)
            {
                Console.WriteLine(docu.ToString());
                starredList.Items.Add(docu.GetValue("url").ToString());
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
