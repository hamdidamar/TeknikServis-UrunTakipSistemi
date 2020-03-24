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
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        int secilen;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
                Tbl_Cari musteri = new Tbl_Cari();
                musteri.Adi = txtMusteriAd.Text;
                musteri.Soyadi = txtMusteriSoyad.Text;
                musteri.Telefon = txtMusteriTelefon.Text;
                musteri.Mail = txtMusteriMail.Text;
                musteri.IL = cmbMusteriIL.EditValue.ToString();
                musteri.ILCE = cmbMusteriILCE.EditValue.ToString();
                musteri.Banka = txtMusteriBanka.Text;
                musteri.VergiDairesi = txtMusteriVDaire.Text;
                musteri.VergiNo = txtMusteriVNo.Text;
                musteri.Statu = txtMusteriStatu.Text;
                musteri.Adres = txtMusteriAdres.Text;

                db.Tbl_Cari.Add(musteri);
                db.SaveChanges();
                MessageBox.Show("Müşteri Ekleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Müşteri Eklenirken Hata Oluştu !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            txtMusteriAd.Text = "";
            txtMusteriSoyad.Text = "";
            txtMusteriTelefon.Text = "";
            txtMusteriMail.Text = "";
            txtMusteriBanka.Text = "";
            txtMusteriVDaire.Text = "";
            txtMusteriVNo.Text = "";
            txtMusteriStatu.Text = "";
            txtMusteriAdres.Text = "";
        }
        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            cmbMusteriIL.Properties.DataSource = (from x in db.Tbl_IL
                                                  select new
                                                  {
                                                      x.id,
                                                      x.sehir
                                                  }).ToList();
        }
        private void cmbMusteriIL_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(cmbMusteriIL.EditValue.ToString());
            cmbMusteriILCE.Properties.DataSource = (from x in db.Tbl_ILCE
                                                    select new
                                                    {
                                                        x.id,
                                                        x.ilce,
                                                        x.sehir
                                                    }).Where(z => z.sehir == secilen).ToList();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
