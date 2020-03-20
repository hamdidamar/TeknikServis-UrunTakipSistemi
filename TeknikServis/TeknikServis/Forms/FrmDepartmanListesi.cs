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
    public partial class FrmDepartmanListesi : Form
    {
        public FrmDepartmanListesi()
        {
            InitializeComponent();
        }
        DboTeknikServisEntities1 db = new DboTeknikServisEntities1();
        private void FrmDepartmanListesi_Load(object sender, EventArgs e)
        {
            Listele();
            lblToplamDepartmanSayisi.Text = db.Tbl_Departman.Count().ToString();
            lblToplamPersonelSayisi.Text = db.Tbl_Personel.Count().ToString();
        }
        public void Listele()
        {
            var degerler = from d in db.Tbl_Departman
                           select new
                           {
                               d.ID,
                               d.Adi,
                               d.Aciklama
                           };
            grdDepartmanListesi.DataSource = degerler.ToList();
        }
    }
}
