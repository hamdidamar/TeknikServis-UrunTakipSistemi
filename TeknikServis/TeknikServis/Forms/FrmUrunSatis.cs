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
                uh.UrunID = int.Parse(txtUrunId.Text);
                uh.UrunSeriNo = txtSeriNo.Text;
                uh.CariID = int.Parse(txtMusteri.Text);
                uh.PersonelID = int.Parse(txtPersonel.Text);
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
    }
}
