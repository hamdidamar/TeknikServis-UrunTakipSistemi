using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Forms
{
    public partial class FrmArizaListesi : Form
    {
        public FrmArizaListesi()
        {
            InitializeComponent();
        }
        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void FrmArizaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            var degerler = from x in db.Tbl_UrunKabul select new
            {
                x.ID,
                x.UrunSeriNo,
                //Urun = x.Tbl_Urun.Adi,
                Musteri = x.Tbl_Cari.Adi + x.Tbl_Cari.Soyadi,
                Personel = x.Tbl_Personel.Adi + x.Tbl_Personel.Soyadi,
                x.GelisTarih,
                x.CikisTarih,
                x.UrunDurumDetay

            };
            grdArizaListesi.DataSource = degerler.ToList();

            lblMevcutArizaliUrunSayisi.Text = db.Tbl_UrunKabul.Count(x=>x.Durum == true).ToString();
            lblOnarilmisUrunSayisi.Text = db.Tbl_UrunKabul.Count(x => x.Durum == false).ToString();
            lblToplamUrunSayisi.Text = db.Tbl_Urun.Count().ToString();
            lblParcaBekleyenUrunSayisi.Text = db.Tbl_UrunKabul.Count(x => x.UrunDurumDetay == "Parça Bekliyor").ToString();
            lblDonusBeklenenMusteriSayisi.Text = db.Tbl_UrunKabul.Count(x => x.UrunDurumDetay == "Dönüş Bekliyor").ToString();
            lblIptalEdilenOnarımSayisi.Text = db.Tbl_UrunKabul.Count(x => x.UrunDurumDetay == "İptal Edildi").ToString();

            //Pie Chart 
            SqlConnection bgl = new SqlConnection(@"Data Source=HAMDIDAMAR\SQL_2014;Initial Catalog=DboTeknikServis;Integrated Security=True");
            bgl.Open();

            SqlCommand cmd = new SqlCommand("SELECT UrunDurumDetay,COUNT(*) FROM Tbl_UrunKabul GROUP BY UrunDurumDetay", bgl);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(dr[0].ToString(), int.Parse(dr[1].ToString()));
            }
            bgl.Close();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            FrmArizaDetay fr = new FrmArizaDetay();
            fr.guncellenecekId = gridView2.GetFocusedRowCellValue("ID").ToString();
            fr.serino = gridView2.GetFocusedRowCellValue("UrunSeriNo").ToString();
            fr.Show();
        }
    }
}
