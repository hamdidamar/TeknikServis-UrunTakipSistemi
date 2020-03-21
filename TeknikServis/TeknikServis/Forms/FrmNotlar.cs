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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            grdNotOkunmayanListesi.DataSource = db.Tbl_Not.Where(x => x.Durum == false).ToList();
            grdNotOkunan.DataSource = db.Tbl_Not.Where(x => x.Durum == true).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Tbl_Not n = new Tbl_Not();
            n.Baslik = txtNotBaslik.Text;
            n.Icerik = txtNotIcerik.Text;
            n.Durum = false;
            db.Tbl_Not.Add(n);
            db.SaveChanges();
            MessageBox.Show("Not Ekleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (chdurum.Checked == true)
            {
                int id = int.Parse(txtNotId.Text);
                var deger = db.Tbl_Not.Find(id);
                deger.Baslik = txtNotBaslik.Text;
                deger.Icerik = txtNotIcerik.Text;
                deger.Durum = true;

                db.SaveChanges();
                MessageBox.Show("Not Güncelleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            if (chdurum.Checked == false)
            {
                int id = int.Parse(txtNotId.Text);
                var deger = db.Tbl_Not.Find(id);
                deger.Baslik = txtNotBaslik.Text;
                deger.Icerik = txtNotIcerik.Text;
                deger.Durum = false;

                db.SaveChanges();
                MessageBox.Show("Not Güncelleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtNotId.Text);
            var deger = db.Tbl_Not.Find(id);
            db.Tbl_Not.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Not Silme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtNotId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtNotBaslik.Text = gridView1.GetFocusedRowCellValue("Baslik").ToString();
            txtNotIcerik.Text = gridView1.GetFocusedRowCellValue("Icerik").ToString();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtNotId.Text = gridView2.GetFocusedRowCellValue("ID").ToString();
            txtNotBaslik.Text = gridView2.GetFocusedRowCellValue("Baslik").ToString();
            txtNotIcerik.Text = gridView2.GetFocusedRowCellValue("Icerik").ToString();
        }
    }
}
