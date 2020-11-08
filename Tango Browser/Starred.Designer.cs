namespace Tango_Browser
{
    partial class Starred
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
            this.but_hist_back = new System.Windows.Forms.Button();
            this.starredList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Starred";
            // 
            // but_hist_back
            // 
            this.but_hist_back.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_hist_back.Location = new System.Drawing.Point(3, 2);
            this.but_hist_back.Name = "but_hist_back";
            this.but_hist_back.Size = new System.Drawing.Size(75, 35);
            this.but_hist_back.TabIndex = 4;
            this.but_hist_back.Text = "<-Back";
            this.but_hist_back.UseVisualStyleBackColor = true;
            // 
            // starredList
            // 
            this.starredList.HideSelection = false;
            this.starredList.Location = new System.Drawing.Point(3, 61);
            this.starredList.Name = "starredList";
            this.starredList.Size = new System.Drawing.Size(795, 387);
            this.starredList.TabIndex = 7;
            this.starredList.UseCompatibleStateImageBehavior = false;
            this.starredList.View = System.Windows.Forms.View.List;
            // 
            // Starred
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.starredList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_hist_back);
            this.Name = "Starred";
            this.Text = "Starred";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_hist_back;
        private System.Windows.Forms.ListView starredList;
    }
}