namespace TeknikServis.Forms
{
    partial class FrmFaturaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaDetay));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdFaturaDetayListesi = new DevExpress.XtraGrid.GridControl();
            this.gcFaturaDetay = new DevExpress.XtraEditors.GroupControl();
            this.cmbUrunler = new DevExpress.XtraEditors.LookUpEdit();
            this.txtFaturaID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtAdet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.lblDetayId = new DevExpress.XtraEditors.LabelControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lblAd = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFaturaDetayListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFaturaDetay)).BeginInit();
            this.gcFaturaDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUrunler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.grdFaturaDetayListesi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // grdFaturaDetayListesi
            // 
            this.grdFaturaDetayListesi.Location = new System.Drawing.Point(9, 3);
            this.grdFaturaDetayListesi.MainView = this.gridView1;
            this.grdFaturaDetayListesi.Name = "grdFaturaDetayListesi";
            this.grdFaturaDetayListesi.Size = new System.Drawing.Size(893, 535);
            this.grdFaturaDetayListesi.TabIndex = 30;
            this.grdFaturaDetayListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gcFaturaDetay
            // 
            this.gcFaturaDetay.Controls.Add(this.cmbUrunler);
            this.gcFaturaDetay.Controls.Add(this.txtFaturaID);
            this.gcFaturaDetay.Controls.Add(this.labelControl4);
            this.gcFaturaDetay.Controls.Add(this.txtTutar);
            this.gcFaturaDetay.Controls.Add(this.labelControl3);
            this.gcFaturaDetay.Controls.Add(this.txtFiyat);
            this.gcFaturaDetay.Controls.Add(this.labelControl2);
            this.gcFaturaDetay.Controls.Add(this.txtAdet);
            this.gcFaturaDetay.Controls.Add(this.labelControl1);
            this.gcFaturaDetay.Controls.Add(this.txtId);
            this.gcFaturaDetay.Controls.Add(this.lblDetayId);
            this.gcFaturaDetay.Controls.Add(this.btnGuncelle);
            this.gcFaturaDetay.Controls.Add(this.btnSil);
            this.gcFaturaDetay.Controls.Add(this.btnKaydet);
            this.gcFaturaDetay.Controls.Add(this.lblAd);
            this.gcFaturaDetay.Location = new System.Drawing.Point(908, 3);
            this.gcFaturaDetay.Name = "gcFaturaDetay";
            this.gcFaturaDetay.Size = new System.Drawing.Size(454, 535);
            this.gcFaturaDetay.TabIndex = 29;
            this.gcFaturaDetay.Text = "Fatura Detay İşlemleri";
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.Location = new System.Drawing.Point(98, 110);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUrunler.Properties.DisplayMember = "Adi";
            this.cmbUrunler.Properties.ValueMember = "Adi";
            this.cmbUrunler.Size = new System.Drawing.Size(323, 20);
            this.cmbUrunler.TabIndex = 25;
            // 
            // txtFaturaID
            // 
            this.txtFaturaID.Location = new System.Drawing.Point(98, 210);
            this.txtFaturaID.Name = "txtFaturaID";
            this.txtFaturaID.Size = new System.Drawing.Size(323, 20);
            this.txtFaturaID.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(39, 213);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Fatura ID :";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(98, 184);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(323, 20);
            this.txtTutar.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(59, 187);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Tutar :";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(98, 158);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(323, 20);
            this.txtFiyat.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(61, 161);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Fiyat :";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(98, 132);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(323, 20);
            this.txtAdet.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(62, 135);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Adet :";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(98, 80);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(323, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblDetayId
            // 
            this.lblDetayId.Location = new System.Drawing.Point(42, 83);
            this.lblDetayId.Name = "lblDetayId";
            this.lblDetayId.Size = new System.Drawing.Size(50, 13);
            this.lblDetayId.TabIndex = 15;
            this.lblDetayId.Text = "Detay ID :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(98, 433);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(323, 80);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(98, 347);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(323, 80);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(98, 261);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(323, 80);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblAd
            // 
            this.lblAd.Location = new System.Drawing.Point(62, 113);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(30, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ürün :";
            // 
            // FrmFaturaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.gcFaturaDetay);
            this.Controls.Add(this.grdFaturaDetayListesi);
            this.Name = "FrmFaturaDetay";
            this.Text = "FrmFaturaDetay";
            this.Load += new System.EventHandler(this.FrmFaturaDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFaturaDetayListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFaturaDetay)).EndInit();
            this.gcFaturaDetay.ResumeLayout(false);
            this.gcFaturaDetay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUrunler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grdFaturaDetayListesi;
        private DevExpress.XtraEditors.GroupControl gcFaturaDetay;
        private DevExpress.XtraEditors.TextEdit txtFaturaID;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtAdet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl lblDetayId;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl lblAd;
        private DevExpress.XtraEditors.LookUpEdit cmbUrunler;
    }
}