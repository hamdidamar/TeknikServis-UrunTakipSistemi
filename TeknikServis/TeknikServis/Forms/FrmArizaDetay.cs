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
        public string guncellenecekId,serino;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                //Ürün Detay Ekleme
                Tbl_UrunTakip ut = new Tbl_UrunTakip();
                ut.SeriNo = txtSeriNo.Text;
                ut.SonTarih = DateTime.Parse(txtTarih.Text);
                ut.Durum = txtAciklama.Text;
                db.Tbl_UrunTakip.Add(ut);
                
                //Ürün Durum Detay Güncellemesi
                int id = int.Parse(guncellenecekId);
                Tbl_UrunKabul uk = new Tbl_UrunKabul();
                var deger = db.Tbl_UrunKabul.Find(id);
                deger.UrunDurumDetay = cmbUrunDurumDetay.Text;
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
            txtSeriNo.Text = serino;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            txtSeriNo.Text = "";
            txtTarih.Text = "";
        }

        private void txtTarih_Click(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void txtSeriNo_Click(object sender, EventArgs e)
        {
            txtSeriNo.Text = "";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
