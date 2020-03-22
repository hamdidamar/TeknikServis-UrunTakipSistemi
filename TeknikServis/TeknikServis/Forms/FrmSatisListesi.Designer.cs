namespace TeknikServis.Forms
{
    partial class FrmSatisListesi
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
            this.grdSatisListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatisListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSatisListesi
            // 
            this.grdSatisListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSatisListesi.Location = new System.Drawing.Point(0, 0);
            this.grdSatisListesi.MainView = this.gridView1;
            this.grdSatisListesi.Name = "grdSatisListesi";
            this.grdSatisListesi.Size = new System.Drawing.Size(1370, 541);
            this.grdSatisListesi.TabIndex = 1;
            this.grdSatisListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.grdSatisListesi;
            this.gridView1.Name = "gridView1";
            // 
            // FrmSatisListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.grdSatisListesi);
            this.Name = "FrmSatisListesi";
            this.Text = "FrmSatisListesi";
            this.Load += new System.EventHandler(this.FrmSatisListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSatisListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdSatisListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}