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
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
                Tbl_Urun urun = new Tbl_Urun();
                urun.Adi = txtUrunAd.Text;
                urun.Marka = txtMarka.Text;
                urun.KategoriID = int.Parse(cmbKategoriler.EditValue.ToString());
                urun.AlisFiyat = decimal.Parse(txtAlisFiyat.Text);
                urun.SatisFiyat = decimal.Parse(txtSatisFiyat.Text);
                urun.StokSayisi = int.Parse(txtStokMiktar.Text);

                db.Tbl_Urun.Add(urun);
                db.SaveChanges();
                MessageBox.Show("Ürün Ekleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ürün Eklenirken Hata Oluştu !","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            txtUrunAd.Text = "Ürün Adı";
            txtMarka.Text = "Marka";
            txtAlisFiyat.Text = "Alış Fiyatı";
            txtSatisFiyat.Text = "Satış Fiyatı";
            txtStokMiktar.Text = "Stok Miktarı";
        }
        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            cmbKategoriler.Properties.DataSource = (from x in db.Tbl_Kategori
                                                    select new
                                                    {
                                                        x.ID,
                                                        x.Adi
                                                    }).ToList();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtUrunAd_Click(object sender, EventArgs e)
        {
            txtUrunAd.Text = "";
            txtUrunAd.Focus();
        }

        private void txtMarka_Click(object sender, EventArgs e)
        {
            txtMarka.Text = "";
            txtMarka.Focus();
        }

        private void txtAlisFiyat_Click(object sender, EventArgs e)
        {
            txtAlisFiyat.Text = "";
            txtAlisFiyat.Focus();
        }

        private void txtSatisFiyat_Click(object sender, EventArgs e)
        {
            txtSatisFiyat.Text = "";
            txtSatisFiyat.Focus();
        }

        private void txtStokMiktar_Click(object sender, EventArgs e)
        {
            txtStokMiktar.Text = "";
            txtStokMiktar.Focus();
        }
    }
}
