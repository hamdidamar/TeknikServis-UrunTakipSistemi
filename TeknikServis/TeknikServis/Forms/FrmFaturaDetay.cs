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
    public partial class FrmFaturaDetay : Form
    {
        public FrmFaturaDetay()
        {
            InitializeComponent();
        }
        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void FrmFaturaDetay_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            var degerler = from fd in db.Tbl_FaturaDetay
                           select new
                           {
                               fd.ID,
                               fd.Urun,
                               fd.Adet,
                               fd.Fiyat,
                               fd.Tutar,
                               fd.FaturaID
                           };
            grdFaturaDetayListesi.DataSource = degerler.ToList();

            cmbUrunler.Properties.DataSource = (from u in db.Tbl_Urun
                                                 select new
                                                 {
                                                     u.ID,
                                                     u.Adi,
                                                     u.Marka
                                                 }).ToList();


        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAdet.Text = gridView1.GetFocusedRowCellValue("Adet").ToString();
            txtFiyat.Text = gridView1.GetFocusedRowCellValue("Fiyat").ToString();
            txtTutar.Text = gridView1.GetFocusedRowCellValue("Tutar").ToString();
            txtFaturaID.Text = gridView1.GetFocusedRowCellValue("FaturaID").ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Tbl_FaturaDetay deger = new Tbl_FaturaDetay();
            deger.Urun = cmbUrunler.EditValue.ToString();
            deger.Adet = int.Parse(txtAdet.Text);
            deger.Fiyat = decimal.Parse(txtFiyat.Text);
            deger.Tutar = decimal.Parse(txtTutar.Text);
            deger.FaturaID = int.Parse(txtFaturaID.Text);

            db.Tbl_FaturaDetay.Add(deger);
            db.SaveChanges();
            MessageBox.Show("Fatura Detay Ekleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.Tbl_FaturaDetay.Find(id);
            db.Tbl_FaturaDetay.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Fatura Detay Silme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.Tbl_FaturaDetay.Find(id);
            deger.Urun = cmbUrunler.EditValue.ToString();
            deger.Adet = int.Parse(txtAdet.Text);
            deger.Fiyat = decimal.Parse(txtFiyat.Text);
            deger.Tutar = decimal.Parse(txtTutar.Text);
            deger.FaturaID = int.Parse(txtFaturaID.Text);
            db.SaveChanges();
            MessageBox.Show("Fatura Detay Güncelleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }
    }
}
