using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Fishy_Projek.Models;
using Fishy_Projek.Repositories;

namespace Fishy_Projek
{
    public partial class FormUtama : Form
    {
        private User _userLogin;
        private LaporanRepository _laporanRepo = new LaporanRepository();
        private MasterRepository _masterRepo = new MasterRepository();
        private OperasionalRepository _opsRepo = new OperasionalRepository();

        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelSidebar.Visible = false;
            panelKonten.Visible = false;
            panelTitleBar.BringToFront();

            panelDashboard.Parent = panelKonten;
            panelStok.Parent = panelKonten;
            panelInputSuhu.Parent = panelKonten;
            panelPengiriman.Parent = panelKonten;
            panelLaporan.Parent = panelKonten;
            panelMaster.Parent = panelKonten;

            // --- TAMBAHKAN BARIS INI UNTUK MENGAMANKAN TABEL YANG HILANG ---
            // 1. Paksa tabel masuk ke kandang panelnya
            dgvStok.Parent = panelStok;
            dgvLaporan.Parent = panelLaporan;


            // 2. Paksa tabelnya muncul ke depan
            dgvStok.BringToFront();

            // 3. Paksa ukurannya memenuhi panel putih tersebut
            dgvStok.Dock = DockStyle.Fill;

            // (Lakukan hal yang sama untuk tabel di panel lain kalau ada yang hilang)

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // 1. Validasi awal
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Username dan password tidak boleh kosong!";
                return;
                panelTitleBar.BringToFront();
            }

