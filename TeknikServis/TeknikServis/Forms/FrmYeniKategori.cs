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
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
                if (txtKategoriAd.Text != "" && txtKategoriAd.Text.Length <= 50)
                {
                    Tbl_Kategori kategori = new Tbl_Kategori();
                    kategori.Adi = txtKategoriAd.Text;
                    db.Tbl_Kategori.Add(kategori);
                    db.SaveChanges();
                    MessageBox.Show("Kategori Ekleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen Girdiğiniz Değerleri Kontrol Ediniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kategori Eklenirken Hata Oluştu !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmYeniKategori_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
