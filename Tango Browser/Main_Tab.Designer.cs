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
            this.but_Home = new System.Windows.Forms.Button();
            this.but_back = new System.Windows.Forms.Button();
            this.but_forward = new System.Windows.Forms.Button();
            this.but_go = new System.Windows.Forms.Button();
            this.but_refresh = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printThisPageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inspectElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chromiumBrowser = new CefSharp.WinForms.ChromiumWebBrowser();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_Home
            // 
            this.but_Home.Location = new System.Drawing.Point(3, 2);
            this.but_Home.Name = "but_Home";
            this.but_Home.Size = new System.Drawing.Size(75, 35);
            this.but_Home.TabIndex = 0;
            this.but_Home.Text = "Home";
            this.but_Home.UseVisualStyleBackColor = true;
            this.but_Home.Click += new System.EventHandler(this.but_Home_Click);
            // 
            // but_back
            // 
            this.but_back.Location = new System.Drawing.Point(84, 2);
            this.but_back.Name = "but_back";
            this.but_back.Size = new System.Drawing.Size(45, 35);
            this.but_back.TabIndex = 1;
            this.but_back.Text = "<<";
            this.but_back.UseVisualStyleBackColor = true;
            this.but_back.Click += new System.EventHandler(this.but_back_Click);
            // 
            // but_forward
            // 
            this.but_forward.Location = new System.Drawing.Point(134, 2);
            this.but_forward.Name = "but_forward";
            this.but_forward.Size = new System.Drawing.Size(45, 35);
            this.but_forward.TabIndex = 2;
            this.but_forward.Text = ">>";
            this.but_forward.UseVisualStyleBackColor = true;
            this.but_forward.Click += new System.EventHandler(this.but_forward_Click);
            // 
            // but_go
            // 
            this.but_go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_go.Location = new System.Drawing.Point(876, 2);
            this.but_go.Name = "but_go";
            this.but_go.Size = new System.Drawing.Size(64, 35);
            this.but_go.TabIndex = 3;
            this.but_go.Text = "Go";
            this.but_go.UseVisualStyleBackColor = true;
            this.but_go.Click += new System.EventHandler(this.but_go_Click);
            // 
            // but_refresh
            // 
            this.but_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_refresh.Location = new System.Drawing.Point(946, 2);
            this.but_refresh.Name = "but_refresh";
            this.but_refresh.Size = new System.Drawing.Size(100, 35);
            this.but_refresh.TabIndex = 4;
            this.but_refresh.Text = "Refresh";
            this.but_refresh.UseVisualStyleBackColor = true;
            this.but_refresh.Click += new System.EventHandler(this.but_refresh_Click);
            // 
            // Menu
            // 
            this.Menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(1049, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(82, 450);
            this.Menu.TabIndex = 5;
            this.Menu.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.starredToolStripMenuItem,
            this.printThisPageToolStripMenuItem1,
            this.inspectElementToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(69, 32);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(235, 32);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // starredToolStripMenuItem
            // 
            this.starredToolStripMenuItem.Name = "starredToolStripMenuItem";
            this.starredToolStripMenuItem.Size = new System.Drawing.Size(235, 32);
            this.starredToolStripMenuItem.Text = "Starred";
            // 
            // printThisPageToolStripMenuItem1
            // 
            this.printThisPageToolStripMenuItem1.Name = "printThisPageToolStripMenuItem1";
            this.printThisPageToolStripMenuItem1.Size = new System.Drawing.Size(235, 32);
            this.printThisPageToolStripMenuItem1.Text = "Print this Page";
            this.printThisPageToolStripMenuItem1.Click += new System.EventHandler(this.printThisPageToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(235, 32);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // inspectElementToolStripMenuItem
            // 
            this.inspectElementToolStripMenuItem.Name = "inspectElementToolStripMenuItem";
            this.inspectElementToolStripMenuItem.Size = new System.Drawing.Size(235, 32);
            this.inspectElementToolStripMenuItem.Text = "Inspect Element";
            this.inspectElementToolStripMenuItem.Click += new System.EventHandler(this.inspectElementToolStripMenuItem_Click);
            // 
            // Address_textBox
            // 
            this.Address_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Address_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_textBox.Location = new System.Drawing.Point(189, 5);
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.Size = new System.Drawing.Size(681, 30);
            this.Address_textBox.TabIndex = 6;
            this.Address_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Address_textBox_KeyDown);
            // 
            // chromiumBrowser
            // 
            this.chromiumBrowser.ActivateBrowserOnCreation = false;
            this.chromiumBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chromiumBrowser.Location = new System.Drawing.Point(3, 43);
            this.chromiumBrowser.Name = "chromiumBrowser";
            this.chromiumBrowser.Size = new System.Drawing.Size(1128, 407);
            this.chromiumBrowser.TabIndex = 7;
            this.chromiumBrowser.FrameLoadEnd += new System.EventHandler<CefSharp.FrameLoadEndEventArgs>(this.chromiumBrowser_FrameLoadEnd);
            // 
            // Main_Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 450);
            this.Controls.Add(this.chromiumBrowser);
            this.Controls.Add(this.Address_textBox);
            this.Controls.Add(this.but_refresh);
            this.Controls.Add(this.but_go);
            this.Controls.Add(this.but_forward);
            this.Controls.Add(this.but_back);
            this.Controls.Add(this.but_Home);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.Menu;
            this.Name = "Main_Tab";
            this.Text = "Main_Tab";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_Home;
        private System.Windows.Forms.Button but_back;
        private System.Windows.Forms.Button but_forward;
        private System.Windows.Forms.Button but_go;
        private System.Windows.Forms.Button but_refresh;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem starredToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printThisPageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.TextBox Address_textBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumBrowser;
        private System.Windows.Forms.ToolStripMenuItem inspectElementToolStripMenuItem;
    }
}