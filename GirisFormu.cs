using System;
using System.Drawing;
using System.Windows.Forms;

namespace KutuphaneTakipSistemi
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string sifre = txtSifre.Text;

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(sifre))
            {
                lblMesaj.ForeColor = Color.Red;
                lblMesaj.Text = "Lütfen tüm alanları doldurun!";
                return;
            }

            if (ad == "admin" && sifre == "hostadmin1591")
            {
                MessageBox.Show("Yönetici girişi başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                AnaForm anaPanel = new AnaForm();
                anaPanel.Show();
                this.Hide();
            }
            else
            {
                lblMesaj.ForeColor = Color.Red;
                lblMesaj.Text = "Hatalı kullanıcı adı veya şifre!";
            }
        }
    }
}
