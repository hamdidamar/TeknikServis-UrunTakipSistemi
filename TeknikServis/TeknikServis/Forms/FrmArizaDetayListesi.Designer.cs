namespace TeknikServis.Forms
{
    partial class FrmArizaDetayListesi
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
            this.grdArizaDetayListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdArizaDetayListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // grdArizaDetayListesi
            // 
            this.grdArizaDetayListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdArizaDetayListesi.Location = new System.Drawing.Point(0, 0);
            this.grdArizaDetayListesi.MainView = this.gridView2;
            this.grdArizaDetayListesi.Name = "grdArizaDetayListesi";
            this.grdArizaDetayListesi.Size = new System.Drawing.Size(1370, 541);
            this.grdArizaDetayListesi.TabIndex = 14;
            this.grdArizaDetayListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.GridControl = this.grdArizaDetayListesi;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            // 
            // FrmArizaDetayListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.grdArizaDetayListesi);
            this.Name = "FrmArizaDetayListesi";
            this.Text = "FrmArizaDetayListesi";
            this.Load += new System.EventHandler(this.FrmArizaDetayListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdArizaDetayListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdArizaDetayListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}