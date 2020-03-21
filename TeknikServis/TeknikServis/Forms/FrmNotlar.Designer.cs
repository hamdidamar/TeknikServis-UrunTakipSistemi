namespace TeknikServis.Forms
{
    partial class FrmNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotlar));
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.txtNotId = new DevExpress.XtraEditors.TextEdit();
            this.lblMusteriId = new DevExpress.XtraEditors.LabelControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.lblSoyad = new DevExpress.XtraEditors.LabelControl();
            this.txtNotBaslik = new DevExpress.XtraEditors.TextEdit();
            this.lblAd = new DevExpress.XtraEditors.LabelControl();
            this.gcAjandaİşlemleri = new DevExpress.XtraEditors.GroupControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdNotOkunmayanListesi = new DevExpress.XtraGrid.GridControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grdNotOkunan = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtNotIcerik = new System.Windows.Forms.RichTextBox();
            this.chdurum = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAjandaİşlemleri)).BeginInit();
            this.gcAjandaİşlemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNotOkunmayanListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNotOkunan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chdurum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl26
            // 
            this.labelControl26.Location = new System.Drawing.Point(61, 108);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(33, 13);
            this.labelControl26.TabIndex = 19;
            this.labelControl26.Text = "İçerik :";
            // 
            // txtNotId
            // 
            this.txtNotId.Enabled = false;
            this.txtNotId.Location = new System.Drawing.Point(100, 46);
            this.txtNotId.Name = "txtNotId";
            this.txtNotId.Size = new System.Drawing.Size(200, 20);
            this.txtNotId.TabIndex = 1;
            // 
            // lblMusteriId
            // 
            this.lblMusteriId.Location = new System.Drawing.Point(56, 49);
            this.lblMusteriId.Name = "lblMusteriId";
            this.lblMusteriId.Size = new System.Drawing.Size(38, 13);
            this.lblMusteriId.TabIndex = 15;
            this.lblMusteriId.Text = "Not ID :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(100, 449);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(200, 73);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(100, 360);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(200, 73);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblSoyad
            // 
            this.lblSoyad.Location = new System.Drawing.Point(56, 228);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(38, 13);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Durum :";
            // 
            // txtNotBaslik
            // 
            this.txtNotBaslik.Location = new System.Drawing.Point(100, 79);
            this.txtNotBaslik.Name = "txtNotBaslik";
            this.txtNotBaslik.Size = new System.Drawing.Size(200, 20);
            this.txtNotBaslik.TabIndex = 2;
            // 
            // lblAd
            // 
            this.lblAd.Location = new System.Drawing.Point(61, 82);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(33, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Başlık :";
            // 
            // gcAjandaİşlemleri
            // 
            this.gcAjandaİşlemleri.Controls.Add(this.chdurum);
            this.gcAjandaİşlemleri.Controls.Add(this.txtNotIcerik);
            this.gcAjandaİşlemleri.Controls.Add(this.labelControl26);
            this.gcAjandaİşlemleri.Controls.Add(this.txtNotId);
            this.gcAjandaİşlemleri.Controls.Add(this.lblMusteriId);
            this.gcAjandaİşlemleri.Controls.Add(this.btnGuncelle);
            this.gcAjandaİşlemleri.Controls.Add(this.btnSil);
            this.gcAjandaİşlemleri.Controls.Add(this.btnKaydet);
            this.gcAjandaİşlemleri.Controls.Add(this.lblSoyad);
            this.gcAjandaİşlemleri.Controls.Add(this.txtNotBaslik);
            this.gcAjandaİşlemleri.Controls.Add(this.lblAd);
            this.gcAjandaİşlemleri.Location = new System.Drawing.Point(1010, 3);
            this.gcAjandaİşlemleri.Name = "gcAjandaİşlemleri";
            this.gcAjandaİşlemleri.Size = new System.Drawing.Size(355, 535);
            this.gcAjandaİşlemleri.TabIndex = 33;
            this.gcAjandaİşlemleri.Text = "Ajanda İşlemleri";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(100, 271);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(200, 73);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.grdNotOkunmayanListesi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // grdNotOkunmayanListesi
            // 
            this.grdNotOkunmayanListesi.Location = new System.Drawing.Point(5, 31);
            this.grdNotOkunmayanListesi.MainView = this.gridView1;
            this.grdNotOkunmayanListesi.Name = "grdNotOkunmayanListesi";
            this.grdNotOkunmayanListesi.Size = new System.Drawing.Size(999, 238);
            this.grdNotOkunmayanListesi.TabIndex = 34;
            this.grdNotOkunmayanListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(162, 19);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Okunmayan Notlar :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 275);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(135, 19);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "Okunan Notlar :";
            // 
            // grdNotOkunan
            // 
            this.grdNotOkunan.Location = new System.Drawing.Point(5, 300);
            this.grdNotOkunan.MainView = this.gridView2;
            this.grdNotOkunan.Name = "grdNotOkunan";
            this.grdNotOkunan.Size = new System.Drawing.Size(999, 238);
            this.grdNotOkunan.TabIndex = 36;
            this.grdNotOkunan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.GridControl = this.grdNotOkunan;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // txtNotIcerik
            // 
            this.txtNotIcerik.Location = new System.Drawing.Point(100, 105);
            this.txtNotIcerik.Name = "txtNotIcerik";
            this.txtNotIcerik.Size = new System.Drawing.Size(200, 114);
            this.txtNotIcerik.TabIndex = 20;
            this.txtNotIcerik.Text = "";
            // 
            // chdurum
            // 
            this.chdurum.Location = new System.Drawing.Point(100, 225);
            this.chdurum.Name = "chdurum";
            this.chdurum.Properties.Caption = "Okundu Olarak İşaretle";
            this.chdurum.Size = new System.Drawing.Size(200, 19);
            this.chdurum.TabIndex = 21;
            // 
            // FrmNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.grdNotOkunan);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gcAjandaİşlemleri);
            this.Controls.Add(this.grdNotOkunmayanListesi);
            this.Name = "FrmNotlar";
            this.Text = "FrmNotlar";
            this.Load += new System.EventHandler(this.FrmNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNotId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAjandaİşlemleri)).EndInit();
            this.gcAjandaİşlemleri.ResumeLayout(false);
            this.gcAjandaİşlemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNotOkunmayanListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNotOkunan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chdurum.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.TextEdit txtNotId;
        private DevExpress.XtraEditors.LabelControl lblMusteriId;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.LabelControl lblSoyad;
        private DevExpress.XtraEditors.TextEdit txtNotBaslik;
        private DevExpress.XtraEditors.LabelControl lblAd;
        private DevExpress.XtraEditors.GroupControl gcAjandaİşlemleri;
        private DevExpress.XtraEditors.CheckEdit chdurum;
        private System.Windows.Forms.RichTextBox txtNotIcerik;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grdNotOkunmayanListesi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl grdNotOkunan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}