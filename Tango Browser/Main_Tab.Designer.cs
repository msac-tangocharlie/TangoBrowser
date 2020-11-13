namespace Tango_Browser
{
    partial class Main_Tab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Tab));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printThisPageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inspectElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.chromiumBrowser = new CefSharp.WinForms.ChromiumWebBrowser();
            this.Pic_load = new System.Windows.Forms.PictureBox();
            this.Pic_pin = new System.Windows.Forms.PictureBox();
            this.Pic_home = new System.Windows.Forms.PictureBox();
            this.Pic_forward = new System.Windows.Forms.PictureBox();
            this.Pic_back = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_pin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_forward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(942, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(158, 450);
            this.Menu.TabIndex = 5;
            this.Menu.Text = "Menu";
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.starredToolStripMenuItem,
            this.printThisPageToolStripMenuItem1,
            this.inspectElementToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Image = global::Tango_Browser.Properties.Resources.menu;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 7, 5, 5);
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(143, 36);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(235, 32);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // starredToolStripMenuItem
            // 
            this.starredToolStripMenuItem.Name = "starredToolStripMenuItem";
            this.starredToolStripMenuItem.Size = new System.Drawing.Size(235, 32);
            this.starredToolStripMenuItem.Text = "Pinned Pages";
            this.starredToolStripMenuItem.Click += new System.EventHandler(this.starredToolStripMenuItem_Click);
            // 
            // printThisPageToolStripMenuItem1
            // 
            this.printThisPageToolStripMenuItem1.Name = "printThisPageToolStripMenuItem1";
            this.printThisPageToolStripMenuItem1.Size = new System.Drawing.Size(235, 32);
            this.printThisPageToolStripMenuItem1.Text = "Print this Page";
            this.printThisPageToolStripMenuItem1.Click += new System.EventHandler(this.printThisPageToolStripMenuItem1_Click);
            // 
            // inspectElementToolStripMenuItem
            // 
            this.inspectElementToolStripMenuItem.Name = "inspectElementToolStripMenuItem";
            this.inspectElementToolStripMenuItem.Size = new System.Drawing.Size(235, 32);
            this.inspectElementToolStripMenuItem.Text = "Inspect Element";
            this.inspectElementToolStripMenuItem.Click += new System.EventHandler(this.inspectElementToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(235, 32);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // Address_textBox
            // 
            this.Address_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Address_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.Address_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address_textBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_textBox.Location = new System.Drawing.Point(174, 9);
            this.Address_textBox.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.Size = new System.Drawing.Size(759, 29);
            this.Address_textBox.TabIndex = 6;
            this.Address_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Address_textBox_KeyDown);
            // 
            // chromiumBrowser
            // 
            this.chromiumBrowser.ActivateBrowserOnCreation = false;
            this.chromiumBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chromiumBrowser.Location = new System.Drawing.Point(3, 46);
            this.chromiumBrowser.Name = "chromiumBrowser";
            this.chromiumBrowser.Size = new System.Drawing.Size(1097, 404);
            this.chromiumBrowser.TabIndex = 0;
            this.chromiumBrowser.FrameLoadStart += new System.EventHandler<CefSharp.FrameLoadStartEventArgs>(this.chromiumBrowser_FrameLoadStart);
            this.chromiumBrowser.FrameLoadEnd += new System.EventHandler<CefSharp.FrameLoadEndEventArgs>(this.chromiumBrowser_FrameLoadEnd);
            this.chromiumBrowser.LoadingStateChanged += new System.EventHandler<CefSharp.LoadingStateChangedEventArgs>(this.chromiumBrowser_LoadingStateChanged);
            this.chromiumBrowser.AddressChanged += new System.EventHandler<CefSharp.AddressChangedEventArgs>(this.chromiumBrowser_AddressChanged);
            this.chromiumBrowser.TitleChanged += new System.EventHandler<CefSharp.TitleChangedEventArgs>(this.chromiumBrowser_TitleChanged);
            // 
            // Pic_load
            // 
            this.Pic_load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic_load.Image = global::Tango_Browser.Properties.Resources.refresh;
            this.Pic_load.Location = new System.Drawing.Point(971, 8);
            this.Pic_load.Name = "Pic_load";
            this.Pic_load.Size = new System.Drawing.Size(30, 30);
            this.Pic_load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_load.TabIndex = 15;
            this.Pic_load.TabStop = false;
            this.Pic_load.Click += new System.EventHandler(this.pictureBox4_Click_1);
            // 
            // Pic_pin
            // 
            this.Pic_pin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic_pin.Image = global::Tango_Browser.Properties.Resources.pin;
            this.Pic_pin.Location = new System.Drawing.Point(1011, 8);
            this.Pic_pin.Name = "Pic_pin";
            this.Pic_pin.Size = new System.Drawing.Size(31, 31);
            this.Pic_pin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_pin.TabIndex = 14;
            this.Pic_pin.TabStop = false;
            this.Pic_pin.Click += new System.EventHandler(this.Pic_pin_Click);
            // 
            // Pic_home
            // 
            this.Pic_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_home.Image = global::Tango_Browser.Properties.Resources.Home;
            this.Pic_home.Location = new System.Drawing.Point(21, 5);
            this.Pic_home.Name = "Pic_home";
            this.Pic_home.Size = new System.Drawing.Size(35, 35);
            this.Pic_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_home.TabIndex = 12;
            this.Pic_home.TabStop = false;
            this.Pic_home.Click += new System.EventHandler(this.pictureBox4_Click);
            this.Pic_home.MouseEnter += new System.EventHandler(this.Pic_home_MouseEnter);
            this.Pic_home.MouseLeave += new System.EventHandler(this.Pic_home_MouseLeave);
            // 
            // Pic_forward
            // 
            this.Pic_forward.BackgroundImage = global::Tango_Browser.Properties.Resources.ForwardActive;
            this.Pic_forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_forward.Image = global::Tango_Browser.Properties.Resources.ForwardActive;
            this.Pic_forward.Location = new System.Drawing.Point(111, 5);
            this.Pic_forward.Name = "Pic_forward";
            this.Pic_forward.Size = new System.Drawing.Size(35, 35);
            this.Pic_forward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_forward.TabIndex = 11;
            this.Pic_forward.TabStop = false;
            this.Pic_forward.Click += new System.EventHandler(this.Pic_forward_Click);
            this.Pic_forward.MouseEnter += new System.EventHandler(this.Pic_forward_MouseEnter);
            this.Pic_forward.MouseLeave += new System.EventHandler(this.Pic_forward_MouseLeave);
            // 
            // Pic_back
            // 
            this.Pic_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_back.Image = global::Tango_Browser.Properties.Resources.BackActive;
            this.Pic_back.Location = new System.Drawing.Point(70, 5);
            this.Pic_back.Name = "Pic_back";
            this.Pic_back.Size = new System.Drawing.Size(35, 35);
            this.Pic_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_back.TabIndex = 10;
            this.Pic_back.TabStop = false;
            this.Pic_back.Click += new System.EventHandler(this.Pic_back_Click);
            this.Pic_back.MouseEnter += new System.EventHandler(this.Pic_back_MouseEnter);
            this.Pic_back.MouseLeave += new System.EventHandler(this.Pic_back_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImage = global::Tango_Browser.Properties.Resources.UrlBoxRight;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(941, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 35);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Tango_Browser.Properties.Resources.UrlBoxLeft;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(155, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 35);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.pictureBox2.Location = new System.Drawing.Point(174, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(769, 35);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Main_Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.chromiumBrowser);
            this.Controls.Add(this.Pic_load);
            this.Controls.Add(this.Pic_pin);
            this.Controls.Add(this.Address_textBox);
            this.Controls.Add(this.Pic_home);
            this.Controls.Add(this.Pic_forward);
            this.Controls.Add(this.Pic_back);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Name = "Main_Tab";
            this.Text = "Main_Tab";
            this.Load += new System.EventHandler(this.Main_Tab_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_pin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_forward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem starredToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printThisPageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.TextBox Address_textBox;
        private System.Windows.Forms.ToolStripMenuItem inspectElementToolStripMenuItem;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumBrowser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Pic_back;
        private System.Windows.Forms.PictureBox Pic_forward;
        private System.Windows.Forms.PictureBox Pic_home;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Pic_pin;
        private System.Windows.Forms.PictureBox Pic_load;
    }
}