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
    public partial class FrmUrunIstatislik : Form
    {
        public FrmUrunIstatislik()
        {
            InitializeComponent();
        }

        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void FrmUrunIstatislik_Load(object sender, EventArgs e)
        {
            lblToplamUrunSayisi.Text = db.Tbl_Urun.Count().ToString();
            lblToplamKategoriSayisi.Text = db.Tbl_Kategori.Count().ToString();
            lblToplamStokSayisi.Text = db.Tbl_Urun.Sum(x => x.StokSayisi).ToString();
            lblEnFazlaStokluUrun.Text = (from x in db.Tbl_Urun
                                      orderby x.StokSayisi descending
                                      select x.Adi).FirstOrDefault();

            lblEnAzStokluUrun.Text = (from x in db.Tbl_Urun
                                         orderby x.StokSayisi ascending
                                         select x.Adi).FirstOrDefault();

            lblEnYuksekFiyatliUrun.Text = (from x in db.Tbl_Urun
                                      orderby x.SatisFiyat descending
                                      select x.Adi).FirstOrDefault();

            lblEnDusukFiyatliUrun.Text = (from x in db.Tbl_Urun
                                           orderby x.SatisFiyat ascending
                                           select x.Adi).FirstOrDefault();

            lblBeyazEsyaStokSayisi.Text = db.Tbl_Urun.Count( x => x.Tbl_Kategori.Adi == "Beyaz Eşya").ToString();
            lblBilgisayarStokSayisi.Text = db.Tbl_Urun.Count(x => x.Tbl_Kategori.Adi == "Bilgisayar").ToString();
            lblKucukEvAletleriStokSayisi.Text = db.Tbl_Urun.Count(x => x.Tbl_Kategori.Adi == "Küçük Ev Aletleri").ToString();

            lblToplamMarkaSayisi.Text = (from x in db.Tbl_Urun select x.Marka).Distinct().Count().ToString();

            lblArizaliUrunSayisi.Text = db.Tbl_UrunKabul.Count().ToString();
            lblEnFazlaUrunKategorisi.Text = db.MaxUrunKategori().FirstOrDefault();



        }

        private void labelControl36_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
