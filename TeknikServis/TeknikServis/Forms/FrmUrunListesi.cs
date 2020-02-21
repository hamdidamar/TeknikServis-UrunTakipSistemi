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
        DboTeknikServisEntities db = new DboTeknikServisEntities();
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Tbl_Urun urun = new Tbl_Urun();
            urun.Adi = txtUrunAd.Text;
            urun.Marka = txtMarka.Text;
            urun.AlisFiyat = decimal.Parse(txtAlisFiyat.Text);
            urun.SatisFiyat = decimal.Parse(txtSatisFiyat.Text);
            urun.StokSayisi = int.Parse(txtStok.Text);
            urun.Durum = false;

            db.Tbl_Urun.Add(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Ekleme İşlemi Başarılı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Listele();

        }
        public void Listele()
        {
            var degerler = db.Tbl_Urun.ToList();
            grdUrunListesi.DataSource = degerler;
            cmbKategoriler.Properties.DataSource = db.Tbl_Kategori.ToList();
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtUrunId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtUrunAd.Text = gridView1.GetFocusedRowCellValue("Adi").ToString();
            txtMarka.Text = gridView1.GetFocusedRowCellValue("Marka").ToString();
            txtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("AlisFiyat").ToString();
            txtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SatisFiyat").ToString();
            txtStok.Text = gridView1.GetFocusedRowCellValue("StokSayisi").ToString();
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
    }
}
