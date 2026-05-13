using System;
using System.Drawing;
using System.Windows.Forms;

namespace KutuphaneTakipSistemi
{
    public partial class MenuSayfasi : UserControl
    {
        private AnaForm anaForm;

        public MenuSayfasi(AnaForm form)
        {
            InitializeComponent();
            this.anaForm = form;
            this.Dock = DockStyle.Fill;
        }

        private void btnKitaplar_Click(object sender, EventArgs e)
        {
            anaForm.SayfaDegistir(new KitaplarSayfasi(anaForm));
        }

        private void btnUyeler_Click(object sender, EventArgs e)
        {
            anaForm.SayfaDegistir(new UyelerSayfasi(anaForm));
        }

        private void btnUyeKayit_Click(object sender, EventArgs e)
        {
            anaForm.SayfaDegistir(new UyeKayitSayfasi(anaForm));
        }
    }
}