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
    public partial class FrmPersonelListesi : Form
    {
        public FrmPersonelListesi()
        {
            InitializeComponent();
        }
        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void FrmPersonelListesi_Load(object sender, EventArgs e)
        {
            Listele();
            AyinPersoneli();
        }
        public void Listele()
        {
            var degerler = from p in db.Tbl_Personel
                           select new
                           {
                               p.ID,
                               p.Adi,
                               p.Soyadi,
                               p.Mail,
                               p.Telefon,
                               p.Fotograf,
                               Departman = p.Tbl_Departman.Adi
                           };
            grdDepartmanListesi.DataSource = degerler.ToList();

            cmbPersonelDepartman.Properties.DataSource = (from x in db.Tbl_Departman
                                                         select new
                                                         {
                                                             x.ID,
                                                             x.Adi
                                                         }).ToList();
        }
        public void AyinPersoneli()
        {
            string ad1, soyad1, ad2, soyad2, ad3, soyad3, ad4, soyad4;


            //Personel 1
            ad1 = db.Tbl_Personel.First(x => x.ID == 1).Adi;
            soyad1 = db.Tbl_Personel.First(x => x.ID == 1).Soyadi;
            lblPersonel1Ad.Text = ad1 +"" + soyad1;
            lblPersonel1Departman.Text = db.Tbl_Personel.First(x => x.ID == 1).Tbl_Departman.Adi;
            lblPersonelMail.Text = db.Tbl_Personel.First(x => x.ID == 1).Mail;

            //Personel 2
            ad2 = db.Tbl_Personel.First(x => x.ID == 2).Adi;
            soyad2 = db.Tbl_Personel.First(x => x.ID == 2).Soyadi;
            lblPersonel2Ad.Text = ad2 + "" + soyad2;
            lblPersonel2Departman.Text = db.Tbl_Personel.First(x => x.ID == 2).Tbl_Departman.Adi;
            lblPersonel2Mail.Text = db.Tbl_Personel.First(x => x.ID == 2).Mail;

            //Personel 3
            ad3 = db.Tbl_Personel.First(x => x.ID == 3).Adi;
            soyad3 = db.Tbl_Personel.First(x => x.ID == 3).Soyadi;
            lblPersonel3Ad.Text = ad3 + "" + soyad3;
            lblPersonel3Departman.Text = db.Tbl_Personel.First(x => x.ID == 3).Tbl_Departman.Adi;
            lblPersonel3Mail.Text = db.Tbl_Personel.First(x => x.ID == 3).Mail;

            //Personel 4
            ad4 = db.Tbl_Personel.First(x => x.ID == 4).Adi;
            soyad4 = db.Tbl_Personel.First(x => x.ID == 4).Soyadi;
            lblPersonel4Ad.Text = ad4 + "" + soyad4;
            lblPersonel4Departman.Text = db.Tbl_Personel.First(x => x.ID == 4).Tbl_Departman.Adi;
            lblPersonel4Mail.Text = db.Tbl_Personel.First(x => x.ID == 4).Mail;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Tbl_Personel p = new Tbl_Personel();
            p.Adi = txtPersonelAd.Text;
            p.Soyadi = txtPersonelSoyad.Text;
            p.Mail = txtPersonelMail.Text;
            p.Telefon = txtPersonelTelefon.Text;
            p.Fotograf = txtPersonelTelefon.Text;
            p.DepartmanID = int.Parse(cmbPersonelDepartman.EditValue.ToString());

            db.Tbl_Personel.Add(p);
            db.SaveChanges();
            MessageBox.Show("Personel Ekleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtPersonelId.Text);
            var deger = db.Tbl_Personel.Find(id);
            db.Tbl_Personel.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Personel Silme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtPersonelId.Text);
            var deger = db.Tbl_Personel.Find(id);
            deger.Adi = txtPersonelAd.Text;
            deger.Soyadi = txtPersonelSoyad.Text;
            deger.Mail = txtPersonelMail.Text;
            deger.Telefon = txtPersonelTelefon.Text;
            deger.Fotograf = txtPersonelFoto.Text;
            deger.DepartmanID = int.Parse(cmbPersonelDepartman.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Personel Güncelleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtPersonelId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtPersonelAd.Text = gridView1.GetFocusedRowCellValue("Adi").ToString();
            txtPersonelSoyad.Text = gridView1.GetFocusedRowCellValue("Soyadi").ToString();
            txtPersonelMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            txtPersonelTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            txtPersonelFoto.Text = gridView1.GetFocusedRowCellValue("Fotograf").ToString();
        }
    }
}
