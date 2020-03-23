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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }
        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            var degerler = from fb in db.Tbl_FaturaBilgi
                           select new
                           {
                               fb.ID,
                               fb.Seri,
                               fb.SiraNo,
                               fb.Tarih,
                               fb.Saat,
                               fb.VergiDaire,
                               Musteri = fb.Tbl_Cari.Adi + " " + fb.Tbl_Cari.Soyadi,
                               Personel = fb.Tbl_Personel.Adi + " " + fb.Tbl_Personel.Soyadi


                           };
            grdFaturaListesi.DataSource = degerler.ToList();

            cmbMusteriler.Properties.DataSource = (from x in db.Tbl_Cari
                                                          select new
                                                          {
                                                              x.ID,
                                                              x.Adi,
                                                              x.Soyadi
                                                          }).ToList();

            cmbPersonel.Properties.DataSource = (from y in db.Tbl_Personel
                                                   select new
                                                   {
                                                       y.ID,
                                                       y.Adi,
                                                       y.Soyadi
                                                   }).ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtSeri.Text = gridView1.GetFocusedRowCellValue("Seri").ToString();
            txtSiraNo.Text = gridView1.GetFocusedRowCellValue("SiraNo").ToString();
            txtTarih.Text = gridView1.GetFocusedRowCellValue("Tarih").ToString();
            txtSaat.Text = gridView1.GetFocusedRowCellValue("Saat").ToString();
            txtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VergiDaire").ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Tbl_FaturaBilgi deger = new Tbl_FaturaBilgi();
            deger.Seri = txtSeri.Text;
            deger.SiraNo = txtSiraNo.Text;
            deger.Tarih = DateTime.Parse(txtTarih.Text);
            deger.Saat = txtSaat.Text;
            deger.VergiDaire = txtVergiDairesi.Text;
            deger.CariID = int.Parse(cmbMusteriler.EditValue.ToString());
            deger.PersonelID = int.Parse(cmbPersonel.EditValue.ToString());

            db.Tbl_FaturaBilgi.Add(deger);
            db.SaveChanges();
            MessageBox.Show("Fatura Ekleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.Tbl_FaturaBilgi.Find(id);
            db.Tbl_FaturaBilgi.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Fatura Silme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.Tbl_FaturaBilgi.Find(id);
            deger.Seri = txtSeri.Text;
            deger.SiraNo = txtSiraNo.Text;
            deger.Tarih = DateTime.Parse(txtTarih.Text);
            deger.Saat = txtSaat.Text;
            deger.VergiDaire = txtVergiDairesi.Text;
            deger.CariID = int.Parse(cmbMusteriler.EditValue.ToString());
            deger.PersonelID = int.Parse(cmbPersonel.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Fatura Güncelleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();

        }
    }
}
