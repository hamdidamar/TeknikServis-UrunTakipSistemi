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
    public partial class FrmMusteriListesi : Form
    {
        public FrmMusteriListesi()
        {
            InitializeComponent();
        }

        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void FrmMusteriListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            grdMusteriListesi.DataSource = db.Tbl_Cari.ToList();
        }
    }
}
