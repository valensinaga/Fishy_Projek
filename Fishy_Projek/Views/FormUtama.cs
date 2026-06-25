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

            dgvStok.Parent = panelStok;
            dgvLaporan.Parent = panelLaporan;

            dgvStok.BringToFront();
            dgvStok.Dock = DockStyle.Fill;

           

        

            // Event Handler untuk komponen Master
            btnUpdateIkan.Click += btnUpdateIkan_Click;

            button1.Click += button1_Click; // Update Gudang
            button2.Click += button2_Click; // Hapus Gudang
            btnTambahGudang.Click += btnTambahGudang_Click; // Tambah Gudang

            button3.Click += button3_Click; // Bisa difungsikan untuk simpan ruang alternatif
            btnTambahRuang.Click += btnTambahRuang_Click; // Tambah Ruang
            button4.Click += button4_Click; // Update Ruang
            button5.Click += button5_Click; // Hapus Ruang

            button6.Click += button6_Click; // Tambah User
            button7.Click += button7_Click; // Update User
            button8.Click += button8_Click; // Hapus User
        }

        // ==========================================
        // MENU & NAVIGASI LOGIC
        // ==========================================
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Username dan password tidak boleh kosong!";
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                _userLogin = _opsRepo.Login(username, password);

                if (_userLogin != null)
                {
                    lblError.Text = "";
                    lblNamaUser.Text = "Halo, " + _userLogin.Nama;
                    lblRoleUser.Text = _userLogin.IdRole == 1 ? "Manajer" : "Operator";

                    panelLogin.Visible = false;
                    panelSidebar.Visible = true;
                    panelKonten.Visible = true;

                    panelSidebar.BringToFront();
                    panelKonten.BringToFront();

                    if (_userLogin.IdRole == 1)
                    {
                        TampilkanPanel(panelDashboard, btnDashboard, "Dashboard");
                        LoadDashboard();
                    }
                    else
                    {
                        TampilkanPanel(panelStok, btnStok, "Stok & Ruangan");
                        LoadStok();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
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
            btnStok.BackColor = Color.Transparent;
            btnInputSuhu.BackColor = Color.Transparent;
            btnPengiriman.BackColor = Color.Transparent;
            btnLaporan.BackColor = Color.Transparent;
            btnMaster.BackColor = Color.Transparent;

            btnDashboard.ForeColor = Color.MidnightBlue;
            btnStok.ForeColor = Color.MidnightBlue;
            btnInputSuhu.ForeColor = Color.MidnightBlue;
            btnPengiriman.ForeColor = Color.MidnightBlue;
            btnLaporan.ForeColor = Color.MidnightBlue;
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

        private void btnTampilkanLaporan_Click(object sender, EventArgs e)
        {
            string filter = cmbFilterMutasi.Text;
            dgvLaporan.DataSource = _laporanRepo.GetRiwayatMutasi(filter);
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

        // ==========================================
        // LOAD DATA LOGIC
        // ==========================================
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


                var dtSuhu = _laporanRepo.GetKondisiRuanganTerakhir();
                dgvKondisiRuangan.DataSource = dtSuhu;


                if (dgvKondisiRuangan.Columns.Count > 0)
                {

                    dgvKondisiRuangan.Columns["id_batch"].Visible = false;
                    dgvKondisiRuangan.Columns["id_ruang"].Visible = false;


                    dgvKondisiRuangan.Columns["nama_ruang"].HeaderText = "Ruang";
                    dgvKondisiRuangan.Columns["nama_gudang"].HeaderText = "Gudang";
                    dgvKondisiRuangan.Columns["waktu_cek"].HeaderText = "Waktu Cek";
                    dgvKondisiRuangan.Columns["suhu_aktual"].HeaderText = "Suhu (°C)";
                    dgvKondisiRuangan.Columns["grade_mutu"].HeaderText = "Grade";
                    dgvKondisiRuangan.Columns["catatan"].HeaderText = "Catatan";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat memuat Dashboard: " + ex.Message);
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
                var stokList = _opsRepo.GetRingkasanStok();
                cmbStokKirim.DisplayMember = "NamaIkan";
                cmbStokKirim.ValueMember = "IdIkan";
                cmbStokKirim.DataSource = stokList;
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

                bool isManajer = _userLogin != null && _userLogin.IdRole == 1;
                lblGrafikTitle.Visible = isManajer;
                formsPlotMutasi.Visible = isManajer;

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
                    posisi += 3;
                }

                formsPlotMutasi.Plot.Add.Bars(bars);
                formsPlotMutasi.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks.ToArray());
                formsPlotMutasi.Plot.Axes.Bottom.TickLabelStyle.Rotation = 45;
                formsPlotMutasi.Plot.Axes.Margins(bottom: 0.15);

                formsPlotMutasi.Plot.Title("Mutasi Stok: Masuk vs Keluar (kg)");
                formsPlotMutasi.Plot.Axes.Bottom.Label.Text = "Tanggal";
                formsPlotMutasi.Plot.Axes.Left.Label.Text = "Kg";

                formsPlotMutasi.Plot.Legend.IsVisible = true;
                formsPlotMutasi.Plot.Legend.Alignment = ScottPlot.Alignment.UpperLeft;
                formsPlotMutasi.Plot.Legend.ManualItems.Clear();
                formsPlotMutasi.Plot.Legend.ManualItems.Add(new ScottPlot.LegendItem { LabelText = "Masuk", FillColor = ScottPlot.Colors.SteelBlue });
                formsPlotMutasi.Plot.Legend.ManualItems.Add(new ScottPlot.LegendItem { LabelText = "Keluar", FillColor = ScottPlot.Colors.IndianRed });

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
                // Load Tabel Data
                dgvIkan.DataSource = _masterRepo.GetAllIkan();
                dgvGudang.DataSource = _masterRepo.GetAllGudang();
                dgvRuang.DataSource = _masterRepo.GetAllRuang();
                dataGridView1.DataSource = _masterRepo.GetAllUser();

                // Load Data ComboBox untuk Update IKAN
                var listIkan = _masterRepo.GetAllIkan();
                comboBox1.DataSource = listIkan; comboBox1.DisplayMember = "IdIkan"; comboBox1.ValueMember = "IdIkan";

                // Load Data ComboBox untuk Update/Delete GUDANG
                var listGudang = _masterRepo.GetAllGudang();
                comboBox2.DataSource = listGudang; comboBox2.DisplayMember = "IdGudang"; comboBox2.ValueMember = "IdGudang";
                comboBox3.DataSource = listGudang; comboBox3.DisplayMember = "IdGudang"; comboBox3.ValueMember = "IdGudang";
                comboBox4.DataSource = listGudang; comboBox4.DisplayMember = "IdGudang"; comboBox4.ValueMember = "IdGudang"; // Di Tab Ruang (Tambah)
                comboBox6.DataSource = listGudang; comboBox6.DisplayMember = "IdGudang"; comboBox6.ValueMember = "IdGudang"; // Di Tab Ruang (Update)

                // Load Data ComboBox untuk Update/Delete RUANG
                var listRuang = _masterRepo.GetAllRuang();
                comboBox5.DataSource = listRuang; comboBox5.DisplayMember = "IdRuang"; comboBox5.ValueMember = "IdRuang";
                comboBox7.DataSource = listRuang; comboBox7.DisplayMember = "IdRuang"; comboBox7.ValueMember = "IdRuang";

                // Load Data ComboBox untuk Update/Delete USER
                var listUser = _masterRepo.GetAllUser();
                comboBox9.DataSource = listUser; comboBox9.DisplayMember = "IdUser"; comboBox9.ValueMember = "IdUser";
                comboBox11.DataSource = listUser; comboBox11.DisplayMember = "IdUser"; comboBox11.ValueMember = "IdUser";

                // Load Data ComboBox untuk ROLE (Langsung pakai DataTable dari SQL)
                var dtRole = _masterRepo.GetRolesDataTable();

                // Untuk Tambah User (comboBox8)
                comboBox8.DataSource = dtRole;
                comboBox8.DisplayMember = "nama_role"; // Pastikan ini sesuai dengan nama kolom di databasemu
                comboBox8.ValueMember = "id_role";     // Pastikan ini sesuai dengan nama kolom di databasemu

                // Untuk Update User (comboBox10)
                // Gunakan .Copy() agar pilihan di comboBox8 tidak ikut berubah saat comboBox10 dipilih (mencegah bentrok)
                comboBox10.DataSource = dtRole.Copy();
                comboBox10.DisplayMember = "nama_role";
                comboBox10.ValueMember = "id_role";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load data master: " + ex.Message);
            }
        }

        // ==========================================
        // CUD TAB IKAN
        // ==========================================
        private void btnTambahIkan_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdIkan.Text) || string.IsNullOrWhiteSpace(txtNamaIkan.Text)) return;

                Ikan ikanBaru = new Ikan
                {
                    IdIkan = txtIdIkan.Text.Trim(),
                    NamaIkan = txtNamaIkan.Text.Trim(),
                    SuhuIdeal = double.Parse(txtSuhuIdeal.Text),
                    BatasSuhu = double.Parse(txtBatasSuhu.Text)
                };

                _masterRepo.TambahIkan(ikanBaru);

                MessageBox.Show("Data Ikan berhasil ditambahkan!");
                LoadMaster();
            }
            catch (Exception ex) { MessageBox.Show("Gagal Tambah Ikan: " + ex.Message); }
        }

        private void btnUpdateIkan_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedValue == null) return;

                _masterRepo.UpdateIkan(
                    comboBox1.Text,
                    textBox1.Text,
                    double.Parse(textBox2.Text),
                    double.Parse(textBox3.Text)
                );

                MessageBox.Show("Data Ikan berhasil diupdate!");
                LoadMaster();
            }
            catch (Exception ex) { MessageBox.Show("Gagal Update Ikan: " + ex.Message); }
        }



        // ==========================================
        // CUD TAB GUDANG
        // ==========================================
        private void btnTambahGudang_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox4.Text)) return;

                _masterRepo.TambahGudang(
                    int.Parse(textBox4.Text),
                    textBox5.Text,
                    textBox6.Text
                );

                MessageBox.Show("Data Gudang berhasil ditambahkan!");
                LoadMaster();
            }
            catch (Exception ex) { MessageBox.Show("Gagal Tambah Gudang: " + ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e) // Update Gudang
        {
            try
            {
                if (comboBox2.SelectedValue == null) return;

                _masterRepo.UpdateGudang(
                    int.Parse(comboBox2.Text),
                    textBox7.Text,
                    textBox8.Text
                );

                MessageBox.Show("Data Gudang berhasil diupdate!");
                LoadMaster();
            }
            catch (Exception ex) { MessageBox.Show("Gagal Update Gudang: " + ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e) // Hapus Gudang
        {
            try
            {
                if (comboBox3.SelectedValue == null) return;

                _masterRepo.HapusGudang(int.Parse(comboBox3.Text));

                MessageBox.Show("Data Gudang berhasil dihapus!");
                LoadMaster();
            }
            catch (Exception ex) { MessageBox.Show("Gagal Hapus Gudang: " + ex.Message); }
        }

        // ==========================================
        // CUD TAB RUANG COOLER
        // ==========================================
        private void btnTambahRuang_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox9.Text)) return;

                _masterRepo.TambahRuang(
                    textBox9.Text,
                    int.Parse(comboBox4.Text),
                    textBox10.Text,
                    double.Parse(textBox11.Text)
                );

                MessageBox.Show("Data Ruang berhasil ditambahkan!");
                LoadMaster();
            }
            catch (Exception ex) { MessageBox.Show("Gagal Tambah Ruang: " + ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Alternatif Button Tambah Ruang
            btnTambahRuang_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e) // Update Ruang
        {
            try
            {
                if (comboBox5.SelectedValue == null) return;

                _masterRepo.UpdateRuang(
                    comboBox5.Text,
                    int.Parse(comboBox6.Text),
                    textBox12.Text,
                    double.Parse(textBox13.Text)
                );

                MessageBox.Show("Data Ruang berhasil diupdate!");
                LoadMaster();
            }
            catch (Exception ex) { MessageBox.Show("Gagal Update Ruang: " + ex.Message); }
        }

        private void button5_Click(object sender, EventArgs e) // Hapus Ruang
        {
            try
            {
                if (comboBox7.SelectedValue == null) return;

                _masterRepo.HapusRuang(comboBox7.Text);

                MessageBox.Show("Data Ruang berhasil dihapus!");
                LoadMaster();
            }
            catch (Exception ex) { MessageBox.Show("Gagal Hapus Ruang: " + ex.Message); }
        }

        // ==========================================
        // CUD TAB USER
        // ==========================================
        private void button6_Click(object sender, EventArgs e) // Tambah User
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox14.Text)) return;

                // 1. Ini untuk memastikan TextBox Id User (angka 5) diubah jadi tipe Integer
                int idUserDb = int.Parse(textBox14.Text);

                // 2. Ini mengambil angka 1 atau 2 dari ComboBox (di layar tetap muncul "Manager")
                int idRoleDb = Convert.ToInt32(comboBox8.SelectedValue);

                // 3. Kirim data yang sudah di-convert tadi ke Repository
                _masterRepo.TambahUser(
                    idUserDb,                  // <--- SEKARANG SUDAH INTEGER, BUKAN TEKS!
                    textBox15.Text,            // Nama
                    textBox17.Text,            // Username
                    textBox16.Text,            // Password
                    idRoleDb                   // Id Role
                );

                MessageBox.Show("Data User berhasil ditambahkan!");
                LoadMaster();
            }
            catch (Exception ex) { MessageBox.Show("Gagal Tambah User: " + ex.Message); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox9.SelectedValue == null) return;

                int idRole = Convert.ToInt32(comboBox10.SelectedValue);

                _masterRepo.UpdateUser(
                    int.Parse(comboBox9.Text), textBox18.Text, textBox20.Text, textBox19.Text, idRole
                );

                MessageBox.Show("Data User berhasil diupdate!");
                LoadMaster();
            }
            catch (Exception ex) { MessageBox.Show("Gagal Update User: " + ex.Message); }
        }

        private void button8_Click(object sender, EventArgs e) // Hapus User
        {
            try
            {
                if (comboBox11.SelectedValue == null) return;

                _masterRepo.HapusUser(comboBox11.SelectedIndex);

                MessageBox.Show("Data User berhasil dihapus!");
                LoadMaster();
            }
            catch (Exception ex) { MessageBox.Show("Gagal Hapus User: " + ex.Message); }
        }

        // ==========================================
        // WINDOW CONTROLS & OTHERS
        // ==========================================
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
                string idKeluar = txtIdPengiriman.Text;
                string idMasuk = txtIdMasuk.Text;
                int idPihak = _opsRepo.GetIdPihakByNama(txtTujuan.Text.Trim());
                string armada = txtNoArmada.Text;
                double kuantitas = double.Parse(txtKuantitasKirim.Text);

                _opsRepo.ProsesPengiriman(idKeluar, idMasuk, idPihak, armada, kuantitas, _userLogin.IdUser);

                lblStatusKirim.ForeColor = Color.Green;
                lblStatusKirim.Text = "Pengiriman berhasil diproses!";

                txtIdPengiriman.Text = "TX-" + DateTime.Now.ToString("yyyyMMddHHmmss");
                txtIdMasuk.Clear();
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
            var konfirmasi = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (konfirmasi == DialogResult.Yes) Application.Exit();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            panelTitleBar.Width = this.Width;
        }

        private void panelMaster_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ApplyRoleAccess()
        {
            if (_userLogin.IdRole == 2)
            {
                btnMaster.Visible = false;
                btnLaporan.Visible = false;
            }
            else
            {
                btnMaster.Visible = true;
                btnLaporan.Visible = true;
            }
        }


         private void btnLaporan_Click(object sender, EventArgs e)
         {
            TampilkanPanel(panelLaporan, btnLaporan, "Laporan Mutasi");
            LoadLaporan();
         }




    }

    
}