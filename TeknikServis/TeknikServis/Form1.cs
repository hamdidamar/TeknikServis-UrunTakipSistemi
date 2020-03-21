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

        private void btnMarkaIstatislikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmMarkaIstatislik frmMarkaIstatislik = new Forms.FrmMarkaIstatislik();
            frmMarkaIstatislik.MdiParent = this;
            frmMarkaIstatislik.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMusteriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmMusteriListesi frmMusteriListesi = new Forms.FrmMusteriListesi();
            frmMusteriListesi.MdiParent = this;
            frmMusteriListesi.Show();
        }

        private void btnMusteriIlIstatistligi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmMusteriIlIstatislik frmMusteriIlIstatislik = new Forms.FrmMusteriIlIstatislik();
            frmMusteriIlIstatislik.MdiParent = this;
            frmMusteriIlIstatislik.Show();
        }

        private void btnYeniMusteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmYeniMusteri frmYeniMusteri = new Forms.FrmYeniMusteri();
            frmYeniMusteri.Show();
        }

        private void btnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmDepartmanListesi frmDepartmanListesi = new Forms.FrmDepartmanListesi();
            frmDepartmanListesi.MdiParent = this;
            frmDepartmanListesi.Show();
        }

        private void btnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmPersonelListesi frmPersonelListesi = new Forms.FrmPersonelListesi();
            frmPersonelListesi.MdiParent = this;
            frmPersonelListesi.Show();
        }

        private void btnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btnDovizKurlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmDovizKurlari frmDovizKurlari = new Forms.FrmDovizKurlari();
            frmDovizKurlari.MdiParent = this;
            frmDovizKurlari.Show();
        }

        private void btnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void btnYouTube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmYouTube frmYouTube = new Forms.FrmYouTube();
            frmYouTube.MdiParent = this;
            frmYouTube.Show();
        }

        private void btnAjanda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNotlar frmNotlar = new Forms.FrmNotlar();
            frmNotlar.MdiParent = this;
            frmNotlar.Show();
        }
    }
}
