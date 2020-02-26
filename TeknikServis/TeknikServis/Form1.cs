using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmUrunListesi frmUrunListesi = new Forms.FrmUrunListesi();
            frmUrunListesi.MdiParent = this;
            frmUrunListesi.Show();
        }

        private void btnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmYeniUrun frmYeniUrun = new Forms.FrmYeniUrun();
            //frmYeniUrun.MdiParent = this;
            frmYeniUrun.Show();
        }

        private void btnKategoriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmKategori frmKategoriListesi = new Forms.FrmKategori();
            frmKategoriListesi.MdiParent = this;
            frmKategoriListesi.Show();
        }

        private void btnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmYeniKategori frmYeniKategori = new Forms.FrmYeniKategori();
            frmYeniKategori.Show();
        }

        private void btnUrunIstatislikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmUrunIstatislik frmUrunIstatistlik = new Forms.FrmUrunIstatislik();
            frmUrunIstatistlik.MdiParent = this;
            frmUrunIstatistlik.Show();
        }
    }
}
