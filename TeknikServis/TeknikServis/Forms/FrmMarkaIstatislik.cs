using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            lblEnFazlaUrunuOlanMarka.Text = db.MaxUrunMarka().FirstOrDefault().ToString();

            //Pie Chart 
            SqlConnection bgl = new SqlConnection(@"Data Source=HAMDIDAMAR\SQL_2014;Initial Catalog=DboTeknikServis;Integrated Security=True");
            bgl.Open();

            SqlCommand cmd = new SqlCommand("SELECT Marka,COUNT(*) FROM Tbl_Urun GROUP BY Marka",bgl);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(dr[0].ToString(), int.Parse(dr[1].ToString()));
            }
            bgl.Close();



            //Stacked Bar Chart
            bgl.Open();

            SqlCommand cmd1 = new SqlCommand("SELECT K.Adi,COUNT(*) FROM Tbl_Urun U INNER JOIN Tbl_Kategori K ON U.KategoriID = K.ID GROUP BY K.Adi", bgl);
            SqlDataReader dr2 = cmd1.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Kategoriler"].Points.AddPoint(dr2[0].ToString(), int.Parse(dr2[1].ToString()));
            }
            bgl.Close();



        }
    }
}
