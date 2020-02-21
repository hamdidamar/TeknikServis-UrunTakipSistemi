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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }
        DboTeknikServisEntities db = new DboTeknikServisEntities();
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            var degerler = db.Tbl_Urun.ToList();
            grdUrunListesi.DataSource = degerler;
        }
    }
}
