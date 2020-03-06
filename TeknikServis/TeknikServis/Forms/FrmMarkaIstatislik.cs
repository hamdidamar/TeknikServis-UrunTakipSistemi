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
    public partial class FrmMarkaIstatislik : Form
    {
        public FrmMarkaIstatislik()
        {
            InitializeComponent();
        }
        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void FrmMarkaIstatislik_Load(object sender, EventArgs e)
        {
            var degerler = db.Tbl_Urun.OrderBy(x => x.Marka).GroupBy(x => x.Marka).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            });
            grdMarkaIstatislik.DataSource = degerler.ToList();

            //LiNQ 
            lblToplamUrunSayisi.Text = db.Tbl_Urun.Count().ToString();
            lblToplamMarkaSayisi.Text = (from x in db.Tbl_Urun select x.Marka).Distinct().Count().ToString();
            lblEnYuksekFiyatliMarka.Text = (from x in db.Tbl_Urun
                                           orderby x.SatisFiyat descending
                                           select x.Marka).FirstOrDefault();
            //Pie Chart 
            chartControl1.Series["Series 1"].Points.AddPoint("Siemens", 4);
            chartControl1.Series["Series 1"].Points.AddPoint("Vestel", 20);
            chartControl1.Series["Series 1"].Points.AddPoint("Arçelik", 12);
            chartControl1.Series["Series 1"].Points.AddPoint("Arzum", 30);
            chartControl1.Series["Series 1"].Points.AddPoint("Samsung", 50);
            chartControl1.Series["Series 1"].Points.AddPoint("Toshiba", 42);

            //Stacked Bar Chart
            chartControl2.Series["Kategoriler"].Points.AddPoint("Beyaz Eşya", 15);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Bilgisayar", 8);
            chartControl2.Series["Kategoriler"].Points.AddPoint("TV", 19);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Küçük Ev Aletleri", 39);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Mobilya", 24);

        }
    }
}
