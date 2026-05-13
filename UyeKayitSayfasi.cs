using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using KutuphaneTakipSistemi.Models;

namespace KutuphaneTakipSistemi
{
    public partial class UyeKayitSayfasi : UserControl
    {
        private AnaForm anaForm;

        public UyeKayitSayfasi(AnaForm form)
        {
            InitializeComponent();
            this.anaForm = form;
            this.Dock = DockStyle.Fill;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string adSoyad = txtAdSoyad.Text.Trim();
            string telefon = txtTelefon.Text.Trim();
            string eposta = txtEposta.Text.Trim();

            if (string.IsNullOrEmpty(adSoyad))
            {
                MessageBox.Show("Ad Soyad alanı boş bırakılamaz!", "Uyarı");
                return;
            }

            try
            {
                string query = "INSERT INTO Uyeler (AdSoyad, Telefon, Eposta, KayitTarihi) VALUES (@AdSoyad, @Telefon, @Eposta, GETDATE())";
                var parameters = new[] {
                    new Microsoft.Data.SqlClient.SqlParameter("@AdSoyad", adSoyad),
                    new Microsoft.Data.SqlClient.SqlParameter("@Telefon", telefon),
                    new Microsoft.Data.SqlClient.SqlParameter("@Eposta", eposta)
                };
                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Üye tüm bilgileriyle başarıyla veritabanına kaydedildi.", "Başarılı");
                txtAdSoyad.Clear();
                txtTelefon.Clear();
                txtEposta.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Üye kaydedilirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtEposta.Clear();
        }
    }
}
