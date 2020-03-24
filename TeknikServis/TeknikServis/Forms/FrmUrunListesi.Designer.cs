namespace TeknikServis.Forms
{
    partial class FrmUrunListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunListesi));
            this.grdUrunListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcUrunListesi = new DevExpress.XtraEditors.GroupControl();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.txtUrunId = new DevExpress.XtraEditors.TextEdit();
            this.lblUrunId = new DevExpress.XtraEditors.LabelControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lblKategori = new DevExpress.XtraEditors.LabelControl();
            this.cmbKategoriler = new DevExpress.XtraEditors.LookUpEdit();
            this.txtStok = new DevExpress.XtraEditors.TextEdit();
            this.lblStok = new DevExpress.XtraEditors.LabelControl();
            this.txtSatisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.lblSatisFiyat = new DevExpress.XtraEditors.LabelControl();
            this.txtAlisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.lblAlisFiyat = new DevExpress.XtraEditors.LabelControl();
            this.txtMarka = new DevExpress.XtraEditors.TextEdit();
            this.lblMarka = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunAd = new DevExpress.XtraEditors.TextEdit();
            this.lblUrunAd = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdUrunListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUrunListesi)).BeginInit();
            this.gcUrunListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKategoriler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdUrunListesi
            // 
            this.grdUrunListesi.Location = new System.Drawing.Point(1, 3);
            this.grdUrunListesi.MainView = this.gridView1;
            this.grdUrunListesi.Name = "grdUrunListesi";
            this.grdUrunListesi.Size = new System.Drawing.Size(1031, 535);
            this.grdUrunListesi.TabIndex = 0;
            this.grdUrunListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.grdUrunListesi;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gcUrunListesi
            // 
            this.gcUrunListesi.Controls.Add(this.btnTemizle);
            this.gcUrunListesi.Controls.Add(this.txtUrunId);
            this.gcUrunListesi.Controls.Add(this.lblUrunId);
            this.gcUrunListesi.Controls.Add(this.btnGuncelle);
            this.gcUrunListesi.Controls.Add(this.btnSil);
            this.gcUrunListesi.Controls.Add(this.btnKaydet);
            this.gcUrunListesi.Controls.Add(this.lblKategori);
            this.gcUrunListesi.Controls.Add(this.cmbKategoriler);
            this.gcUrunListesi.Controls.Add(this.txtStok);
            this.gcUrunListesi.Controls.Add(this.lblStok);
            this.gcUrunListesi.Controls.Add(this.txtSatisFiyat);
            this.gcUrunListesi.Controls.Add(this.lblSatisFiyat);
            this.gcUrunListesi.Controls.Add(this.txtAlisFiyat);
            this.gcUrunListesi.Controls.Add(this.lblAlisFiyat);
            this.gcUrunListesi.Controls.Add(this.txtMarka);
            this.gcUrunListesi.Controls.Add(this.lblMarka);
            this.gcUrunListesi.Controls.Add(this.txtUrunAd);
            this.gcUrunListesi.Controls.Add(this.lblUrunAd);
            this.gcUrunListesi.Location = new System.Drawing.Point(1039, 3);
            this.gcUrunListesi.Name = "gcUrunListesi";
            this.gcUrunListesi.Size = new System.Drawing.Size(322, 535);
            this.gcUrunListesi.TabIndex = 1;
            this.gcUrunListesi.Text = "Ürün İşlemleri";
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(115, 384);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(150, 32);
            this.btnTemizle.TabIndex = 18;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtUrunId
            // 
            this.txtUrunId.Enabled = false;
            this.txtUrunId.Location = new System.Drawing.Point(115, 64);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(150, 20);
            this.txtUrunId.TabIndex = 16;
            // 
            // lblUrunId
            // 
            this.lblUrunId.Location = new System.Drawing.Point(55, 67);
            this.lblUrunId.Name = "lblUrunId";
            this.lblUrunId.Size = new System.Drawing.Size(44, 13);
            this.lblUrunId.TabIndex = 15;
            this.lblUrunId.Text = "Ürün ID :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(115, 346);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(150, 32);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(115, 308);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(150, 32);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(115, 270);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(150, 32);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblKategori
            // 
            this.lblKategori.Location = new System.Drawing.Point(52, 232);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(47, 13);
            this.lblKategori.TabIndex = 11;
            this.lblKategori.Text = "Kategori :";
            this.lblKategori.Visible = false;
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.EditValue = "Kategori Seçiniz";
            this.cmbKategoriler.Location = new System.Drawing.Point(115, 229);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbKategoriler.Properties.DisplayMember = "Adi";
            this.cmbKategoriler.Properties.ValueMember = "ID";
            this.cmbKategoriler.Size = new System.Drawing.Size(150, 20);
            this.cmbKategoriler.TabIndex = 10;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(115, 194);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(150, 20);
            this.txtStok.TabIndex = 9;
            // 
            // lblStok
            // 
            this.lblStok.Location = new System.Drawing.Point(71, 197);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(28, 13);
            this.lblStok.TabIndex = 8;
            this.lblStok.Text = "Stok :";
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Location = new System.Drawing.Point(115, 168);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(150, 20);
            this.txtSatisFiyat.TabIndex = 7;
            // 
            // lblSatisFiyat
            // 
            this.lblSatisFiyat.Location = new System.Drawing.Point(40, 171);
            this.lblSatisFiyat.Name = "lblSatisFiyat";
            this.lblSatisFiyat.Size = new System.Drawing.Size(59, 13);
            this.lblSatisFiyat.TabIndex = 6;
            this.lblSatisFiyat.Text = "Satış Fiyatı :";
            // 
            // txtAlisFiyat
            // 
            this.txtAlisFiyat.Location = new System.Drawing.Point(115, 142);
            this.txtAlisFiyat.Name = "txtAlisFiyat";
            this.txtAlisFiyat.Size = new System.Drawing.Size(150, 20);
            this.txtAlisFiyat.TabIndex = 5;
            // 
            // lblAlisFiyat
            // 
            this.lblAlisFiyat.Location = new System.Drawing.Point(47, 145);
            this.lblAlisFiyat.Name = "lblAlisFiyat";
            this.lblAlisFiyat.Size = new System.Drawing.Size(52, 13);
            this.lblAlisFiyat.TabIndex = 4;
            this.lblAlisFiyat.Text = "Alış Fiyatı :";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(115, 116);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(150, 20);
            this.txtMarka.TabIndex = 3;
            // 
            // lblMarka
            // 
            this.lblMarka.Location = new System.Drawing.Point(63, 119);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(36, 13);
            this.lblMarka.TabIndex = 2;
            this.lblMarka.Text = "Marka :";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(115, 90);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(150, 20);
            this.txtUrunAd.TabIndex = 1;
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.Location = new System.Drawing.Point(51, 93);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(48, 13);
            this.lblUrunAd.TabIndex = 0;
            this.lblUrunAd.Text = "Ürün Adı :";
            // 
            // FrmUrunListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.gcUrunListesi);
            this.Controls.Add(this.grdUrunListesi);
            this.Name = "FrmUrunListesi";
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.FrmUrunListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUrunListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUrunListesi)).EndInit();
            this.gcUrunListesi.ResumeLayout(false);
            this.gcUrunListesi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKategoriler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdUrunListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl gcUrunListesi;
        private DevExpress.XtraEditors.TextEdit txtStok;
        private DevExpress.XtraEditors.LabelControl lblStok;
        private DevExpress.XtraEditors.TextEdit txtSatisFiyat;
        private DevExpress.XtraEditors.LabelControl lblSatisFiyat;
        private DevExpress.XtraEditors.TextEdit txtAlisFiyat;
        private DevExpress.XtraEditors.LabelControl lblAlisFiyat;
        private DevExpress.XtraEditors.TextEdit txtMarka;
        private DevExpress.XtraEditors.LabelControl lblMarka;
        private DevExpress.XtraEditors.TextEdit txtUrunAd;
        private DevExpress.XtraEditors.LabelControl lblUrunAd;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl lblKategori;
        private DevExpress.XtraEditors.LookUpEdit cmbKategoriler;
        private DevExpress.XtraEditors.TextEdit txtUrunId;
        private DevExpress.XtraEditors.LabelControl lblUrunId;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
    }
}