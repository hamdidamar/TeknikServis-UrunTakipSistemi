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
    public partial class FrmDepartmanListesi : Form
    {
        public FrmDepartmanListesi()
        {
            InitializeComponent();
        }
        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void FrmDepartmanListesi_Load(object sender, EventArgs e)
        {
            Listele();
            lblToplamDepartmanSayisi.Text = db.Tbl_Departman.Count().ToString();
            lblToplamPersonelSayisi.Text = db.Tbl_Personel.Count().ToString();
        }
        public void Listele()
        {
            var degerler = from d in db.Tbl_Departman
                           select new
                           {
                               d.ID,
                               d.Adi,
                               d.Aciklama
                           };
            grdDepartmanListesi.DataSource = degerler.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Tbl_Departman d = new Tbl_Departman();
            d.ID = int.Parse(txtId.Text);
            d.Adi = txtAd.Text;
            d.Aciklama = txtAciklama.Text;
            

            db.Tbl_Departman.Add(d);
            db.SaveChanges();
            MessageBox.Show("Departman Ekleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.Tbl_Departman.Find(id);
            db.Tbl_Departman.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Departman Silme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.Tbl_Departman.Find(id);
            deger.Adi = txtAd.Text;
            deger.Aciklama = txtAciklama.Text;
            db.SaveChanges();
            MessageBox.Show("Departman Güncelleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                txtAd.Text = gridView1.GetFocusedRowCellValue("Adi").ToString();
                txtAciklama.Text = gridView1.GetFocusedRowCellValue("Aciklama").ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Eksik veya Hatalı Bilgi Getirdiniz.");
            }
            
        }
    }
}
