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
        DboTeknikServisEntities db = new DboTeknikServisEntities();
        private void FrmMarkaIstatislik_Load(object sender, EventArgs e)
        {
            var degerler = db.Tbl_Urun.OrderBy(x => x.Marka).GroupBy(x => x.Marka).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            });
            grdMarkaIstatislik.DataSource = degerler.ToList();
        }
    }
}
