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
    public partial class FrmMusteriListesi : Form
    {
        public FrmMusteriListesi()
        {
            InitializeComponent();
        }

        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void FrmMusteriListesi_Load(object sender, EventArgs e)
        {
            
            Listele();
        }
        public void Listele()
        {
            var degerler = from m in db.Tbl_Cari
                           select new
                           {
                               m.ID,
                               m.Adi,
                               m.Soyadi,
                               m.Mail,
                               m.Telefon,
                               m.Banka,
                               m.IL,
                               m.ILCE,
                               m.Statu,
                               m.VergiDairesi,
                               m.VergiNo,
                               m.Adres
                           };
            grdMusteriListesi.DataSource = degerler.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Tbl_Cari deger = new Tbl_Cari();
            deger.Adi = txtMusteriAd.Text;
            deger.Soyadi = txtMusteriSoyad.Text;
            deger.Mail = txtMusteriMail.Text;
            deger.Telefon = txtMusteriTelefon.Text;
            deger.Banka = txtMusteriBanka.Text;
            deger.IL = cmbMusteriIl.Text;
            deger.ILCE = cmbMusteriIlce.Text;
            deger.Statu = txtMusteriStatu.Text;
            deger.VergiDairesi = txtMusteriVDaire.Text;
            deger.VergiNo = txtMusteriVNo.Text;
            deger.Adres = txtMusteriAdres.Text;
            

            db.Tbl_Cari.Add(deger);
            db.SaveChanges();
            MessageBox.Show("Müşteri Ekleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMusteriId.Text);
            var deger = db.Tbl_Cari.Find(id);
            deger.Adi = txtMusteriAd.Text;
            deger.Soyadi = txtMusteriSoyad.Text;
            deger.Mail = txtMusteriMail.Text;
            deger.Telefon = txtMusteriTelefon.Text;
            deger.Banka = txtMusteriBanka.Text;
            deger.IL = cmbMusteriIl.Text;
            deger.ILCE = cmbMusteriIlce.Text;
            deger.Statu = txtMusteriStatu.Text;
            deger.VergiDairesi = txtMusteriVDaire.Text;
            deger.VergiNo = txtMusteriVNo.Text;
            deger.Adres = txtMusteriAdres.Text;
            db.SaveChanges();
            MessageBox.Show("Müşteri Güncelleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMusteriId.Text);
            var deger = db.Tbl_Cari.Find(id);
            db.Tbl_Cari.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Müşteri Silme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtMusteriId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtMusteriAd.Text = gridView1.GetFocusedRowCellValue("Adi").ToString();
            txtMusteriSoyad.Text = gridView1.GetFocusedRowCellValue("Soyadi").ToString();
            txtMusteriMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            txtMusteriTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            txtMusteriBanka.Text = gridView1.GetFocusedRowCellValue("Banka").ToString();
            txtMusteriStatu.Text = gridView1.GetFocusedRowCellValue("Statu").ToString();
            txtMusteriVDaire.Text = gridView1.GetFocusedRowCellValue("VergiDairesi").ToString();
            txtMusteriVNo.Text = gridView1.GetFocusedRowCellValue("VergiNo").ToString();
            txtMusteriAdres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
        }
    
    }
}
