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
    public partial class FrmSatisListesi : Form
    {
        public FrmSatisListesi()
        {
            InitializeComponent();
        }
        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void FrmSatisListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            var degerler = from uh in db.Tbl_UrunHareket
                           select new
                           {
                               uh.ID,
                               uh.UrunSeriNo,
                               uh.Tbl_Urun.Adi,
                               Musteri = uh.Tbl_Cari.Adi + " "+ uh.Tbl_Cari.Soyadi,
                               Personel = uh.Tbl_Personel.Adi +" "+ uh.Tbl_Personel.Soyadi,
                               uh.Tarih,
                               uh.Adet,
                               uh.Fiyat

                           };
            grdSatisListesi.DataSource = degerler.ToList();
        }
    }
}
