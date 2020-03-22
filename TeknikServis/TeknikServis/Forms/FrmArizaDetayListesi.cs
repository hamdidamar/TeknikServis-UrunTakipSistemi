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
    public partial class FrmArizaDetayListesi : Form
    {
        public FrmArizaDetayListesi()
        {
            InitializeComponent();
        }
        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void FrmArizaDetayListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            var degerler = from ut in db.Tbl_UrunTakip
                           select new
                           {
                               ut.ID,
                               ut.SeriNo,
                               ut.SonTarih,
                               ut.Durum

                           };
            grdArizaDetayListesi.DataSource = degerler.ToList();
        }
    }
}
