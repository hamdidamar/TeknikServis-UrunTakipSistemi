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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }
        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Tbl_Urun urun = new Tbl_Urun();
                urun.Adi = txtUrunAd.Text;
                urun.Marka = txtMarka.Text;
                urun.KategoriID = int.Parse(cmbKategoriler.EditValue.ToString());
                urun.AlisFiyat = decimal.Parse(txtAlisFiyat.Text);
                urun.SatisFiyat = decimal.Parse(txtSatisFiyat.Text);
                urun.StokSayisi = int.Parse(txtStok.Text);
                urun.Durum = false;
                db.Tbl_Urun.Add(urun);
                db.SaveChanges();
                MessageBox.Show("Ürün Ekleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Ürün Ekleme İşlemi Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            

        }
        public void Listele()
        {
            //var degerler = db.Tbl_Urun.ToList();
            var degerler = from u in db.Tbl_Urun
                           select new
                           {
                               u.ID,
                               u.Adi,
                               u.Marka,
                               Kategori = u.Tbl_Kategori.Adi,
                               u.StokSayisi,
                               u.AlisFiyat,
                               u.SatisFiyat
                           };
            grdUrunListesi.DataSource = degerler.ToList();
            cmbKategoriler.Properties.DataSource = (from x in db.Tbl_Kategori
                                                    select new
                                                    {
                                                        x.ID,
                                                        x.Adi
                                                    }).ToList();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtUrunId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                txtUrunAd.Text = gridView1.GetFocusedRowCellValue("Adi").ToString();
                txtMarka.Text = gridView1.GetFocusedRowCellValue("Marka").ToString();
                txtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("AlisFiyat").ToString();
                txtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SatisFiyat").ToString();
                txtStok.Text = gridView1.GetFocusedRowCellValue("StokSayisi").ToString();
                cmbKategoriler.Text = gridView1.GetFocusedRowCellValue("Kategori").ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Seçtiğiniz Sütünda Null Değerler Olabilir");
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUrunId.Text);
            var deger = db.Tbl_Urun.Find(id);
            db.Tbl_Urun.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün Silme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUrunId.Text);
            var deger = db.Tbl_Urun.Find(id);
            deger.Adi = txtUrunAd.Text;
            deger.Marka = txtMarka.Text;
            deger.AlisFiyat = decimal.Parse(txtAlisFiyat.Text);
            deger.SatisFiyat = decimal.Parse(txtSatisFiyat.Text);
            deger.StokSayisi = int.Parse(txtStok.Text);
            deger.Durum = false;
            db.SaveChanges();
            MessageBox.Show("Ürün Güncelleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtUrunId.Text = "";
            txtUrunAd.Text = "";
            txtMarka.Text = "";
            txtAlisFiyat.Text = "";
            txtSatisFiyat.Text="";
            txtStok.Text = "";
        }
    }
}
