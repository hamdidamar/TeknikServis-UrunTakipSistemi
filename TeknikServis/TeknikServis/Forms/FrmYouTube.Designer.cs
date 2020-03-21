namespace TeknikServis.Forms
{
    partial class FrmYouTube
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
            this.webrYouTube = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webrYouTube
            // 
            this.webrYouTube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webrYouTube.Location = new System.Drawing.Point(0, 0);
            this.webrYouTube.MinimumSize = new System.Drawing.Size(20, 20);
            this.webrYouTube.Name = "webrYouTube";
            this.webrYouTube.Size = new System.Drawing.Size(1370, 541);
            this.webrYouTube.TabIndex = 0;
            // 
            // FrmYouTube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.webrYouTube);
            this.Name = "FrmYouTube";
            this.Text = "FrmYouTube";
            this.Load += new System.EventHandler(this.FrmYouTube_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webrYouTube;
    }
}