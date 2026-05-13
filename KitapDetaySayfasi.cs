using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using KutuphaneTakipSistemi.Models;

namespace KutuphaneTakipSistemi
{
    public partial class KitapDetaySayfasi : UserControl
    {
        private KitapBilgisi kitap;
        private AnaForm anaForm;

        public KitapDetaySayfasi(AnaForm form, KitapBilgisi k)
        {
            InitializeComponent();
            this.anaForm = form;
            this.kitap = k;
            this.Dock = DockStyle.Fill;
            VerileriDoldur();
        }

        private void VerileriDoldur()
        {
            lblKitapAdi.Text = kitap.Ad;
            lblYazar.Text = kitap.Yazar;
            lblKategori.Text = kitap.Kategori;
            txtOzet.Text = kitap.Ozet;

            if (kitap.Durum == "Mevcut")
            {
                pnlDurumIndicator.BackColor = Color.LightGreen;
                lblDurumYazi.Text = "● Kütüphanede Mevcut";
                lblDurumYazi.ForeColor = Color.DarkGreen;
                pnlOduncBilgi.Visible = false;
                pnlOduncVerme.Visible = true;

                dtpTeslimTarihi.MinDate = DateTime.Now.AddDays(1);
                dtpTeslimTarihi.MaxDate = DateTime.Now.AddDays(21);
                dtpTeslimTarihi.Value = DateTime.Now.AddDays(15);
                txtOduncAlanKisi.Clear();
            }
            else
            {
                pnlDurumIndicator.BackColor = Color.LightCoral;
                lblDurumYazi.Text = "● Şu an Ödünç Durumunda";
                lblDurumYazi.ForeColor = Color.DarkRed;
                
                pnlOduncBilgi.Visible = true;
                pnlOduncVerme.Visible = false;

                lblOduncAlan.Text = "Ödünç Alan: " + kitap.AlanKisi;
                lblVerilisTarihi.Text = "Veriliş Tarihi: " + kitap.VermisTarih;
                lblTeslimTarihi.Text = "Teslim Tarihi: " + kitap.AlinacakTarih;
            }
        }

        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            string alanKisi = txtOduncAlanKisi.Text.Trim();
            if (string.IsNullOrEmpty(alanKisi))
            {
                MessageBox.Show("Lütfen kitabı ödünç alan kişinin ismini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Uye? secilenUye = null;
            string uyeSorgu = "SELECT * FROM Uyeler WHERE AdSoyad = @AdSoyad";
            var parameters = new[] { new Microsoft.Data.SqlClient.SqlParameter("@AdSoyad", alanKisi) };
            var dtUye = DatabaseHelper.ExecuteQuery(uyeSorgu, parameters);

            if (dtUye.Rows.Count > 0)
            {
                var row = dtUye.Rows[0];
                secilenUye = new Uye { 
                    Id = Convert.ToInt32(row["Id"]), 
                    AdSoyad = row["AdSoyad"]?.ToString() ?? ""
                };
            }

            if (secilenUye == null)
            {
                MessageBox.Show($"'{alanKisi}' isimli bir kayıtlı üye bulunamadı!", "Hata");
                return;
            }

            string vermisTarih = DateTime.Now.ToString("dd.MM.yyyy");
            string alinacakTarih = dtpTeslimTarihi.Value.ToString("dd.MM.yyyy");
            
            string updateKitap = @"UPDATE Kitaplar SET 
                                   Durum = 'Ödünçte', 
                                   AlanUye = @AlanUye, 
                                   VerilisTarihi = @VerilisTarihi, 
                                   TeslimTarihi = @TeslimTarihi 
                                   WHERE Id = @Id";
            
            var updateParams = new[] {
                new Microsoft.Data.SqlClient.SqlParameter("@AlanUye", secilenUye.AdSoyad),
                new Microsoft.Data.SqlClient.SqlParameter("@VerilisTarihi", vermisTarih),
                new Microsoft.Data.SqlClient.SqlParameter("@TeslimTarihi", alinacakTarih),
                new Microsoft.Data.SqlClient.SqlParameter("@Id", kitap.Id)
            };
            DatabaseHelper.ExecuteNonQuery(updateKitap, updateParams);

            string insertIslem = @"INSERT INTO OduncIslemleri (KitapIsmi, UyeIsmi, IslemTarihi, IadeTarihi, IslemTipi) 
                                   VALUES (@KitapIsmi, @UyeIsmi, @IslemTarihi, @IadeTarihi, @IslemTipi)";
            
            var insertParams = new[] {
                new Microsoft.Data.SqlClient.SqlParameter("@KitapIsmi", kitap.Ad),
                new Microsoft.Data.SqlClient.SqlParameter("@UyeIsmi", secilenUye.AdSoyad),
                new Microsoft.Data.SqlClient.SqlParameter("@IslemTarihi", vermisTarih),
                new Microsoft.Data.SqlClient.SqlParameter("@IadeTarihi", alinacakTarih),
                new Microsoft.Data.SqlClient.SqlParameter("@IslemTipi", "Ödünç Alındı")
            };
            DatabaseHelper.ExecuteNonQuery(insertIslem, insertParams);

            kitap.Durum = "Ödünçte";
            kitap.AlanKisi = secilenUye.AdSoyad;
            kitap.VermisTarih = vermisTarih;
            kitap.AlinacakTarih = alinacakTarih;

            MessageBox.Show($"{kitap.Ad} kitabı ödünç verildi.", "Başarılı");
            VerileriDoldur();
        }

        private void btnKitapTeslimAl_Click(object sender, EventArgs e)
        {
            var cevap = MessageBox.Show("Kitabı kütüphaneye teslim almak istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                string iadeSql = @"INSERT INTO OduncIslemleri (KitapIsmi, UyeIsmi, IslemTarihi, IslemTipi) 
                                   VALUES (@KitapIsmi, @UyeIsmi, @IslemTarihi, @IslemTipi)";
                
                var iadeParams = new[] {
                    new Microsoft.Data.SqlClient.SqlParameter("@KitapIsmi", kitap.Ad),
                    new Microsoft.Data.SqlClient.SqlParameter("@UyeIsmi", kitap.AlanKisi),
                    new Microsoft.Data.SqlClient.SqlParameter("@IslemTarihi", DateTime.Now.ToString("dd.MM.yyyy")),
                    new Microsoft.Data.SqlClient.SqlParameter("@IslemTipi", "İade Edildi")
                };
                DatabaseHelper.ExecuteNonQuery(iadeSql, iadeParams);

                string updateSql = @"UPDATE Kitaplar SET 
                                     Durum = 'Mevcut', 
                                     AlanUye = NULL, 
                                     VerilisTarihi = NULL, 
                                     TeslimTarihi = NULL 
                                     WHERE Id = @Id";
                
                var updateParams = new[] {
                    new Microsoft.Data.SqlClient.SqlParameter("@Id", kitap.Id)
                };
                DatabaseHelper.ExecuteNonQuery(updateSql, updateParams);

                kitap.Durum = "Mevcut";
                kitap.AlanKisi = "";
                kitap.VermisTarih = "";
                kitap.AlinacakTarih = "";

                MessageBox.Show("Kitap başarıyla kütüphaneye teslim alındı ve veritabanı güncellendi.", "Bilgi");
                VerileriDoldur();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            anaForm.SayfaDegistir(new KitaplarSayfasi(anaForm));
        }
    }
}
