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
    public partial class FrmYouTube : Form
    {
        public FrmYouTube()
        {
            InitializeComponent();
        }

        private void FrmYouTube_Load(object sender, EventArgs e)
        {
            webrYouTube.Navigate("http://www.youtube.com");
        }
    }
}
