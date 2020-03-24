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
        Forms.FrmUrunListesi frmUrunListesi;
        private void btnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUrunListesi == null || frmUrunListesi.IsDisposed)
            {
                frmUrunListesi = new Forms.FrmUrunListesi();
                frmUrunListesi.MdiParent = this;
                frmUrunListesi.Show();
            }
        }
        Forms.FrmYeniUrun frmYeniUrun;
        private void btnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmYeniUrun == null || frmYeniUrun.IsDisposed)
            {
                frmYeniUrun = new Forms.FrmYeniUrun();
                frmYeniUrun.Show();
            }
            
        }
        Forms.FrmKategori frmKategoriListesi;
        private void btnKategoriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmKategoriListesi == null || frmKategoriListesi.IsDisposed)
            {
                frmKategoriListesi = new Forms.FrmKategori();
                frmKategoriListesi.MdiParent = this;
                frmKategoriListesi.Show();
            }
        }
        Forms.FrmYeniKategori frmYeniKategori;
        private void btnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmYeniKategori == null || frmYeniKategori.IsDisposed)
            {
                frmYeniKategori = new Forms.FrmYeniKategori();
                frmYeniKategori.Show();
            }
        }
        Forms.FrmUrunIstatislik frmUrunIstatistlik;
        private void btnUrunIstatislikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUrunIstatistlik == null || frmUrunIstatistlik.IsDisposed)
            {
                frmUrunIstatistlik = new Forms.FrmUrunIstatislik();
                frmUrunIstatistlik.MdiParent = this;
                frmUrunIstatistlik.Show();
            }
        }
        Forms.FrmMarkaIstatislik frmMarkaIstatislik;
        private void btnMarkaIstatislikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMarkaIstatislik == null || frmMarkaIstatislik.IsDisposed)
            {
                frmMarkaIstatislik = new Forms.FrmMarkaIstatislik();
                frmMarkaIstatislik.MdiParent = this;
                frmMarkaIstatislik.Show();
            }
        }
        Forms.FrmAnaSayfa frmAnaSayfa;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (frmAnaSayfa == null || frmAnaSayfa.IsDisposed)
            {
                frmAnaSayfa = new Forms.FrmAnaSayfa();
                frmAnaSayfa.MdiParent = this;
                frmAnaSayfa.Show();
            }
        }
        Forms.FrmMusteriListesi frmMusteriListesi;
        private void btnMusteriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMusteriListesi == null || frmMusteriListesi.IsDisposed)
            {
                frmMusteriListesi = new Forms.FrmMusteriListesi();
                frmMusteriListesi.MdiParent = this;
                frmMusteriListesi.Show();
            }
        }
        Forms.FrmMusteriIlIstatislik frmMusteriIlIstatislik;
        private void btnMusteriIlIstatistligi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMusteriIlIstatislik == null || frmMusteriIlIstatislik.IsDisposed)
            {
                frmMusteriIlIstatislik = new Forms.FrmMusteriIlIstatislik();
                frmMusteriIlIstatislik.MdiParent = this;
                frmMusteriIlIstatislik.Show();
            }
        }
        Forms.FrmYeniMusteri frmYeniMusteri;
        private void btnYeniMusteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmYeniMusteri == null || frmYeniMusteri.IsDisposed)
            {
                frmYeniMusteri = new Forms.FrmYeniMusteri();
                frmYeniMusteri.Show();
            }
        }
        Forms.FrmDepartmanListesi frmDepartmanListesi;
        private void btnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmDepartmanListesi == null || frmDepartmanListesi.IsDisposed)
            {
                frmDepartmanListesi = new Forms.FrmDepartmanListesi();
                frmDepartmanListesi.MdiParent = this;
                frmDepartmanListesi.Show();
            }
        }
        Forms.FrmPersonelListesi frmPersonelListesi;
        private void btnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmPersonelListesi == null || frmPersonelListesi.IsDisposed)
            {
                frmPersonelListesi = new Forms.FrmPersonelListesi();
                frmPersonelListesi.MdiParent = this;
                frmPersonelListesi.Show();
            }
        }

        private void btnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }
        Forms.FrmDovizKurlari frmDovizKurlari;
        private void btnDovizKurlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmDovizKurlari == null || frmDovizKurlari.IsDisposed)
            {
                frmDovizKurlari = new Forms.FrmDovizKurlari();
                frmDovizKurlari.MdiParent = this;
                frmDovizKurlari.Show();
            }
        }

        private void btnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }
        Forms.FrmYouTube frmYouTube;
        private void btnYouTube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmYouTube == null || frmYouTube.IsDisposed)
            {
                frmYouTube = new Forms.FrmYouTube();
                frmYouTube.MdiParent = this;
                frmYouTube.Show();
            }
        }
        Forms.FrmNotlar frmNotlar;
        private void btnAjanda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmNotlar == null || frmNotlar.IsDisposed)
            {
                frmNotlar = new Forms.FrmNotlar();
                frmNotlar.MdiParent = this;
                frmNotlar.Show();
            }
        }
        Forms.FrmArizaListesi frmArizaListesi;
        private void btnArizaliUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmArizaListesi == null || frmArizaListesi.IsDisposed)
            {
                frmArizaListesi = new Forms.FrmArizaListesi();
                frmArizaListesi.MdiParent = this;
                frmArizaListesi.Show();
            }
        }
        Forms.FrmUrunSatis frmUrunSatis;
        private void btnYeniUrunSatisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUrunSatis == null || frmUrunSatis.IsDisposed)
            {
                frmUrunSatis = new Forms.FrmUrunSatis();
                frmUrunSatis.Show();
            }
        }
        Forms.FrmSatisListesi frmSatisListesi;
        private void btnSatisListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmSatisListesi == null || frmSatisListesi.IsDisposed)
            {
                frmSatisListesi = new Forms.FrmSatisListesi();
                frmSatisListesi.MdiParent = this;
                frmSatisListesi.Show();
            }
            
        }
        Forms.FrmYeniArizaliUrun frmYeniArizaliUrun;
        private void btnYeniArizaliUrunKaydi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmYeniArizaliUrun == null || frmYeniArizaliUrun.IsDisposed)
            {
                frmYeniArizaliUrun = new Forms.FrmYeniArizaliUrun();
                frmYeniArizaliUrun.Show();
            }
        }
        Forms.FrmArizaDetay frmArizaDetay;
        private void btnArizaliUrunAciklamasi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmArizaDetay == null || frmArizaDetay.IsDisposed)
            {
                frmArizaDetay = new Forms.FrmArizaDetay();
                frmArizaDetay.Show();
            }
        }
        Forms.FrmArizaDetayListesi frmArizaDetayListesi;
        private void btnArizaliUrunDetaylari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmArizaDetayListesi == null || frmArizaDetayListesi.IsDisposed)
            {
                frmArizaDetayListesi = new Forms.FrmArizaDetayListesi();
                frmArizaDetayListesi.MdiParent = this;
                frmArizaDetayListesi.Show();
            }
        }
        Forms.FrmQRCode frmQRCode;
        private void btnQrKodOlustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmQRCode == null || frmQRCode.IsDisposed)
            {
                frmQRCode = new Forms.FrmQRCode();
                frmQRCode.Show();
            }
        }
        Forms.FrmFaturaListesi frmFaturaListesi;
        private void btnFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmFaturaDetay == null || frmFaturaDetay.IsDisposed)
            {
                frmFaturaListesi = new Forms.FrmFaturaListesi();
                frmFaturaListesi.MdiParent = this;
                frmFaturaListesi.Show();
            }
        }
        Forms.FrmFaturaDetay frmFaturaDetay;
        private void btnFaturayaKalemGirisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmFaturaDetay == null || frmFaturaDetay.IsDisposed)
            {
                frmFaturaDetay = new Forms.FrmFaturaDetay();
                frmFaturaDetay.MdiParent = this;
                frmFaturaDetay.Show();
            }
        }
        Forms.FrmDetayliFaturaSorgulama frmDetayliFaturaSorgulama;
        private void btnDetaylıFaturaSorgulama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmDetayliFaturaSorgulama == null || frmDetayliFaturaSorgulama.IsDisposed)
            {
                frmDetayliFaturaSorgulama = new Forms.FrmDetayliFaturaSorgulama();
                frmDetayliFaturaSorgulama.MdiParent = this;
                frmDetayliFaturaSorgulama.Show();
            }
        }
        Forms.FrmGauge frmGauge;
        private void btnHakkimizda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmGauge == null || frmGauge.IsDisposed)
            {
                frmGauge = new Forms.FrmGauge();
                frmGauge.MdiParent = this;
                frmGauge.Show();
            }
        }
        Forms.FrmHarita frmHarita;
        private void btnHarita_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmHarita == null || frmHarita.IsDisposed)
            {
                frmHarita = new Forms.FrmHarita();
                frmHarita.MdiParent = this;
                frmHarita.Show();
            }
        }
        Forms.FrmRapor frmRapor;
        private void btnRaporSihirbazi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmRapor == null || frmRapor.IsDisposed)
            {
                frmRapor = new Forms.FrmRapor();
                frmRapor.MdiParent = this;
                frmRapor.Show();
            }
        }
        private void btnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmAnaSayfa == null || frmAnaSayfa.IsDisposed)
            {
                frmAnaSayfa = new Forms.FrmAnaSayfa();
                frmAnaSayfa.MdiParent = this;
                frmAnaSayfa.Show();
            }
        }
    }
}
