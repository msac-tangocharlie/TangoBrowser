namespace Tango_Browser
{
    partial class UserProfileSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserEmail = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.LinkLabel();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.userEmailText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Profile Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Profile PIcture:";
            // 
            // UserEmail
            // 
            this.UserEmail.BackColor = System.Drawing.Color.Transparent;
            this.UserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserEmail.ForeColor = System.Drawing.Color.Gray;
            this.UserEmail.Location = new System.Drawing.Point(77, 218);
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.Size = new System.Drawing.Size(283, 33);
            this.UserEmail.TabIndex = 3;
            this.UserEmail.Text = "hopanshgahlot@gmail.com";
            this.UserEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserName
            // 
            this.UserName.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.UserName.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserName.Location = new System.Drawing.Point(101, 177);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(215, 44);
            this.UserName.TabIndex = 0;
            this.UserName.TabStop = true;
            this.UserName.Text = "Hopansh Gahlot";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackgroundImage = global::Tango_Browser.Properties.Resources.avatar;
            this.pictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox17.Location = new System.Drawing.Point(149, 49);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(125, 125);
            this.pictureBox17.TabIndex = 1;
            this.pictureBox17.TabStop = false;
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(149, 299);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(248, 22);
            this.usernameText.TabIndex = 4;
            // 
            // userEmailText
            // 
            this.userEmailText.Location = new System.Drawing.Point(150, 336);
            this.userEmailText.Name = "userEmailText";
            this.userEmailText.Size = new System.Drawing.Size(247, 22);
            this.userEmailText.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Choose";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserProfileSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userEmailText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.label1);
            this.Name = "UserProfileSettings";
            this.Text = "UserProfileSettings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UserEmail;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.LinkLabel UserName;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox userEmailText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}