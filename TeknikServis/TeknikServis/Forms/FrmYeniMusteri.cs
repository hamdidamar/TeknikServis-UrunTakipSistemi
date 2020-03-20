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
                musteri.IL = txtMusteriİl.Text;
                musteri.ILCE = txtMusteriİlce.Text;
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
            this.Close();
        }
    }
}
