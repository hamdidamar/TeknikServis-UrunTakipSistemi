namespace TeknikServis.Forms
{
    partial class FrmFaturaListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaListesi));
            this.lblAd = new DevExpress.XtraEditors.LabelControl();
            this.lblMusteriId = new DevExpress.XtraEditors.LabelControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.txtSeri = new DevExpress.XtraEditors.TextEdit();
            this.gcFaturaListesi = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmbPersonel = new DevExpress.XtraEditors.LookUpEdit();
            this.lblKategori = new DevExpress.XtraEditors.LabelControl();
            this.cmbMusteriler = new DevExpress.XtraEditors.LookUpEdit();
            this.txtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSaat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTarih = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSiraNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdFaturaListesi = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFaturaListesi)).BeginInit();
            this.gcFaturaListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMusteriler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiraNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFaturaListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.Location = new System.Drawing.Point(67, 71);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(25, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Seri :";
            // 
            // lblMusteriId
            // 
            this.lblMusteriId.Location = new System.Drawing.Point(39, 45);
            this.lblMusteriId.Name = "lblMusteriId";
            this.lblMusteriId.Size = new System.Drawing.Size(53, 13);
            this.lblMusteriId.TabIndex = 15;
            this.lblMusteriId.Text = "Fatura ID :";
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
            this.btnGuncelle.TabIndex = 11;
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
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(98, 42);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(323, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(98, 68);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Properties.Mask.EditMask = "A";
            this.txtSeri.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtSeri.Size = new System.Drawing.Size(323, 20);
            this.txtSeri.TabIndex = 2;
            // 
            // gcFaturaListesi
            // 
            this.gcFaturaListesi.Controls.Add(this.labelControl6);
            this.gcFaturaListesi.Controls.Add(this.cmbPersonel);
            this.gcFaturaListesi.Controls.Add(this.lblKategori);
            this.gcFaturaListesi.Controls.Add(this.cmbMusteriler);
            this.gcFaturaListesi.Controls.Add(this.txtVergiDairesi);
            this.gcFaturaListesi.Controls.Add(this.labelControl4);
            this.gcFaturaListesi.Controls.Add(this.txtSaat);
            this.gcFaturaListesi.Controls.Add(this.labelControl3);
            this.gcFaturaListesi.Controls.Add(this.txtTarih);
            this.gcFaturaListesi.Controls.Add(this.labelControl2);
            this.gcFaturaListesi.Controls.Add(this.txtSiraNo);
            this.gcFaturaListesi.Controls.Add(this.labelControl1);
            this.gcFaturaListesi.Controls.Add(this.txtId);
            this.gcFaturaListesi.Controls.Add(this.lblMusteriId);
            this.gcFaturaListesi.Controls.Add(this.btnGuncelle);
            this.gcFaturaListesi.Controls.Add(this.btnSil);
            this.gcFaturaListesi.Controls.Add(this.btnKaydet);
            this.gcFaturaListesi.Controls.Add(this.txtSeri);
            this.gcFaturaListesi.Controls.Add(this.lblAd);
            this.gcFaturaListesi.Location = new System.Drawing.Point(911, 3);
            this.gcFaturaListesi.Name = "gcFaturaListesi";
            this.gcFaturaListesi.Size = new System.Drawing.Size(454, 535);
            this.gcFaturaListesi.TabIndex = 27;
            this.gcFaturaListesi.Text = "Fatura İşlemleri";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(44, 227);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 13);
            this.labelControl6.TabIndex = 30;
            this.labelControl6.Text = "Personel :";
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.Location = new System.Drawing.Point(98, 224);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPersonel.Properties.DisplayMember = "Adi";
            this.cmbPersonel.Properties.ValueMember = "ID";
            this.cmbPersonel.Size = new System.Drawing.Size(323, 20);
            this.cmbPersonel.TabIndex = 8;
            // 
            // lblKategori
            // 
            this.lblKategori.Location = new System.Drawing.Point(50, 201);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(42, 13);
            this.lblKategori.TabIndex = 28;
            this.lblKategori.Text = "Müşteri :";
            // 
            // cmbMusteriler
            // 
            this.cmbMusteriler.Location = new System.Drawing.Point(98, 198);
            this.cmbMusteriler.Name = "cmbMusteriler";
            this.cmbMusteriler.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMusteriler.Properties.DisplayMember = "Adi";
            this.cmbMusteriler.Properties.ValueMember = "ID";
            this.cmbMusteriler.Size = new System.Drawing.Size(323, 20);
            this.cmbMusteriler.TabIndex = 7;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(98, 172);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(323, 20);
            this.txtVergiDairesi.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(26, 175);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Vergi Dairesi :";
            // 
            // txtSaat
            // 
            this.txtSaat.Location = new System.Drawing.Point(98, 146);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Properties.Mask.EditMask = "90:00";
            this.txtSaat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtSaat.Size = new System.Drawing.Size(323, 20);
            this.txtSaat.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(63, 149);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Saat :";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(98, 120);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Mask.EditMask = "99/99/00";
            this.txtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtTarih.Size = new System.Drawing.Size(323, 20);
            this.txtTarih.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(61, 123);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Tarih :";
            // 
            // txtSiraNo
            // 
            this.txtSiraNo.Location = new System.Drawing.Point(98, 94);
            this.txtSiraNo.Name = "txtSiraNo";
            this.txtSiraNo.Properties.Mask.EditMask = "AAAAAA";
            this.txtSiraNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtSiraNo.Size = new System.Drawing.Size(323, 20);
            this.txtSiraNo.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(51, 97);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Sıra No :";
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
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.grdFaturaListesi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // grdFaturaListesi
            // 
            this.grdFaturaListesi.Location = new System.Drawing.Point(12, 3);
            this.grdFaturaListesi.MainView = this.gridView1;
            this.grdFaturaListesi.Name = "grdFaturaListesi";
            this.grdFaturaListesi.Size = new System.Drawing.Size(893, 535);
            this.grdFaturaListesi.TabIndex = 28;
            this.grdFaturaListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // FrmFaturaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.gcFaturaListesi);
            this.Controls.Add(this.grdFaturaListesi);
            this.Name = "FrmFaturaListesi";
            this.Text = "FrmFaturaListesi";
            this.Load += new System.EventHandler(this.FrmFaturaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFaturaListesi)).EndInit();
            this.gcFaturaListesi.ResumeLayout(false);
            this.gcFaturaListesi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMusteriler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiraNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFaturaListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblAd;
        private DevExpress.XtraEditors.LabelControl lblMusteriId;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.TextEdit txtSeri;
        private DevExpress.XtraEditors.GroupControl gcFaturaListesi;
        private DevExpress.XtraEditors.TextEdit txtVergiDairesi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSaat;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTarih;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSiraNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grdFaturaListesi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit cmbPersonel;
        private DevExpress.XtraEditors.LabelControl lblKategori;
        private DevExpress.XtraEditors.LookUpEdit cmbMusteriler;
    }
}