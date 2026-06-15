namespace Fishy_Projek
{
    partial class FormUtama
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLogin = new Panel();
            panelKanan = new Panel();
            lblError = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblWelcome = new Label();
            panelKiri = new Panel();
            lblTagline = new Label();
            lblAppName = new Label();
            panelSidebar = new Panel();
            btnLogout = new Button();
            btnMaster = new Button();
            btnLaporan = new Button();
            btnPengiriman = new Button();
            btnInputSuhu = new Button();
            btnStok = new Button();
            btnDashboard = new Button();
            lblRoleUser = new Label();
            lblNamaUser = new Label();
            lblLogo = new Label();
            panelKonten = new Panel();
            panelMaster = new Panel();
            tabMaster = new TabControl();
            tabIkan = new TabPage();
            btnTambahIkan = new Button();
            dgvIkan = new DataGridView();
            tabGudang = new TabPage();
            btnTambahGudang = new Button();
            dgvGudang = new DataGridView();
            tabRuang = new TabPage();
            btnTambahRuang = new Button();
            dgvRuang = new DataGridView();
            label18 = new Label();
            panelLaporan = new Panel();
            dgvLaporan = new DataGridView();
            btnFilter = new Button();
            cmbFilterMutasi = new ComboBox();
            label17 = new Label();
            label16 = new Label();
            panelPengiriman = new Panel();
            lblStatusKirim = new Label();
            btnProsesKirim = new Button();
            txtKuantitasKirim = new TextBox();
            label15 = new Label();
            cmbStokKirim = new ComboBox();
            label14 = new Label();
            txtNoArmada = new TextBox();
            label13 = new Label();
            txtTujuan = new TextBox();
            label12 = new Label();
            txtIdPengiriman = new TextBox();
            label11 = new Label();
            label10 = new Label();
            panelInputSuhu = new Panel();
            lblStatusSuhu = new Label();
            btnSimpanSuhu = new Button();
            txtCatatanSuhu = new TextBox();
            label9 = new Label();
            cmbGradeMutu = new ComboBox();
            label8 = new Label();
            txtSuhuAktual = new TextBox();
            label7 = new Label();
            cmbRuanganSuhu = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            panelStok = new Panel();
            btnTambahStok = new Button();
            label19 = new Label();
            dgvStok = new DataGridView();
            panelDashboard = new Panel();
            dgvKondisiRuangan = new DataGridView();
            dgvRingkasanStok = new DataGridView();
            cardPeringatan = new Panel();
            lblPeringatan = new Label();
            label4 = new Label();
            cardSuhu = new Panel();
            label3 = new Label();
            lblSuhu = new Label();
            cardKapasitas = new Panel();
            lblKapasitas = new Label();
            label2 = new Label();
            cardTotalUnit = new Panel();
            label1 = new Label();
            lblTotalUnit = new Label();
            panelHeader = new Panel();
            lblPageTitle = new Label();
            panelTitleBar = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            panelLogin.SuspendLayout();
            panelKanan.SuspendLayout();
            panelKiri.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelKonten.SuspendLayout();
            panelMaster.SuspendLayout();
            tabMaster.SuspendLayout();
            tabIkan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIkan).BeginInit();
            tabGudang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGudang).BeginInit();
            tabRuang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRuang).BeginInit();
            panelLaporan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).BeginInit();
            panelPengiriman.SuspendLayout();
            panelInputSuhu.SuspendLayout();
            panelStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStok).BeginInit();
            panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKondisiRuangan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRingkasanStok).BeginInit();
            cardPeringatan.SuspendLayout();
            cardSuhu.SuspendLayout();
            cardKapasitas.SuspendLayout();
            cardTotalUnit.SuspendLayout();
            panelHeader.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(panelKanan);
            panelLogin.Controls.Add(panelKiri);
            panelLogin.Location = new Point(0, 35);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(1200, 665);
            panelLogin.TabIndex = 0;
            // 
            // panelKanan
            // 
            panelKanan.BackColor = Color.White;
            panelKanan.BackgroundImage = Properties.Resources.login_kanan2;
            panelKanan.Controls.Add(lblError);
            panelKanan.Controls.Add(btnLogin);
            panelKanan.Controls.Add(txtPassword);
            panelKanan.Controls.Add(lblPassword);
            panelKanan.Controls.Add(txtUsername);
            panelKanan.Controls.Add(lblUsername);
            panelKanan.Controls.Add(lblWelcome);
            panelKanan.Location = new Point(600, 0);
            panelKanan.Name = "panelKanan";
            panelKanan.Size = new Size(600, 700);
            panelKanan.TabIndex = 1;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(80, 475);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Berlin Sans FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(80, 420);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(290, 45);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "MASUK";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Berlin Sans FB", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(80, 350);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(290, 32);
            txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.DimGray;
            lblPassword.Location = new Point(80, 325);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(88, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Berlin Sans FB", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(80, 275);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(290, 32);
            txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.DimGray;
            lblUsername.Location = new Point(80, 250);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(93, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Berlin Sans FB", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.MidnightBlue;
            lblWelcome.Location = new Point(80, 150);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(332, 50);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Selamat Datang";
            // 
            // panelKiri
            // 
            panelKiri.BackColor = Color.SteelBlue;
            panelKiri.Controls.Add(lblTagline);
            panelKiri.Controls.Add(lblAppName);
            panelKiri.Location = new Point(0, 0);
            panelKiri.Name = "panelKiri";
            panelKiri.Size = new Size(600, 700);
            panelKiri.TabIndex = 0;
            // 
            // lblTagline
            // 
            lblTagline.AutoSize = true;
            lblTagline.Font = new Font("Berlin Sans FB", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTagline.ForeColor = Color.LightSkyBlue;
            lblTagline.Location = new Point(80, 330);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(409, 24);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "Cold Chain Fish Storage Monitoring System";
            lblTagline.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Berlin Sans FB", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(130, 250);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(271, 70);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "🐟 FISHY";
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.MidnightBlue;
            panelSidebar.BackgroundImage = Properties.Resources.dashboard;
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnMaster);
            panelSidebar.Controls.Add(btnLaporan);
            panelSidebar.Controls.Add(btnPengiriman);
            panelSidebar.Controls.Add(btnInputSuhu);
            panelSidebar.Controls.Add(btnStok);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(lblRoleUser);
            panelSidebar.Controls.Add(lblNamaUser);
            panelSidebar.Controls.Add(lblLogo);
            panelSidebar.ForeColor = Color.White;
            panelSidebar.Location = new Point(0, 35);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(220, 665);
            panelSidebar.TabIndex = 2;
            panelSidebar.Visible = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Salmon;
            btnLogout.Location = new Point(0, 640);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(20, 0, 0, 0);
            btnLogout.Size = new Size(220, 50);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "🚪  Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnMaster
            // 
            btnMaster.BackColor = Color.Transparent;
            btnMaster.Cursor = Cursors.Hand;
            btnMaster.FlatAppearance.BorderSize = 0;
            btnMaster.FlatStyle = FlatStyle.Flat;
            btnMaster.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMaster.ForeColor = Color.SlateGray;
            btnMaster.Location = new Point(0, 380);
            btnMaster.Name = "btnMaster";
            btnMaster.Padding = new Padding(20, 0, 0, 0);
            btnMaster.Size = new Size(220, 50);
            btnMaster.TabIndex = 8;
            btnMaster.Text = "⚙️  Master Data";
            btnMaster.TextAlign = ContentAlignment.MiddleLeft;
            btnMaster.UseVisualStyleBackColor = false;
            btnMaster.Click += btnMaster_Click;
            // 
            // btnLaporan
            // 
            btnLaporan.BackColor = Color.Transparent;
            btnLaporan.Cursor = Cursors.Hand;
            btnLaporan.FlatAppearance.BorderSize = 0;
            btnLaporan.FlatStyle = FlatStyle.Flat;
            btnLaporan.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLaporan.ForeColor = Color.SlateGray;
            btnLaporan.Location = new Point(0, 330);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Padding = new Padding(20, 0, 0, 0);
            btnLaporan.Size = new Size(220, 50);
            btnLaporan.TabIndex = 7;
            btnLaporan.Text = "📋  Laporan";
            btnLaporan.TextAlign = ContentAlignment.MiddleLeft;
            btnLaporan.UseVisualStyleBackColor = false;
            btnLaporan.Click += btnLaporan_Click;
            // 
            // btnPengiriman
            // 
            btnPengiriman.BackColor = Color.Transparent;
            btnPengiriman.Cursor = Cursors.Hand;
            btnPengiriman.FlatAppearance.BorderSize = 0;
            btnPengiriman.FlatStyle = FlatStyle.Flat;
            btnPengiriman.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPengiriman.ForeColor = Color.SlateGray;
            btnPengiriman.Location = new Point(0, 280);
            btnPengiriman.Name = "btnPengiriman";
            btnPengiriman.Padding = new Padding(20, 0, 0, 0);
            btnPengiriman.Size = new Size(220, 50);
            btnPengiriman.TabIndex = 6;
            btnPengiriman.Text = "🚚  Pengiriman";
            btnPengiriman.TextAlign = ContentAlignment.MiddleLeft;
            btnPengiriman.UseVisualStyleBackColor = false;
            btnPengiriman.Click += btnPengiriman_Click;
            // 
            // btnInputSuhu
            // 
            btnInputSuhu.BackColor = Color.Transparent;
            btnInputSuhu.Cursor = Cursors.Hand;
            btnInputSuhu.FlatAppearance.BorderSize = 0;
            btnInputSuhu.FlatStyle = FlatStyle.Flat;
            btnInputSuhu.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInputSuhu.ForeColor = Color.SlateGray;
            btnInputSuhu.Location = new Point(0, 230);
            btnInputSuhu.Name = "btnInputSuhu";
            btnInputSuhu.Padding = new Padding(20, 0, 0, 0);
            btnInputSuhu.Size = new Size(220, 50);
            btnInputSuhu.TabIndex = 5;
            btnInputSuhu.Text = "🌡️  Input Suhu";
            btnInputSuhu.TextAlign = ContentAlignment.MiddleLeft;
            btnInputSuhu.UseVisualStyleBackColor = false;
            btnInputSuhu.Click += btnInputSuhu_Click;
            // 
            // btnStok
            // 
            btnStok.BackColor = Color.Transparent;
            btnStok.Cursor = Cursors.Hand;
            btnStok.FlatAppearance.BorderSize = 0;
            btnStok.FlatStyle = FlatStyle.Flat;
            btnStok.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStok.ForeColor = Color.SlateGray;
            btnStok.Location = new Point(0, 180);
            btnStok.Name = "btnStok";
            btnStok.Padding = new Padding(20, 0, 0, 0);
            btnStok.Size = new Size(220, 50);
            btnStok.TabIndex = 4;
            btnStok.Text = "🏪  Stok & Ruangan";
            btnStok.TextAlign = ContentAlignment.MiddleLeft;
            btnStok.UseVisualStyleBackColor = false;
            btnStok.Click += btnStok_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.SteelBlue;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(0, 130);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(20, 0, 0, 0);
            btnDashboard.Size = new Size(220, 50);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "📊  Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblRoleUser
            // 
            lblRoleUser.AutoSize = true;
            lblRoleUser.BackColor = Color.DeepSkyBlue;
            lblRoleUser.Font = new Font("Berlin Sans FB", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoleUser.Location = new Point(15, 95);
            lblRoleUser.Name = "lblRoleUser";
            lblRoleUser.Size = new Size(73, 20);
            lblRoleUser.TabIndex = 2;
            lblRoleUser.Text = "Manajer";
            // 
            // lblNamaUser
            // 
            lblNamaUser.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNamaUser.ForeColor = Color.SlateGray;
            lblNamaUser.Location = new Point(15, 75);
            lblNamaUser.Name = "lblNamaUser";
            lblNamaUser.Size = new Size(190, 20);
            lblNamaUser.TabIndex = 1;
            lblNamaUser.Text = "Halo, [NamaUser]";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.SteelBlue;
            lblLogo.Font = new Font("Berlin Sans FB", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(155, 40);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "🐟 FISHY";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelKonten
            // 
            panelKonten.Controls.Add(panelMaster);
            panelKonten.Controls.Add(panelLaporan);
            panelKonten.Controls.Add(panelPengiriman);
            panelKonten.Controls.Add(panelInputSuhu);
            panelKonten.Controls.Add(panelStok);
            panelKonten.Controls.Add(panelDashboard);
            panelKonten.Controls.Add(panelHeader);
            panelKonten.Location = new Point(220, 35);
            panelKonten.Name = "panelKonten";
            panelKonten.Size = new Size(980, 700);
            panelKonten.TabIndex = 2;
            panelKonten.Visible = false;
            // 
            // panelMaster
            // 
            panelMaster.Controls.Add(tabMaster);
            panelMaster.Controls.Add(label18);
            panelMaster.Location = new Point(0, 60);
            panelMaster.Name = "panelMaster";
            panelMaster.Size = new Size(980, 640);
            panelMaster.TabIndex = 0;
            panelMaster.Visible = false;
            // 
            // tabMaster
            // 
            tabMaster.Controls.Add(tabIkan);
            tabMaster.Controls.Add(tabGudang);
            tabMaster.Controls.Add(tabRuang);
            tabMaster.Location = new Point(20, 60);
            tabMaster.Name = "tabMaster";
            tabMaster.SelectedIndex = 0;
            tabMaster.Size = new Size(940, 560);
            tabMaster.TabIndex = 1;
            // 
            // tabIkan
            // 
            tabIkan.Controls.Add(btnTambahIkan);
            tabIkan.Controls.Add(dgvIkan);
            tabIkan.Location = new Point(4, 34);
            tabIkan.Name = "tabIkan";
            tabIkan.Padding = new Padding(3);
            tabIkan.Size = new Size(932, 522);
            tabIkan.TabIndex = 0;
            tabIkan.Text = "Data Ikan";
            tabIkan.UseVisualStyleBackColor = true;
            // 
            // btnTambahIkan
            // 
            btnTambahIkan.BackColor = Color.SteelBlue;
            btnTambahIkan.Cursor = Cursors.Hand;
            btnTambahIkan.FlatAppearance.BorderSize = 0;
            btnTambahIkan.FlatStyle = FlatStyle.Flat;
            btnTambahIkan.Font = new Font("Berlin Sans FB", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahIkan.ForeColor = Color.White;
            btnTambahIkan.Location = new Point(10, 420);
            btnTambahIkan.Name = "btnTambahIkan";
            btnTambahIkan.Size = new Size(130, 35);
            btnTambahIkan.TabIndex = 1;
            btnTambahIkan.Text = "+ Tambah Ikan";
            btnTambahIkan.UseVisualStyleBackColor = false;
            // 
            // dgvIkan
            // 
            dgvIkan.AllowUserToAddRows = false;
            dgvIkan.BackgroundColor = Color.White;
            dgvIkan.BorderStyle = BorderStyle.None;
            dgvIkan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIkan.Location = new Point(10, 10);
            dgvIkan.Name = "dgvIkan";
            dgvIkan.ReadOnly = true;
            dgvIkan.RowHeadersVisible = false;
            dgvIkan.RowHeadersWidth = 62;
            dgvIkan.Size = new Size(900, 400);
            dgvIkan.TabIndex = 0;
            // 
            // tabGudang
            // 
            tabGudang.Controls.Add(btnTambahGudang);
            tabGudang.Controls.Add(dgvGudang);
            tabGudang.Location = new Point(4, 34);
            tabGudang.Name = "tabGudang";
            tabGudang.Padding = new Padding(3);
            tabGudang.Size = new Size(932, 522);
            tabGudang.TabIndex = 1;
            tabGudang.Text = "Data Gudang";
            tabGudang.UseVisualStyleBackColor = true;
            // 
            // btnTambahGudang
            // 
            btnTambahGudang.BackColor = Color.SteelBlue;
            btnTambahGudang.Cursor = Cursors.Hand;
            btnTambahGudang.FlatAppearance.BorderSize = 0;
            btnTambahGudang.FlatStyle = FlatStyle.Flat;
            btnTambahGudang.Font = new Font("Berlin Sans FB", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahGudang.ForeColor = Color.White;
            btnTambahGudang.Location = new Point(10, 420);
            btnTambahGudang.Name = "btnTambahGudang";
            btnTambahGudang.Size = new Size(150, 35);
            btnTambahGudang.TabIndex = 3;
            btnTambahGudang.Text = "+ Tambah Gudang";
            btnTambahGudang.UseVisualStyleBackColor = false;
            // 
            // dgvGudang
            // 
            dgvGudang.AllowUserToAddRows = false;
            dgvGudang.BackgroundColor = Color.White;
            dgvGudang.BorderStyle = BorderStyle.None;
            dgvGudang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGudang.Location = new Point(10, 10);
            dgvGudang.Name = "dgvGudang";
            dgvGudang.ReadOnly = true;
            dgvGudang.RowHeadersVisible = false;
            dgvGudang.RowHeadersWidth = 62;
            dgvGudang.Size = new Size(900, 400);
            dgvGudang.TabIndex = 2;
            // 
            // tabRuang
            // 
            tabRuang.Controls.Add(btnTambahRuang);
            tabRuang.Controls.Add(dgvRuang);
            tabRuang.Location = new Point(4, 34);
            tabRuang.Name = "tabRuang";
            tabRuang.Padding = new Padding(3);
            tabRuang.Size = new Size(932, 522);
            tabRuang.TabIndex = 2;
            tabRuang.Text = "Data Ruang Cooler";
            tabRuang.UseVisualStyleBackColor = true;
            // 
            // btnTambahRuang
            // 
            btnTambahRuang.BackColor = Color.SteelBlue;
            btnTambahRuang.Cursor = Cursors.Hand;
            btnTambahRuang.FlatAppearance.BorderSize = 0;
            btnTambahRuang.FlatStyle = FlatStyle.Flat;
            btnTambahRuang.Font = new Font("Berlin Sans FB", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahRuang.ForeColor = Color.White;
            btnTambahRuang.Location = new Point(10, 420);
            btnTambahRuang.Name = "btnTambahRuang";
            btnTambahRuang.Size = new Size(160, 35);
            btnTambahRuang.TabIndex = 5;
            btnTambahRuang.Text = "+ Tambah Ruangan";
            btnTambahRuang.UseVisualStyleBackColor = false;
            // 
            // dgvRuang
            // 
            dgvRuang.AllowUserToAddRows = false;
            dgvRuang.BackgroundColor = Color.White;
            dgvRuang.BorderStyle = BorderStyle.None;
            dgvRuang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRuang.Location = new Point(10, 10);
            dgvRuang.Name = "dgvRuang";
            dgvRuang.ReadOnly = true;
            dgvRuang.RowHeadersVisible = false;
            dgvRuang.RowHeadersWidth = 62;
            dgvRuang.Size = new Size(900, 400);
            dgvRuang.TabIndex = 4;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Berlin Sans FB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.MidnightBlue;
            label18.Location = new Point(20, 20);
            label18.Name = "label18";
            label18.Size = new Size(230, 45);
            label18.TabIndex = 0;
            label18.Text = "Master Data";
            // 
            // panelLaporan
            // 
            panelLaporan.Controls.Add(dgvLaporan);
            panelLaporan.Controls.Add(btnFilter);
            panelLaporan.Controls.Add(cmbFilterMutasi);
            panelLaporan.Controls.Add(label17);
            panelLaporan.Controls.Add(label16);
            panelLaporan.Location = new Point(0, 60);
            panelLaporan.Name = "panelLaporan";
            panelLaporan.Size = new Size(980, 640);
            panelLaporan.TabIndex = 0;
            panelLaporan.Visible = false;
            // 
            // dgvLaporan
            // 
            dgvLaporan.AllowUserToAddRows = false;
            dgvLaporan.BackgroundColor = Color.White;
            dgvLaporan.BorderStyle = BorderStyle.None;
            dgvLaporan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaporan.Location = new Point(20, 145);
            dgvLaporan.Name = "dgvLaporan";
            dgvLaporan.ReadOnly = true;
            dgvLaporan.RowHeadersVisible = false;
            dgvLaporan.RowHeadersWidth = 62;
            dgvLaporan.Size = new Size(940, 480);
            dgvLaporan.TabIndex = 0;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.SteelBlue;
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Berlin Sans FB", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(235, 95);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(120, 35);
            btnFilter.TabIndex = 0;
            btnFilter.Text = "TAMPILKAN";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // cmbFilterMutasi
            // 
            cmbFilterMutasi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterMutasi.Font = new Font("Berlin Sans FB", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFilterMutasi.FormattingEnabled = true;
            cmbFilterMutasi.Location = new Point(20, 95);
            cmbFilterMutasi.Name = "cmbFilterMutasi";
            cmbFilterMutasi.Size = new Size(200, 32);
            cmbFilterMutasi.TabIndex = 0;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.DimGray;
            label17.Location = new Point(20, 70);
            label17.Name = "label17";
            label17.Size = new Size(152, 23);
            label17.TabIndex = 0;
            label17.Text = "Filter Jenis Mutasi";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Berlin Sans FB", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.MidnightBlue;
            label16.Location = new Point(20, 20);
            label16.Name = "label16";
            label16.Size = new Size(343, 35);
            label16.TabIndex = 0;
            label16.Text = "Laporan Riwayat Mutasi";
            // 
            // panelPengiriman
            // 
            panelPengiriman.Controls.Add(lblStatusKirim);
            panelPengiriman.Controls.Add(btnProsesKirim);
            panelPengiriman.Controls.Add(txtKuantitasKirim);
            panelPengiriman.Controls.Add(label15);
            panelPengiriman.Controls.Add(cmbStokKirim);
            panelPengiriman.Controls.Add(label14);
            panelPengiriman.Controls.Add(txtNoArmada);
            panelPengiriman.Controls.Add(label13);
            panelPengiriman.Controls.Add(txtTujuan);
            panelPengiriman.Controls.Add(label12);
            panelPengiriman.Controls.Add(txtIdPengiriman);
            panelPengiriman.Controls.Add(label11);
            panelPengiriman.Controls.Add(label10);
            panelPengiriman.Location = new Point(0, 60);
            panelPengiriman.Name = "panelPengiriman";
            panelPengiriman.Size = new Size(980, 640);
            panelPengiriman.TabIndex = 0;
            panelPengiriman.Visible = false;
            // 
            // lblStatusKirim
            // 
            lblStatusKirim.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusKirim.ForeColor = Color.Green;
            lblStatusKirim.Location = new Point(20, 515);
            lblStatusKirim.Name = "lblStatusKirim";
            lblStatusKirim.Size = new Size(290, 20);
            lblStatusKirim.TabIndex = 0;
            // 
            // btnProsesKirim
            // 
            btnProsesKirim.BackColor = Color.Teal;
            btnProsesKirim.Cursor = Cursors.Hand;
            btnProsesKirim.FlatAppearance.BorderSize = 0;
            btnProsesKirim.FlatStyle = FlatStyle.Flat;
            btnProsesKirim.Font = new Font("Berlin Sans FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProsesKirim.ForeColor = Color.White;
            btnProsesKirim.Location = new Point(20, 460);
            btnProsesKirim.Name = "btnProsesKirim";
            btnProsesKirim.Size = new Size(290, 45);
            btnProsesKirim.TabIndex = 0;
            btnProsesKirim.Text = "PROSES PENGIRIMAN";
            btnProsesKirim.UseVisualStyleBackColor = false;
            btnProsesKirim.Click += btnProsesKirim_Click;
            // 
            // txtKuantitasKirim
            // 
            txtKuantitasKirim.BorderStyle = BorderStyle.FixedSingle;
            txtKuantitasKirim.Font = new Font("Berlin Sans FB", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKuantitasKirim.Location = new Point(20, 395);
            txtKuantitasKirim.Name = "txtKuantitasKirim";
            txtKuantitasKirim.Size = new Size(290, 32);
            txtKuantitasKirim.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DimGray;
            label15.Location = new Point(20, 370);
            label15.Name = "label15";
            label15.Size = new Size(177, 23);
            label15.TabIndex = 0;
            label15.Text = "Kuantitas Kirim (kg)";
            // 
            // cmbStokKirim
            // 
            cmbStokKirim.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStokKirim.Font = new Font("Berlin Sans FB", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStokKirim.FormattingEnabled = true;
            cmbStokKirim.Location = new Point(20, 320);
            cmbStokKirim.Name = "cmbStokKirim";
            cmbStokKirim.Size = new Size(290, 32);
            cmbStokKirim.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.DimGray;
            label14.Location = new Point(20, 295);
            label14.Name = "label14";
            label14.Size = new Size(86, 23);
            label14.TabIndex = 0;
            label14.Text = "Pilih Stok";
            // 
            // txtNoArmada
            // 
            txtNoArmada.BorderStyle = BorderStyle.FixedSingle;
            txtNoArmada.Font = new Font("Berlin Sans FB", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNoArmada.Location = new Point(20, 245);
            txtNoArmada.Name = "txtNoArmada";
            txtNoArmada.Size = new Size(290, 32);
            txtNoArmada.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(20, 220);
            label13.Name = "label13";
            label13.Size = new Size(141, 23);
            label13.TabIndex = 0;
            label13.Text = "Nomor Armada";
            // 
            // txtTujuan
            // 
            txtTujuan.BorderStyle = BorderStyle.FixedSingle;
            txtTujuan.Font = new Font("Berlin Sans FB", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTujuan.Location = new Point(20, 170);
            txtTujuan.Name = "txtTujuan";
            txtTujuan.Size = new Size(290, 32);
            txtTujuan.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DimGray;
            label12.Location = new Point(20, 145);
            label12.Name = "label12";
            label12.Size = new Size(146, 23);
            label12.TabIndex = 0;
            label12.Text = "Tujuan Distribusi";
            // 
            // txtIdPengiriman
            // 
            txtIdPengiriman.BackColor = Color.WhiteSmoke;
            txtIdPengiriman.BorderStyle = BorderStyle.FixedSingle;
            txtIdPengiriman.Font = new Font("Berlin Sans FB", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdPengiriman.Location = new Point(20, 95);
            txtIdPengiriman.Name = "txtIdPengiriman";
            txtIdPengiriman.ReadOnly = true;
            txtIdPengiriman.Size = new Size(290, 32);
            txtIdPengiriman.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(20, 70);
            label11.Name = "label11";
            label11.Size = new Size(127, 23);
            label11.TabIndex = 0;
            label11.Text = "ID Pengiriman";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.MidnightBlue;
            label10.Location = new Point(20, 20);
            label10.Name = "label10";
            label10.Size = new Size(259, 38);
            label10.TabIndex = 0;
            label10.Text = "Proses Pengiriman";
            // 
            // panelInputSuhu
            // 
            panelInputSuhu.Controls.Add(lblStatusSuhu);
            panelInputSuhu.Controls.Add(btnSimpanSuhu);
            panelInputSuhu.Controls.Add(txtCatatanSuhu);
            panelInputSuhu.Controls.Add(label9);
            panelInputSuhu.Controls.Add(cmbGradeMutu);
            panelInputSuhu.Controls.Add(label8);
            panelInputSuhu.Controls.Add(txtSuhuAktual);
            panelInputSuhu.Controls.Add(label7);
            panelInputSuhu.Controls.Add(cmbRuanganSuhu);
            panelInputSuhu.Controls.Add(label6);
            panelInputSuhu.Controls.Add(label5);
            panelInputSuhu.Location = new Point(0, 60);
            panelInputSuhu.Name = "panelInputSuhu";
            panelInputSuhu.Size = new Size(980, 640);
            panelInputSuhu.TabIndex = 0;
            panelInputSuhu.Visible = false;
            // 
            // lblStatusSuhu
            // 
            lblStatusSuhu.ForeColor = Color.Green;
            lblStatusSuhu.Location = new Point(20, 475);
            lblStatusSuhu.Name = "lblStatusSuhu";
            lblStatusSuhu.Size = new Size(290, 20);
            lblStatusSuhu.TabIndex = 0;
            // 
            // btnSimpanSuhu
            // 
            btnSimpanSuhu.BackColor = Color.SteelBlue;
            btnSimpanSuhu.Cursor = Cursors.Hand;
            btnSimpanSuhu.FlatAppearance.BorderSize = 0;
            btnSimpanSuhu.FlatStyle = FlatStyle.Flat;
            btnSimpanSuhu.Font = new Font("Berlin Sans FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpanSuhu.ForeColor = Color.White;
            btnSimpanSuhu.Location = new Point(20, 420);
            btnSimpanSuhu.Name = "btnSimpanSuhu";
            btnSimpanSuhu.Size = new Size(290, 45);
            btnSimpanSuhu.TabIndex = 0;
            btnSimpanSuhu.Text = "SIMPAN";
            btnSimpanSuhu.UseVisualStyleBackColor = false;
            btnSimpanSuhu.Click += btnSimpanSuhu_Click;
            // 
            // txtCatatanSuhu
            // 
            txtCatatanSuhu.BorderStyle = BorderStyle.FixedSingle;
            txtCatatanSuhu.Font = new Font("Berlin Sans FB", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCatatanSuhu.Location = new Point(20, 320);
            txtCatatanSuhu.Multiline = true;
            txtCatatanSuhu.Name = "txtCatatanSuhu";
            txtCatatanSuhu.Size = new Size(290, 80);
            txtCatatanSuhu.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(20, 295);
            label9.Name = "label9";
            label9.Size = new Size(79, 23);
            label9.TabIndex = 0;
            label9.Text = "Catatan";
            // 
            // cmbGradeMutu
            // 
            cmbGradeMutu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGradeMutu.Font = new Font("Berlin Sans FB", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGradeMutu.FormattingEnabled = true;
            cmbGradeMutu.Location = new Point(20, 245);
            cmbGradeMutu.Name = "cmbGradeMutu";
            cmbGradeMutu.Size = new Size(290, 32);
            cmbGradeMutu.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(20, 220);
            label8.Name = "label8";
            label8.Size = new Size(112, 23);
            label8.TabIndex = 0;
            label8.Text = "Grade Mutu";
            // 
            // txtSuhuAktual
            // 
            txtSuhuAktual.BorderStyle = BorderStyle.FixedSingle;
            txtSuhuAktual.Font = new Font("Berlin Sans FB", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSuhuAktual.Location = new Point(20, 170);
            txtSuhuAktual.Name = "txtSuhuAktual";
            txtSuhuAktual.Size = new Size(290, 32);
            txtSuhuAktual.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(20, 145);
            label7.Name = "label7";
            label7.Size = new Size(152, 23);
            label7.TabIndex = 0;
            label7.Text = "Suhu Aktual (°C)";
            // 
            // cmbRuanganSuhu
            // 
            cmbRuanganSuhu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRuanganSuhu.Font = new Font("Berlin Sans FB", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRuanganSuhu.FormattingEnabled = true;
            cmbRuanganSuhu.Location = new Point(20, 95);
            cmbRuanganSuhu.Name = "cmbRuanganSuhu";
            cmbRuanganSuhu.Size = new Size(290, 32);
            cmbRuanganSuhu.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(20, 70);
            label6.Name = "label6";
            label6.Size = new Size(124, 23);
            label6.TabIndex = 0;
            label6.Text = "Pilih Ruangan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Berlin Sans FB", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(20, 20);
            label5.Name = "label5";
            label5.Size = new Size(429, 35);
            label5.TabIndex = 0;
            label5.Text = "Input Pengecekan Suhu Harian\n";
            // 
            // panelStok
            // 
            panelStok.Controls.Add(btnTambahStok);
            panelStok.Controls.Add(label19);
            panelStok.Controls.Add(dgvStok);
            panelStok.Location = new Point(0, 60);
            panelStok.Name = "panelStok";
            panelStok.Size = new Size(980, 640);
            panelStok.TabIndex = 0;
            panelStok.Visible = false;
            // 
            // btnTambahStok
            // 
            btnTambahStok.BackColor = Color.SteelBlue;
            btnTambahStok.Cursor = Cursors.Hand;
            btnTambahStok.FlatAppearance.BorderSize = 0;
            btnTambahStok.FlatStyle = FlatStyle.Flat;
            btnTambahStok.Font = new Font("Berlin Sans FB", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahStok.ForeColor = Color.White;
            btnTambahStok.Location = new Point(770, 20);
            btnTambahStok.Name = "btnTambahStok";
            btnTambahStok.Size = new Size(150, 35);
            btnTambahStok.TabIndex = 6;
            btnTambahStok.Text = "+ Terima Stok";
            btnTambahStok.UseVisualStyleBackColor = false;
            btnTambahStok.Click += btnTambahStok_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Berlin Sans FB", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.MidnightBlue;
            label19.Location = new Point(20, 20);
            label19.Name = "label19";
            label19.Size = new Size(208, 35);
            label19.TabIndex = 6;
            label19.Text = "Stok & Ruangan";
            // 
            // dgvStok
            // 
            dgvStok.AllowUserToAddRows = false;
            dgvStok.BackgroundColor = Color.White;
            dgvStok.BorderStyle = BorderStyle.None;
            dgvStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStok.Location = new Point(20, 70);
            dgvStok.Name = "dgvStok";
            dgvStok.ReadOnly = true;
            dgvStok.RowHeadersVisible = false;
            dgvStok.RowHeadersWidth = 62;
            dgvStok.Size = new Size(940, 520);
            dgvStok.TabIndex = 0;
            // 
            // panelDashboard
            // 
            panelDashboard.Controls.Add(dgvKondisiRuangan);
            panelDashboard.Controls.Add(dgvRingkasanStok);
            panelDashboard.Controls.Add(cardPeringatan);
            panelDashboard.Controls.Add(cardSuhu);
            panelDashboard.Controls.Add(cardKapasitas);
            panelDashboard.Controls.Add(cardTotalUnit);
            panelDashboard.Location = new Point(0, 60);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(980, 640);
            panelDashboard.TabIndex = 1;
            // 
            // dgvKondisiRuangan
            // 
            dgvKondisiRuangan.AllowUserToAddRows = false;
            dgvKondisiRuangan.BackgroundColor = Color.White;
            dgvKondisiRuangan.BorderStyle = BorderStyle.None;
            dgvKondisiRuangan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKondisiRuangan.Location = new Point(20, 400);
            dgvKondisiRuangan.Name = "dgvKondisiRuangan";
            dgvKondisiRuangan.ReadOnly = true;
            dgvKondisiRuangan.RowHeadersVisible = false;
            dgvKondisiRuangan.RowHeadersWidth = 62;
            dgvKondisiRuangan.Size = new Size(940, 180);
            dgvKondisiRuangan.TabIndex = 0;
            // 
            // dgvRingkasanStok
            // 
            dgvRingkasanStok.AllowUserToAddRows = false;
            dgvRingkasanStok.BackgroundColor = Color.White;
            dgvRingkasanStok.BorderStyle = BorderStyle.None;
            dgvRingkasanStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRingkasanStok.Location = new Point(20, 130);
            dgvRingkasanStok.Name = "dgvRingkasanStok";
            dgvRingkasanStok.ReadOnly = true;
            dgvRingkasanStok.RowHeadersVisible = false;
            dgvRingkasanStok.RowHeadersWidth = 62;
            dgvRingkasanStok.Size = new Size(940, 250);
            dgvRingkasanStok.TabIndex = 0;
            // 
            // cardPeringatan
            // 
            cardPeringatan.BackColor = Color.OrangeRed;
            cardPeringatan.Controls.Add(lblPeringatan);
            cardPeringatan.Controls.Add(label4);
            cardPeringatan.Location = new Point(710, 20);
            cardPeringatan.Name = "cardPeringatan";
            cardPeringatan.Size = new Size(210, 90);
            cardPeringatan.TabIndex = 0;
            // 
            // lblPeringatan
            // 
            lblPeringatan.AutoSize = true;
            lblPeringatan.Font = new Font("Berlin Sans FB", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeringatan.ForeColor = Color.White;
            lblPeringatan.Location = new Point(15, 30);
            lblPeringatan.Name = "lblPeringatan";
            lblPeringatan.Size = new Size(53, 56);
            lblPeringatan.TabIndex = 0;
            lblPeringatan.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Berlin Sans FB", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 10);
            label4.Name = "label4";
            label4.Size = new Size(81, 18);
            label4.TabIndex = 0;
            label4.Text = "Peringatan";
            // 
            // cardSuhu
            // 
            cardSuhu.BackColor = Color.Teal;
            cardSuhu.Controls.Add(label3);
            cardSuhu.Controls.Add(lblSuhu);
            cardSuhu.Location = new Point(480, 20);
            cardSuhu.Name = "cardSuhu";
            cardSuhu.Size = new Size(210, 90);
            cardSuhu.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 10);
            label3.Name = "label3";
            label3.Size = new Size(110, 18);
            label3.TabIndex = 0;
            label3.Text = "Suhu Rata-rata";
            // 
            // lblSuhu
            // 
            lblSuhu.AutoSize = true;
            lblSuhu.Font = new Font("Berlin Sans FB", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSuhu.ForeColor = Color.White;
            lblSuhu.Location = new Point(15, 30);
            lblSuhu.Name = "lblSuhu";
            lblSuhu.Size = new Size(53, 56);
            lblSuhu.TabIndex = 0;
            lblSuhu.Text = "0";
            // 
            // cardKapasitas
            // 
            cardKapasitas.BackColor = Color.DarkViolet;
            cardKapasitas.Controls.Add(lblKapasitas);
            cardKapasitas.Controls.Add(label2);
            cardKapasitas.Location = new Point(250, 20);
            cardKapasitas.Name = "cardKapasitas";
            cardKapasitas.Size = new Size(210, 90);
            cardKapasitas.TabIndex = 0;
            // 
            // lblKapasitas
            // 
            lblKapasitas.AutoSize = true;
            lblKapasitas.Font = new Font("Berlin Sans FB", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKapasitas.ForeColor = Color.White;
            lblKapasitas.Location = new Point(15, 30);
            lblKapasitas.Name = "lblKapasitas";
            lblKapasitas.Size = new Size(53, 56);
            lblKapasitas.TabIndex = 0;
            lblKapasitas.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 10);
            label2.Name = "label2";
            label2.Size = new Size(108, 18);
            label2.TabIndex = 0;
            label2.Text = "Kapasitas Terisi";
            // 
            // cardTotalUnit
            // 
            cardTotalUnit.BackColor = Color.SteelBlue;
            cardTotalUnit.Controls.Add(label1);
            cardTotalUnit.Controls.Add(lblTotalUnit);
            cardTotalUnit.Location = new Point(20, 20);
            cardTotalUnit.Name = "cardTotalUnit";
            cardTotalUnit.Size = new Size(210, 90);
            cardTotalUnit.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(72, 18);
            label1.TabIndex = 0;
            label1.Text = "Total Unit";
            // 
            // lblTotalUnit
            // 
            lblTotalUnit.AutoSize = true;
            lblTotalUnit.Font = new Font("Berlin Sans FB", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalUnit.ForeColor = Color.White;
            lblTotalUnit.Location = new Point(15, 30);
            lblTotalUnit.Name = "lblTotalUnit";
            lblTotalUnit.Size = new Size(0, 56);
            lblTotalUnit.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.BackgroundImage = Properties.Resources.header;
            panelHeader.Controls.Add(lblPageTitle);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(980, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Berlin Sans FB", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.MidnightBlue;
            lblPageTitle.Location = new Point(20, 15);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(163, 35);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Dashboard";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.MidnightBlue;
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1200, 35);
            panelTitleBar.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1155, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 35);
            btnClose.TabIndex = 2;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(1110, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(45, 35);
            btnMaximize.TabIndex = 1;
            btnMaximize.Text = "□";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(1065, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(45, 35);
            btnMinimize.TabIndex = 0;
            btnMinimize.Text = "─";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // FormUtama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1200, 700);
            Controls.Add(panelTitleBar);
            Controls.Add(panelKonten);
            Controls.Add(panelSidebar);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUtama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fishy";
            Load += FormUtama_Load;
            panelLogin.ResumeLayout(false);
            panelKanan.ResumeLayout(false);
            panelKanan.PerformLayout();
            panelKiri.ResumeLayout(false);
            panelKiri.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelKonten.ResumeLayout(false);
            panelMaster.ResumeLayout(false);
            panelMaster.PerformLayout();
            tabMaster.ResumeLayout(false);
            tabIkan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIkan).EndInit();
            tabGudang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGudang).EndInit();
            tabRuang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRuang).EndInit();
            panelLaporan.ResumeLayout(false);
            panelLaporan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).EndInit();
            panelPengiriman.ResumeLayout(false);
            panelPengiriman.PerformLayout();
            panelInputSuhu.ResumeLayout(false);
            panelInputSuhu.PerformLayout();
            panelStok.ResumeLayout(false);
            panelStok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStok).EndInit();
            panelDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKondisiRuangan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRingkasanStok).EndInit();
            cardPeringatan.ResumeLayout(false);
            cardPeringatan.PerformLayout();
            cardSuhu.ResumeLayout(false);
            cardSuhu.PerformLayout();
            cardKapasitas.ResumeLayout(false);
            cardKapasitas.PerformLayout();
            cardTotalUnit.ResumeLayout(false);
            cardTotalUnit.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Panel panelKanan;
        private Panel panelKiri;
        private Label lblWelcome;
        private Label lblTagline;
        private Label lblAppName;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblError;
        private Button btnLogin;
        private Panel panelSidebar;
        private Label lblNamaUser;
        private Label lblLogo;
        public Button btnDashboard;
        private Label lblRoleUser;
        public Button btnStok;
        public Button btnPengiriman;
        public Button btnInputSuhu;
        public Button btnLaporan;
        private Button btnLogout;
        public Button btnMaster;
        private Panel panelKonten;
        private Panel panelHeader;
        private Label lblPageTitle;
        private Panel panelDashboard;
        private Panel panelMaster;
        private Panel panelLaporan;
        private Panel panelPengiriman;
        private Panel panelInputSuhu;
        private Panel panelStok;
        private Panel cardTotalUnit;
        private Label label1;
        private Panel cardKapasitas;
        private Label label2;
        private Label lblTotalUnit;
        private Panel cardSuhu;
        private Label label3;
        private Label lblSuhu;
        private Label lblKapasitas;
        private Panel cardPeringatan;
        private Label lblPeringatan;
        private Label label4;
        private DataGridView dgvKondisiRuangan;
        private DataGridView dgvRingkasanStok;
        private Label label5;
        private DataGridView dgvStok;
        private TextBox txtSuhuAktual;
        private Label label7;
        private ComboBox cmbRuanganSuhu;
        private Label label6;
        private Label label9;
        private ComboBox cmbGradeMutu;
        private Label label8;
        private Button btnSimpanSuhu;
        private TextBox txtCatatanSuhu;
        private Label lblStatusSuhu;
        private Label label11;
        private Label label10;
        private TextBox txtNoArmada;
        private Label label13;
        private TextBox txtTujuan;
        private Label label12;
        private TextBox txtIdPengiriman;
        private TextBox txtKuantitasKirim;
        private Label label15;
        private ComboBox cmbStokKirim;
        private Label label14;
        private Label lblStatusKirim;
        private Button btnProsesKirim;
        private Label label17;
        private Label label16;
        private Button btnFilter;
        private ComboBox cmbFilterMutasi;
        private Label label18;
        private DataGridView dgvLaporan;
        private TabControl tabMaster;
        private TabPage tabIkan;
        private TabPage tabGudang;
        private TabPage tabRuang;
        private DataGridView dgvIkan;
        private Button btnTambahIkan;
        private Button btnTambahGudang;
        private DataGridView dgvGudang;
        private Button btnTambahRuang;
        private DataGridView dgvRuang;
        private Button btnTambahStok;
        private Label label19;
        private Panel panelTitleBar;
        private Button btnMaximize;
        private Button btnMinimize;
        private Button btnClose;
    }
}
