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
                uk.CariID = int.Parse(txtMusteriId.Text);
                uk.UrunSeriNo = txtSeriNo.Text;
                uk.PersonelID = int.Parse(txtPersonel.Text);
                uk.GelisTarih = DateTime.Parse(txtTarih.Text);

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
            this.Close();
        }
    }
}
