namespace TeknikServis.Forms
{
    partial class FrmQRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQRCode));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit12 = new DevExpress.XtraEditors.PictureEdit();
            this.btnQROlustur = new DevExpress.XtraEditors.SimpleButton();
            this.imgQRCode = new DevExpress.XtraEditors.PictureEdit();
            this.btnCikis = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit12.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQRCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCikis.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(179, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(232, 29);
            this.labelControl1.TabIndex = 122;
            this.labelControl1.Text = "QR KOD OLUŞTURMA";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Location = new System.Drawing.Point(179, 136);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(220, 3);
            this.panel12.TabIndex = 124;
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.EditValue = "Ürün Seri No";
            this.txtSeriNo.Location = new System.Drawing.Point(179, 111);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.txtSeriNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeriNo.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtSeriNo.Properties.Appearance.Options.UseBackColor = true;
            this.txtSeriNo.Properties.Appearance.Options.UseFont = true;
            this.txtSeriNo.Properties.Appearance.Options.UseForeColor = true;
            this.txtSeriNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtSeriNo.Properties.Mask.EditMask = "AAAAAAAAAA";
            this.txtSeriNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtSeriNo.Size = new System.Drawing.Size(216, 24);
            this.txtSeriNo.TabIndex = 1;
            // 
            // pictureEdit12
            // 
            this.pictureEdit12.EditValue = ((object)(resources.GetObject("pictureEdit12.EditValue")));
            this.pictureEdit12.Location = new System.Drawing.Point(123, 92);
            this.pictureEdit12.Name = "pictureEdit12";
            this.pictureEdit12.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit12.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit12.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit12.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit12.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit12.Size = new System.Drawing.Size(50, 50);
            this.pictureEdit12.TabIndex = 123;
            // 
            // btnQROlustur
            // 
            this.btnQROlustur.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQROlustur.Appearance.Options.UseFont = true;
            this.btnQROlustur.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnQROlustur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQROlustur.ImageOptions.Image")));
            this.btnQROlustur.Location = new System.Drawing.Point(211, 145);
            this.btnQROlustur.Name = "btnQROlustur";
            this.btnQROlustur.Size = new System.Drawing.Size(142, 32);
            this.btnQROlustur.TabIndex = 2;
            this.btnQROlustur.Text = "QR Oluştur";
            this.btnQROlustur.Click += new System.EventHandler(this.btnQROlustur_Click);
            // 
            // imgQRCode
            // 
            this.imgQRCode.Location = new System.Drawing.Point(179, 195);
            this.imgQRCode.Name = "imgQRCode";
            this.imgQRCode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.imgQRCode.Properties.Appearance.Options.UseBackColor = true;
            this.imgQRCode.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.imgQRCode.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.imgQRCode.Size = new System.Drawing.Size(220, 202);
            this.imgQRCode.TabIndex = 126;
            // 
            // btnCikis
            // 
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.EditValue = ((object)(resources.GetObject("btnCikis.EditValue")));
            this.btnCikis.Location = new System.Drawing.Point(558, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.Properties.Appearance.Options.UseBackColor = true;
            this.btnCikis.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.btnCikis.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.btnCikis.Size = new System.Drawing.Size(50, 50);
            this.btnCikis.TabIndex = 139;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FrmQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(611, 437);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.imgQRCode);
            this.Controls.Add(this.btnQROlustur);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.txtSeriNo);
            this.Controls.Add(this.pictureEdit12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQRCode";
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit12.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQRCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCikis.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel12;
        private DevExpress.XtraEditors.TextEdit txtSeriNo;
        private DevExpress.XtraEditors.PictureEdit pictureEdit12;
        private DevExpress.XtraEditors.SimpleButton btnQROlustur;
        private DevExpress.XtraEditors.PictureEdit imgQRCode;
        private DevExpress.XtraEditors.PictureEdit btnCikis;
    }
}