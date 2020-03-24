using DevExpress.CodeParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Forms
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            KritikSeviye();
            Fihrist();
            UrunKategori();
            BugunYapilacaklar();
            SonMesajlar();
        }
        public void KritikSeviye()
        {
            grdKritikSeviye.DataSource = (from x in db.Tbl_Urun
                                          select new
                                          {
                                              x.Adi,
                                              x.Marka,
                                              x.SatisFiyat,
                                              x.StokSayisi
                                          }).Where(x => x.StokSayisi < 30).ToList();
        }
        public void Fihrist()
        {
            grdFihrist.DataSource = (from x in db.Tbl_Cari
                                          select new
                                          {
                                              x.Adi,
                                              x.Soyadi,
                                              x.Telefon,
                                              x.IL
                                          }).ToList();
        }
        public void UrunKategori()
        {
            grdKategoriUrun.DataSource = db.UrunKategori().ToList();
        }
        public void BugunYapilacaklar()
        {
            DateTime bugun = DateTime.Today;
            var degerler = (from x in db.Tbl_Not.OrderBy(y => y.ID)
                         where (x.Tarih == bugun)
                         select new { x.Baslik, x.Icerik });
            grdBugunYapilacaklar.DataSource = degerler.ToList();
        }
        public void SonMesajlar()
        {
            string ad1, konu1, ad2, konu2, ad3, konu3, ad4, konu4, ad5, konu5;
            ad1 = db.Tbl_Iletisim.First(x => x.ID == 1).AdSoyad;
            konu1 = db.Tbl_Iletisim.First(x => x.ID == 1).Konu;
            lbl1.Text = ad1 + " - " + konu1;

            ad2 = db.Tbl_Iletisim.First(x => x.ID == 2).AdSoyad;
            konu2 = db.Tbl_Iletisim.First(x => x.ID == 2).Konu;
            lbl2.Text = ad2 + " - " + konu2;

            ad3 = db.Tbl_Iletisim.First(x => x.ID == 3).AdSoyad;
            konu3 = db.Tbl_Iletisim.First(x => x.ID == 3).Konu;
            lbl3.Text = ad3 + " - " + konu3;

            ad4 = db.Tbl_Iletisim.First(x => x.ID == 4).AdSoyad;
            konu4 = db.Tbl_Iletisim.First(x => x.ID == 4).Konu;
            lbl4.Text = ad4 + " - " + konu4;

            ad5 = db.Tbl_Iletisim.First(x => x.ID == 5).AdSoyad;
            konu5 = db.Tbl_Iletisim.First(x => x.ID == 5).Konu;
            lbl5.Text = ad5 + " - " + konu5;
        }

    }
}
