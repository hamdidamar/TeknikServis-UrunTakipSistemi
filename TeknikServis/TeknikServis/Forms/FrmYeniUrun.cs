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
                DboTeknikServisEntities db = new DboTeknikServisEntities();
                Tbl_Urun urun = new Tbl_Urun();
                urun.Adi = txtUrunAd.Text;
                urun.Marka = txtMarka.Text;
                //urun.Tbl_Kategori.ID = int.Parse(txtKategori.Text);
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
    }
}
