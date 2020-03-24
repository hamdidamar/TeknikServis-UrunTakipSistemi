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
    public partial class FrmUrunSatis : Form
    {
        public FrmUrunSatis()
        {
            InitializeComponent();
        }
        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void btnSatis_Click(object sender, EventArgs e)
        {
            try
            {
                Tbl_UrunHareket uh = new Tbl_UrunHareket();
                uh.UrunID = int.Parse(cmbUrunler.EditValue.ToString());
                uh.UrunSeriNo = txtSeriNo.Text;
                uh.CariID = int.Parse(cmbMusteriler.EditValue.ToString());
                uh.PersonelID = int.Parse(cmbPersoneller.EditValue.ToString());
                uh.Tarih = DateTime.Parse(txtTarih.Text);
                uh.Adet = int.Parse(txtAdet.Text);
                uh.Fiyat = decimal.Parse(txtSatisFiyat.Text);

                db.Tbl_UrunHareket.Add(uh);
                db.SaveChanges();
                MessageBox.Show("Satış İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Satış Yapılırken Hata Oluştu !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUrunSatis_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            cmbUrunler.Properties.DataSource = (from x in db.Tbl_Urun
                                                  select new
                                                  {
                                                      x.ID,
                                                      x.Adi
                                                  }).ToList();
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

        private void txtTarih_Click(object sender, EventArgs e)
        {
            txtTarih.Text = "";
            txtTarih.Focus();
        }

        private void txtAdet_Click(object sender, EventArgs e)
        {
            txtAdet.Text = "";
            txtAdet.Focus();
        }

        private void txtSatisFiyat_Click(object sender, EventArgs e)
        {
            txtSatisFiyat.Text = "";
            txtSatisFiyat.Focus();
        }

        private void txtSeriNo_Click(object sender, EventArgs e)
        {
            txtSeriNo.Text = "";
            txtSeriNo.Focus();
        }
    }
}
