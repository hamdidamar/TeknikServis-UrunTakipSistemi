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
    public partial class FrmMusteriIlIstatislik : Form
    {
        public FrmMusteriIlIstatislik()
        {
            InitializeComponent();
        }
        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        SqlConnection bgl = new SqlConnection(@"Data Source=HAMDIDAMAR\SQL_2014;Initial Catalog=DboTeknikServis;Integrated Security=True");
        private void FrmMusteriIlIstatislik_Load(object sender, EventArgs e)
        {
            SehirGetir();
            grdMusteriListesi.DataSource = db.Tbl_Cari.OrderBy(x => x.IL).GroupBy(y => y.IL).Select(z => new { İL = z.Key, TOPLAM = z.Count() }).ToList();

            
        }
        public void SehirGetir()
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("SELECT IL,COUNT(*) FROM Tbl_Cari GROUP BY IL", bgl);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(dr[0].ToString(), int.Parse(dr[1].ToString()));
            }
            bgl.Close();
        }
    }
}
