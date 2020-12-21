using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tango_Browser
{
    public partial class UserProfileSettings : Form
    {
        public UserProfileSettings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Username = UserName.Text;
            Properties.Settings.Default.Email = userEmailText.Text;
            Properties.Settings.Default.Save();
        }
    }
}
