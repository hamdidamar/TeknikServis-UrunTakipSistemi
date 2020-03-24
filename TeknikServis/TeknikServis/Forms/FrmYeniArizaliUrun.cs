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
    public partial class FrmYeniArizaliUrun : Form
    {
        public FrmYeniArizaliUrun()
        {
            InitializeComponent();
        }
        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                Tbl_UrunKabul uk = new Tbl_UrunKabul();
                uk.CariID = int.Parse(cmbMusteriler.EditValue.ToString());
                uk.UrunSeriNo = txtSeriNo.Text;
                uk.PersonelID = int.Parse(cmbPersoneller.EditValue.ToString());
                uk.GelisTarih = DateTime.Parse(txtTarih.Text);
                uk.UrunDurumDetay = "Ürün Kaydoldu";
                uk.Durum = true;

                db.Tbl_UrunKabul.Add(uk);
                db.SaveChanges();
                MessageBox.Show("Kayıt İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Yapılırken Hata Oluştu !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            txtSeriNo.Text = "";
            txtTarih.Text="";
        }
        public void Listele()
        {
            cmbMusteriler.Properties.DataSource = (from x in db.Tbl_Cari
                                                    select new
                                                    {
                                                        x.ID,
                                                        x.Adi,
                                                        x.Soyadi
                                                    }).ToList();
            cmbPersoneller.Properties.DataSource = (from x in db.Tbl_Personel
                                                   select new
                                                   {
                                                       x.ID,
                                                       x.Adi,
                                                       x.Soyadi
                                                   }).ToList();
        }

        private void FrmYeniArizaliUrun_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSeriNo_Click(object sender, EventArgs e)
        {
            txtSeriNo.Text = "";
            txtSeriNo.Focus();
        }

        private void txtTarih_Click(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}
