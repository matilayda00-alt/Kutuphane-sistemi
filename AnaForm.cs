using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using KutuphaneTakipSistemi.Models;

namespace KutuphaneTakipSistemi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            SayfaDegistir(new MenuSayfasi(this));
        }

        public void SayfaDegistir(UserControl yeniSayfa)
        {
            pnlContent.Controls.Clear();
            yeniSayfa.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(yeniSayfa);
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            SayfaDegistir(new MenuSayfasi(this));
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