            try
            {
                // 2. Tambahkan indikator agar tahu sistem sedang memproses
                Cursor = Cursors.WaitCursor;

                _userLogin = _opsRepo.Login(username, password);

                if (_userLogin != null)
                {
                    lblError.Text = "";
                    lblNamaUser.Text = "Halo, " + _userLogin.Nama;
                    lblRoleUser.Text = _userLogin.IdRole == 1 ? "Manajer" : "Operator";

                    // 1. Sembunyikan Login, Munculkan Sidebar & Konten
                    panelLogin.Visible = false;
                    panelSidebar.Visible = true;
                    panelKonten.Visible = true;

                    // 2. PASTI-KAN panel ini muncul di depan
                    panelSidebar.BringToFront();
                    panelKonten.BringToFront();

                    // 3. Logika pindah panel: Ini bagian terpenting agar tidak kosong
                    if (_userLogin.IdRole == 1)
                    {
                        // Tampilkan Dashboard untuk Manajer
                        TampilkanPanel(panelDashboard, btnDashboard, "Dashboard");
                        LoadDashboard(); // Panggil fungsi ini agar datanya terisi!
                    }
                    else
                    {
                        // Tampilkan Stok untuk Operator
                        TampilkanPanel(panelStok, btnStok, "Stok & Ruangan");
                        LoadStok(); // Panggil fungsi ini agar datanya terisi!
                    }
                }
            }
            catch (Exception ex)
            {
                // 3. Menangkap error database agar tidak bikin aplikasi stuck
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 4. Pastikan kursor balik normal apapun hasilnya
                Cursor = Cursors.Default;
            }
        }

        private void TampilkanPanel(Panel panel, Button tombolAktif, string judul)
        {
            panelDashboard.Visible = false;
            panelStok.Visible = false;
            panelInputSuhu.Visible = false;
            panelPengiriman.Visible = false;
            panelLaporan.Visible = false;
            panelMaster.Visible = false;

            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.ForeColor = Color.MidnightBlue;
            btnStok.BackColor = Color.Transparent;
            btnStok.ForeColor = Color.MidnightBlue;
            btnInputSuhu.BackColor = Color.Transparent;
            btnInputSuhu.ForeColor = Color.MidnightBlue;
            btnPengiriman.BackColor = Color.Transparent;
            btnPengiriman.ForeColor = Color.MidnightBlue;
            btnLaporan.BackColor = Color.Transparent;
            btnLaporan.ForeColor = Color.MidnightBlue;
            btnMaster.BackColor = Color.Transparent;
            btnMaster.ForeColor = Color.MidnightBlue;

            panelTitleBar.BringToFront();
            panelSidebar.BringToFront();

            panel.Visible = true;
            tombolAktif.BackColor = Color.LightCyan;
            tombolAktif.ForeColor = Color.MidnightBlue;
            lblPageTitle.Text = judul;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            TampilkanPanel(panelDashboard, btnDashboard, "Dashboard");
            LoadDashboard();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            TampilkanPanel(panelStok, btnStok, "Stok & Ruangan");
            LoadStok();
        }

        private void btnInputSuhu_Click(object sender, EventArgs e)
        {
            TampilkanPanel(panelInputSuhu, btnInputSuhu, "Input Suhu");
            LoadRuanganComboBox();
        }

        private void btnPengiriman_Click(object sender, EventArgs e)
        {
            TampilkanPanel(panelPengiriman, btnPengiriman, "Pengiriman");
            LoadStokComboBox();
            txtIdPengiriman.Text = "TX-" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            TampilkanPanel(panelLaporan, btnLaporan, "Laporan");
            LoadLaporan();
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            TampilkanPanel(panelMaster, btnMaster, "Master Data");
            LoadMaster();
            panelTitleBar.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var konfirmasi = MessageBox.Show(
                "Apakah kamu yakin ingin logout?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                _userLogin = null;
                panelLogin.Visible = true;
                panelSidebar.Visible = false;
                panelKonten.Visible = false;
                txtUsername.Clear();
                txtPassword.Clear();
                lblError.Text = "";
            }
        }

        private void LoadDashboard()
        {
            try
            {
                var stokList = _laporanRepo.GetRingkasanStok();
                lblTotalUnit.Text = stokList.Count.ToString();

                double totalKg = 0;
                foreach (var s in stokList) totalKg += s.KuantitasAwalKg;
                lblKapasitas.Text = totalKg.ToString("N0") + " kg";

                dgvRingkasanStok.DataSource = stokList;
                dgvKondisiRuangan.DataSource = stokList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load dashboard: " + ex.Message);
            }
        }

        private void LoadStok()
        {
            try
            {
                var stokList = _laporanRepo.GetRingkasanStok();
                dgvStok.DataSource = stokList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load stok: " + ex.Message);
            }
        }

        private void LoadRuanganComboBox()
        {
            try
            {
                var ruanganList = _masterRepo.GetAllRuang();
                cmbRuanganSuhu.DataSource = ruanganList;
                cmbRuanganSuhu.DisplayMember = "NamaRuang";
                cmbRuanganSuhu.ValueMember = "IdRuang";

                cmbGradeMutu.Items.Clear();
                cmbGradeMutu.Items.AddRange(new string[] { "A", "B", "C", "D" });
                cmbGradeMutu.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load ruangan: " + ex.Message);
            }
        }

        private void LoadStokComboBox()
        {
            try
            {
                var stokList = _laporanRepo.GetRingkasanStok();
                cmbStokKirim.DataSource = stokList;
                cmbStokKirim.DisplayMember = "NamaIkan";
                cmbStokKirim.ValueMember = "IdStok";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load stok combobox: " + ex.Message);
            }
        }

        private void LoadLaporan()
        {
            try
            {
                cmbFilterMutasi.Items.Clear();
                cmbFilterMutasi.Items.AddRange(new string[] { "SEMUA", "MASUK", "KELUAR" });
                cmbFilterMutasi.SelectedIndex = 0;

                var mutasiList = _laporanRepo.GetRiwayatMutasi("SEMUA");
                dgvLaporan.DataSource = mutasiList;

                // Grafik mutasi cuma muncul buat Manajer (IdRole == 1)
                bool isManajer = _userLogin != null && _userLogin.IdRole == 1;
                lblGrafikTitle.Visible = isManajer;
                formsPlotMutasi.Visible = isManajer;

                // Operator: tabel pakai lebar penuh karena chart disembunyikan
                dgvLaporan.Width = isManajer ? 540 : 920;

                if (isManajer)
                {
                    LoadGrafikMutasi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load laporan: " + ex.Message);
            }
        }

        private void LoadGrafikMutasi()
        {
            try
            {
                var data = _laporanRepo.GetGrafikMutasiHarian(14);

                formsPlotMutasi.Plot.Clear();

                var bars = new List<ScottPlot.Bar>();
                var ticks = new List<ScottPlot.Tick>();

                double posisi = 0;
                foreach (var d in data)
                {
                    bars.Add(new ScottPlot.Bar
                    {
                        Position = posisi,
                        Value = d.TotalMasukKg,
                        FillColor = ScottPlot.Colors.SteelBlue
                    });
                    bars.Add(new ScottPlot.Bar
                    {
                        Position = posisi + 1,
                        Value = d.TotalKeluarKg,
                        FillColor = ScottPlot.Colors.IndianRed
                    });

                    ticks.Add(new ScottPlot.Tick(posisi + 0.5, d.Tanggal.ToString("dd/MM")));

                    posisi += 3; // jarak antar grup tanggal
                }

                formsPlotMutasi.Plot.Add.Bars(bars);

                formsPlotMutasi.Plot.Axes.Bottom.TickGenerator =
                    new ScottPlot.TickGenerators.NumericManual(ticks.ToArray());
                formsPlotMutasi.Plot.Axes.Bottom.TickLabelStyle.Rotation = 45;
                formsPlotMutasi.Plot.Axes.Margins(bottom: 0.15);

                formsPlotMutasi.Plot.Title("Mutasi Stok: Masuk vs Keluar (kg)");
                formsPlotMutasi.Plot.Axes.Bottom.Label.Text = "Tanggal";
                formsPlotMutasi.Plot.Axes.Left.Label.Text = "Kg";

                // Legend manual karena warnanya per-jenis, bukan per-series otomatis
                formsPlotMutasi.Plot.Legend.IsVisible = true;
                formsPlotMutasi.Plot.Legend.Alignment = ScottPlot.Alignment.UpperLeft;
                formsPlotMutasi.Plot.Legend.ManualItems.Clear();
                formsPlotMutasi.Plot.Legend.ManualItems.Add(new ScottPlot.LegendItem
                {
                    LabelText = "Masuk",
                    FillColor = ScottPlot.Colors.SteelBlue
                });
                formsPlotMutasi.Plot.Legend.ManualItems.Add(new ScottPlot.LegendItem
                {
                    LabelText = "Keluar",
                    FillColor = ScottPlot.Colors.IndianRed
                });

                formsPlotMutasi.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load grafik mutasi: " + ex.Message);
            }
        }

        private void LoadMaster()
        {
            try
            {
                dgvIkan.DataSource = _masterRepo.GetAllIkan();
                dgvGudang.DataSource = _masterRepo.GetAllGudang();
                dgvRuang.DataSource = _masterRepo.GetAllRuang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load master: " + ex.Message);
            }
        }

        private void btnSimpanSuhu_Click(object sender, EventArgs e)
        {
            try
            {
                string idRuang = cmbRuanganSuhu.SelectedValue.ToString();
                double suhu = double.Parse(txtSuhuAktual.Text);
                string grade = cmbGradeMutu.SelectedItem.ToString();
                string catatan = txtCatatanSuhu.Text;

                _opsRepo.InputSuhu(idRuang, suhu, grade, catatan, _userLogin.IdUser);


                string statusSuhu = _laporanRepo.GetStatusSuhuRuang(idRuang, suhu);

                if (statusSuhu.Contains("PERINGATAN"))
                {
                    lblStatusSuhu.ForeColor = Color.Red;
                    lblStatusSuhu.Text = "Tersimpan! ⚠️ " + statusSuhu;
                }
                else
                {
                    lblStatusSuhu.ForeColor = Color.Green;
                    lblStatusSuhu.Text = "Tersimpan! ✅ " + statusSuhu;
                }
            }
            catch (Exception ex)
            {
                lblStatusSuhu.ForeColor = Color.Red;
                lblStatusSuhu.Text = "Gagal: " + ex.Message;
            }
        }

        private void btnProsesKirim_Click(object sender, EventArgs e)
        {
            try
            {
                string idPengiriman = txtIdPengiriman.Text;
                string tujuan = txtTujuan.Text;
                string armada = txtNoArmada.Text;
                int idStok = (int)cmbStokKirim.SelectedValue;
                double kuantitas = double.Parse(txtKuantitasKirim.Text);

                _opsRepo.ProsesKirim(idPengiriman, _userLogin.IdUser, tujuan, armada, idStok, kuantitas);

                lblStatusKirim.ForeColor = Color.Green;
                lblStatusKirim.Text = "Pengiriman berhasil diproses!";
                txtIdPengiriman.Text = "TX-" + DateTime.Now.ToString("yyyyMMddHHmmss");
                txtTujuan.Clear();
                txtNoArmada.Clear();
                txtKuantitasKirim.Clear();
            }
            catch (Exception ex)
            {
                lblStatusKirim.ForeColor = Color.Red;
                lblStatusKirim.Text = "Gagal: " + ex.Message;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string filter = cmbFilterMutasi.SelectedItem.ToString();
                var mutasiList = _laporanRepo.GetRiwayatMutasi(filter);
                dgvLaporan.DataSource = mutasiList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filter: " + ex.Message);
            }
        }

        private void btnTambahStok_Click(object sender, EventArgs e)
        {
            TampilkanPanel(panelInputSuhu, btnInputSuhu, "Input Suhu");
            LoadRuanganComboBox();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximize.Text = "□";
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximize.Text = "❐";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var konfirmasi = MessageBox.Show(
       "Yakin ingin keluar?",
       "Konfirmasi",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
                Application.Exit();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            panelTitleBar.Width = this.Width;
        }

        private void panelStok_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}