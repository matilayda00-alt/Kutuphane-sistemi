using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using KutuphaneTakipSistemi.Models;

namespace KutuphaneTakipSistemi
{
    public partial class UyelerSayfasi : UserControl
    {
        private AnaForm anaForm;
        private List<Uye> uyeler = new List<Uye>();

        public UyelerSayfasi(AnaForm form)
        {
            InitializeComponent();
            this.anaForm = form;
            this.Dock = DockStyle.Fill;

            UyeleriYukle();
        }

        private void UyeleriYukle()
        {
            try
            {
                uyeler.Clear();
                string sql = "SELECT * FROM Uyeler";
                var dt = DatabaseHelper.ExecuteQuery(sql);

                foreach (System.Data.DataRow row in dt.Rows)
                {
                    uyeler.Add(new Uye
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        AdSoyad = row["AdSoyad"]?.ToString() ?? "",
                        Telefon = row["Telefon"]?.ToString() ?? "",
                        Eposta = row["Eposta"]?.ToString() ?? "",
                        KayitTarihi = row["KayitTarihi"] != DBNull.Value ? Convert.ToDateTime(row["KayitTarihi"]) : DateTime.Now
                    });
                }

                UyeKartlariniGoster(uyeler);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Üyeler yüklenirken bir hata oluştu: " + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UyeKartlariniGoster(List<Uye> liste)
        {
            flpUyeler.Controls.Clear();

            foreach (var u in liste)
            {
                Panel pnl = new Panel();
                pnl.Size = new Size(200, 100);
                pnl.BackColor = Color.White;
                pnl.Margin = new Padding(10);
                pnl.Cursor = Cursors.Hand;
                pnl.Click += (s, e) => anaForm.SayfaDegistir(new UyeProfilSayfasi(anaForm, u));

                Label lblAd = new Label();
                lblAd.Text = u.AdSoyad;
                lblAd.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
                lblAd.Location = new Point(10, 10);
                lblAd.AutoSize = true;
                lblAd.Click += (s, e) => anaForm.SayfaDegistir(new UyeProfilSayfasi(anaForm, u));

                Label lblTel = new Label();
                lblTel.Text = u.Telefon;
                lblTel.Font = new Font("Segoe UI", 9);
                lblTel.ForeColor = Color.Gray;
                lblTel.Location = new Point(10, 35);
                lblTel.AutoSize = true;
                lblTel.Click += (s, e) => anaForm.SayfaDegistir(new UyeProfilSayfasi(anaForm, u));

                pnl.Controls.Add(lblAd);
                pnl.Controls.Add(lblTel);
                flpUyeler.Controls.Add(pnl);
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string arama = txtArama.Text.ToLower();
            var filtrelenmis = uyeler.FindAll(u => u.AdSoyad.ToLower().Contains(arama));
            UyeKartlariniGoster(filtrelenmis);
        }
    }
}