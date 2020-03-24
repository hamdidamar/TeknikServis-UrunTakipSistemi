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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            Listele();

        }
        public void Listele()
        {
            var degerler = from kategori in db.Tbl_Kategori
                           select new
                           {
                               kategori.ID,
                               kategori.Adi
                           };
            grdKategoriListesi.DataSource = degerler.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKategoriAd.Text !="" && txtKategoriAd.Text.Length <=50)
            {
                Tbl_Kategori kategori = new Tbl_Kategori();
                kategori.ID = int.Parse(txtKategoriId.Text);
                kategori.Adi = txtKategoriAd.Text;
                db.Tbl_Kategori.Add(kategori);
                db.SaveChanges();
                MessageBox.Show("Kategori Ekleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            else
            {
                MessageBox.Show("Lütfen Girdiğiniz Değerleri Kontrol Ediniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtKategoriId.Text);
            var deger = db.Tbl_Kategori.Find(id);
            db.Tbl_Kategori.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kategori Silme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtKategoriId.Text);
            var deger = db.Tbl_Kategori.Find(id);
            deger.Adi = txtKategoriAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncelleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtKategoriId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtKategoriAd.Text = gridView1.GetFocusedRowCellValue("Adi").ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKategoriId.Text = "";
            txtKategoriAd.Text = "";
        }

    }
}
