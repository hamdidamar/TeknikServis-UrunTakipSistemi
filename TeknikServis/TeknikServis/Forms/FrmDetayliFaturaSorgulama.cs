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
    public partial class FrmDetayliFaturaSorgulama : Form
    {
        public FrmDetayliFaturaSorgulama()
        {
            InitializeComponent();
        }

        private void txtSeriNo_EditValueChanged(object sender, EventArgs e)
        {

        }
        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void btnAra_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtFaturaId.Text);
            var degerler = (from fd in db.Tbl_FaturaDetay
                           select new
                           {
                               fd.ID,
                               fd.Urun,
                               fd.Adet,
                               fd.Fiyat,
                               fd.Tutar,
                               fd.FaturaID

                           }).Where(x => x.FaturaID == id);
            grdFaturaDetayListesi.DataSource = degerler.ToList();
        }
    }
}
