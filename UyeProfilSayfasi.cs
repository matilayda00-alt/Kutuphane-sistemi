using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using KutuphaneTakipSistemi.Models;

namespace KutuphaneTakipSistemi
{
    public partial class UyeProfilSayfasi : UserControl
    {
        private AnaForm anaForm;
        private Uye uye;

        public UyeProfilSayfasi(AnaForm form, Uye u)
        {
            InitializeComponent();
            this.anaForm = form;
            this.uye = u;
            this.Dock = DockStyle.Fill;
            UyeBilgileriniYukle();
        }

        private void UyeBilgileriniYukle()
        {
            lblAdSoyad.Text = uye.AdSoyad;
            lblTelefon.Text = "📞 " + (string.IsNullOrEmpty(uye.Telefon) ? "Belirtilmemiş" : uye.Telefon);
            lblEposta.Text = "✉ " + (string.IsNullOrEmpty(uye.Eposta) ? "Belirtilmemiş" : uye.Eposta);
            lblKayitTarihi.Text = "📅 Kayıt: " + uye.KayitTarihi.ToShortDateString();

            AktiviteGecmisiniYukle();
        }

        private void AktiviteGecmisiniYukle()
        {
            try
            {
                flpAktivite.Controls.Clear();

                string query = @"
                    SELECT O.KitapIsmi, O.IslemTipi, O.IslemTarihi, K.Kategori 
                    FROM OduncIslemleri O
                    LEFT JOIN Kitaplar K ON O.KitapIsmi = K.Ad
                    WHERE O.UyeIsmi = @UyeIsmi
                    ORDER BY O.Id DESC";

                var parameters = new[] { new Microsoft.Data.SqlClient.SqlParameter("@UyeIsmi", uye.AdSoyad) };
                var dt = DatabaseHelper.ExecuteQuery(query, parameters);

                foreach (System.Data.DataRow row in dt.Rows)
                {
                    Panel pnl = new Panel { Size = new Size(flpAktivite.Width - 25, 60), BackColor = Color.White, Margin = new Padding(0, 0, 0, 10) };
                    
                    string kitapIsmi = row["KitapIsmi"]?.ToString() ?? "Bilinmeyen Kitap";
                    string kategori = row["Kategori"]?.ToString() ?? "Genel";
                    string islemTipi = row["IslemTipi"]?.ToString() ?? "";
                    string tarihStr = row["IslemTarihi"]?.ToString() ?? "";

                    Label lbl = new Label
                    {
                        Text = $"{kitapIsmi} ({kategori}) - {islemTipi}\nTarih: {tarihStr}",
                        AutoSize = true,
                        Location = new Point(10, 10)
                    };
                    pnl.Controls.Add(lbl);
                    flpAktivite.Controls.Add(pnl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aktivite geçmişi yüklenirken hata: " + ex.Message);
            }
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            var cevap = MessageBox.Show($"'{uye.AdSoyad}' silinsin mi?", "Üye Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM Uyeler WHERE Id = @Id";
                    var parameters = new[] { new Microsoft.Data.SqlClient.SqlParameter("@Id", uye.Id) };
                    DatabaseHelper.ExecuteNonQuery(sql, parameters);

                    MessageBox.Show("Üye başarıyla silindi.", "Başarılı");
                    anaForm.SayfaDegistir(new UyelerSayfasi(anaForm));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Üye silinirken hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            anaForm.SayfaDegistir(new UyelerSayfasi(anaForm));
        }
    }
}