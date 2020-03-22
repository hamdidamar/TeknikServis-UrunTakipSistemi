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
    public partial class FrmArizaDetay : Form
    {
        public FrmArizaDetay()
        {
            InitializeComponent();
        }
        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Tbl_UrunTakip ut = new Tbl_UrunTakip();
                ut.SeriNo = txtSeriNo.Text;
                ut.SonTarih = DateTime.Parse(txtTarih.Text);
                ut.Durum = txtAciklama.Text;

                db.Tbl_UrunTakip.Add(ut);
                db.SaveChanges();
                MessageBox.Show("Arızalı Ürün Açıklama Güncelleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Arızalı Ürün Açıklama Güncellenirken  Hata Oluştu !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmArizaDetay_Load(object sender, EventArgs e)
        {

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
