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
    public partial class FrmArizaListesi : Form
    {
        public FrmArizaListesi()
        {
            InitializeComponent();
        }
        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void FrmArizaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            var degerler = from x in db.Tbl_UrunKabul select new
            {
                x.ID,
                x.UrunSeriNo,
                //Urun = x.Tbl_Urun.Adi,
                Musteri = x.Tbl_Cari.Adi + x.Tbl_Cari.Soyadi,
                Personel = x.Tbl_Personel.Adi + x.Tbl_Personel.Soyadi,
                x.GelisTarih,
                x.CikisTarih

            };
            grdArizaListesi.DataSource = degerler.ToList();
        }

    }
}
