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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.findbox = new System.Windows.Forms.GroupBox();
            this.find_next = new System.Windows.Forms.Button();
            this.find_prev = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.find_label = new System.Windows.Forms.Label();
            this.but_Find = new System.Windows.Forms.Button();
            this.find_textbox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.downPercent = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.but_color = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.findPanel = new System.Windows.Forms.Button();
            this.histPanel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.incogBrowse = new CefSharp.WinForms.ChromiumWebBrowser();
            this.chromiumBrowser = new CefSharp.WinForms.ChromiumWebBrowser();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Pic_pin = new System.Windows.Forms.PictureBox();
            this.Pic_load = new System.Windows.Forms.PictureBox();
            this.Pic_home = new System.Windows.Forms.PictureBox();
            this.Pic_forward = new System.Windows.Forms.PictureBox();
            this.Pic_back = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            this.findbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_pin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_forward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.Name = "splitContainer2";
            // 
            // Address_textBox
            // 
            resources.ApplyResources(this.Address_textBox, "Address_textBox");
            this.Address_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.Address_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.Click += new System.EventHandler(this.Address_textBox_Click);
            this.Address_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Address_textBox_KeyDown);
            // 
            // findbox
            // 
            resources.ApplyResources(this.findbox, "findbox");
            this.findbox.BackColor = System.Drawing.Color.GhostWhite;
            this.findbox.Controls.Add(this.find_next);
            this.findbox.Controls.Add(this.find_prev);
            this.findbox.Controls.Add(this.button1);
            this.findbox.Controls.Add(this.find_label);
            this.findbox.Controls.Add(this.but_Find);
            this.findbox.Controls.Add(this.find_textbox);
            this.findbox.Controls.Add(this.pictureBox2);
            this.findbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.findbox.Name = "findbox";
            this.findbox.TabStop = false;
            // 
            // find_next
            // 
            resources.ApplyResources(this.find_next, "find_next");
            this.find_next.Name = "find_next";
            this.find_next.UseVisualStyleBackColor = true;
            this.find_next.Click += new System.EventHandler(this.find_next_Click);
            // 
            // find_prev
            // 
            resources.ApplyResources(this.find_prev, "find_prev");
            this.find_prev.Name = "find_prev";
            this.find_prev.UseVisualStyleBackColor = true;
            this.find_prev.Click += new System.EventHandler(this.find_prev_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // find_label
            // 
            resources.ApplyResources(this.find_label, "find_label");
            this.find_label.Name = "find_label";
            // 
            // but_Find
            // 
            resources.ApplyResources(this.but_Find, "but_Find");
            this.but_Find.Name = "but_Find";
            this.but_Find.UseVisualStyleBackColor = true;
            this.but_Find.Click += new System.EventHandler(this.but_Find_Click);
            // 
            // find_textbox
            // 
            resources.ApplyResources(this.find_textbox, "find_textbox");
            this.find_textbox.Name = "find_textbox";
            this.find_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.find_textbox_KeyDown);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.downPercent);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.but_color);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.findPanel);
            this.panel1.Controls.Add(this.histPanel);
            this.panel1.Name = "panel1";
            // 
            // downPercent
            // 
            resources.ApplyResources(this.downPercent, "downPercent");
            this.downPercent.ForeColor = System.Drawing.Color.Black;
            this.downPercent.Name = "downPercent";
            // 
            // pictureBox7
            // 
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.BackgroundImage = global::Tango_Browser.Properties.Resources.downloadIn;
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.BackgroundImage = global::Tango_Browser.Properties.Resources.downloadOut;
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Tango_Browser.Properties.Resources.Incognito;
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // but_color
            // 
            this.but_color.BackgroundImage = global::Tango_Browser.Properties.Resources.color;
            resources.ApplyResources(this.but_color, "but_color");
            this.but_color.Name = "but_color";
            this.but_color.UseVisualStyleBackColor = true;
            this.but_color.Click += new System.EventHandler(this.but_color_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Tango_Browser.Properties.Resources.inspect;
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // findPanel
            // 
            this.findPanel.BackgroundImage = global::Tango_Browser.Properties.Resources.findText;
            resources.ApplyResources(this.findPanel, "findPanel");
            this.findPanel.Name = "findPanel";
            this.findPanel.UseVisualStyleBackColor = true;
            this.findPanel.Click += new System.EventHandler(this.findPanel_Click);
            // 
            // histPanel
            // 
            this.histPanel.BackgroundImage = global::Tango_Browser.Properties.Resources.history_512;
            resources.ApplyResources(this.histPanel, "histPanel");
            this.histPanel.ForeColor = System.Drawing.Color.White;
            this.histPanel.Name = "histPanel";
            this.histPanel.UseVisualStyleBackColor = true;
            this.histPanel.Click += new System.EventHandler(this.histPanel_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.findbox);
            this.panel2.Controls.Add(this.progressBar3);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Name = "panel2";
            // 
            // progressBar3
            // 
            resources.ApplyResources(this.progressBar3, "progressBar3");
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Value = 8;
            // 
            // incogBrowse
            // 
            this.incogBrowse.ActivateBrowserOnCreation = false;
            resources.ApplyResources(this.incogBrowse, "incogBrowse");
            this.incogBrowse.Name = "incogBrowse";
            this.incogBrowse.FrameLoadStart += new System.EventHandler<CefSharp.FrameLoadStartEventArgs>(this.incogBrowse_FrameLoadStart);
            this.incogBrowse.FrameLoadEnd += new System.EventHandler<CefSharp.FrameLoadEndEventArgs>(this.incogBrowse_FrameLoadEnd);
            this.incogBrowse.LoadingStateChanged += new System.EventHandler<CefSharp.LoadingStateChangedEventArgs>(this.incogBrowse_LoadingStateChanged);
            this.incogBrowse.AddressChanged += new System.EventHandler<CefSharp.AddressChangedEventArgs>(this.incogBrowse_AddressChanged);
            // 
            // chromiumBrowser
            // 
            this.chromiumBrowser.ActivateBrowserOnCreation = false;
            resources.ApplyResources(this.chromiumBrowser, "chromiumBrowser");
            this.chromiumBrowser.Name = "chromiumBrowser";
            this.chromiumBrowser.FrameLoadStart += new System.EventHandler<CefSharp.FrameLoadStartEventArgs>(this.chromiumBrowser_FrameLoadStart);
            this.chromiumBrowser.FrameLoadEnd += new System.EventHandler<CefSharp.FrameLoadEndEventArgs>(this.chromiumBrowser_FrameLoadEnd_1);
            this.chromiumBrowser.LoadingStateChanged += new System.EventHandler<CefSharp.LoadingStateChangedEventArgs>(this.chromiumBrowser_LoadingStateChanged);
            this.chromiumBrowser.AddressChanged += new System.EventHandler<CefSharp.AddressChangedEventArgs>(this.chromiumBrowser_AddressChanged);
            this.chromiumBrowser.TitleChanged += new System.EventHandler<CefSharp.TitleChangedEventArgs>(this.chromiumBrowser_TitleChanged_1);
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Image = global::Tango_Browser.Properties.Resources.off;
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click_2);
            // 
            // Pic_pin
            // 
            resources.ApplyResources(this.Pic_pin, "Pic_pin");
            this.Pic_pin.Image = global::Tango_Browser.Properties.Resources.pin;
            this.Pic_pin.Name = "Pic_pin";
            this.Pic_pin.TabStop = false;
            this.Pic_pin.Click += new System.EventHandler(this.Pic_pin_Click);
            // 
            // Pic_load
            // 
            this.Pic_load.BackColor = System.Drawing.Color.Transparent;
            this.Pic_load.Image = global::Tango_Browser.Properties.Resources.refresh;
            resources.ApplyResources(this.Pic_load, "Pic_load");
            this.Pic_load.Name = "Pic_load";
            this.Pic_load.TabStop = false;
            this.Pic_load.Click += new System.EventHandler(this.pictureBox4_Click_1);
            // 
            // Pic_home
            // 
            this.Pic_home.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Pic_home, "Pic_home");
            this.Pic_home.Image = global::Tango_Browser.Properties.Resources.Home;
            this.Pic_home.Name = "Pic_home";
            this.Pic_home.TabStop = false;
            this.Pic_home.Click += new System.EventHandler(this.pictureBox4_Click);
            this.Pic_home.MouseEnter += new System.EventHandler(this.Pic_home_MouseEnter);
            this.Pic_home.MouseLeave += new System.EventHandler(this.Pic_home_MouseLeave);
            // 
            // Pic_forward
            // 
            this.Pic_forward.BackColor = System.Drawing.Color.Transparent;
            this.Pic_forward.BackgroundImage = global::Tango_Browser.Properties.Resources.ForwardActive;
            resources.ApplyResources(this.Pic_forward, "Pic_forward");
            this.Pic_forward.Image = global::Tango_Browser.Properties.Resources.ForwardActive;
            this.Pic_forward.Name = "Pic_forward";
            this.Pic_forward.TabStop = false;
            this.Pic_forward.Click += new System.EventHandler(this.Pic_forward_Click);
            this.Pic_forward.MouseEnter += new System.EventHandler(this.Pic_forward_MouseEnter);
            this.Pic_forward.MouseLeave += new System.EventHandler(this.Pic_forward_MouseLeave);
            // 
            // Pic_back
            // 
            this.Pic_back.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Pic_back, "Pic_back");
            this.Pic_back.Image = global::Tango_Browser.Properties.Resources.BackActive;
            this.Pic_back.Name = "Pic_back";
            this.Pic_back.TabStop = false;
            this.Pic_back.Click += new System.EventHandler(this.Pic_back_Click);
            this.Pic_back.MouseEnter += new System.EventHandler(this.Pic_back_MouseEnter);
            this.Pic_back.MouseLeave += new System.EventHandler(this.Pic_back_MouseLeave);
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = global::Tango_Browser.Properties.Resources.UrlBoxRight;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Tango_Browser.Properties.Resources.UrlBoxLeft;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Main_Tab
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Tango_Browser.Properties.Settings.Default.FormBackGround;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pic_pin);
            this.Controls.Add(this.Pic_load);
            this.Controls.Add(this.Address_textBox);
            this.Controls.Add(this.Pic_home);
            this.Controls.Add(this.Pic_forward);
            this.Controls.Add(this.Pic_back);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chromiumBrowser);
            this.Controls.Add(this.incogBrowse);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Tab";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.findbox.ResumeLayout(false);
            this.findbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_pin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_forward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Address_textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Pic_back;
        private System.Windows.Forms.PictureBox Pic_forward;
        private System.Windows.Forms.PictureBox Pic_home;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Pic_pin;
        private System.Windows.Forms.PictureBox Pic_load;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox findbox;
        private System.Windows.Forms.Label find_label;
        private System.Windows.Forms.Button but_Find;
        private System.Windows.Forms.TextBox find_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button find_next;
        private System.Windows.Forms.Button find_prev;
        private System.Windows.Forms.Button histPanel;
        private System.Windows.Forms.Button findPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumBrowser;
        private CefSharp.WinForms.ChromiumWebBrowser incogBrowse;
        private System.Windows.Forms.Button but_color;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label downPercent;
    }
}