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
            panelKonten = new Panel();
            panelHeader = new Panel();
            lblPageTitle = new Label();
            panelDashboard = new Panel();
            cardTotalUnit = new Panel();
            label1 = new Label();
            lblTotalUnit = new Label();
            cardKapasitas = new Panel();
            lblKapasitas = new Label();
            label2 = new Label();
            cardSuhu = new Panel();
            label3 = new Label();
            lblSuhu = new Label();
            cardPeringatan = new Panel();
            lblPeringatan = new Label();
            label4 = new Label();
            lblRingkasanStokTitle = new Label();
            dgvRingkasanStok = new DataGridView();
            lblKondisiRuanganTitle = new Label();
            dgvKondisiRuangan = new DataGridView();
            panelStok = new Panel();
            btnTambahStok = new Button();
            label19 = new Label();
            dgvStok = new DataGridView();
            panelInputSuhu = new Panel();
            label5 = new Label();
            label6 = new Label();
            cmbRuanganSuhu = new ComboBox();
            label7 = new Label();
            txtSuhuAktual = new TextBox();
            label8 = new Label();
            cmbGradeMutu = new ComboBox();
            label9 = new Label();
            txtCatatanSuhu = new TextBox();
            btnSimpanSuhu = new Button();
            lblStatusSuhu = new Label();
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
            panelLaporan = new Panel();
            label16 = new Label();
            label17 = new Label();
            cmbFilterMutasi = new ComboBox();
            btnFilter = new Button();
            dgvLaporan = new DataGridView();
            lblGrafikTitle = new Label();
            formsPlotMutasi = new ScottPlot.WinForms.FormsPlot();
            panelMaster = new Panel();
            label18 = new Label();
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
            panelTitleBar = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            panelSidebar = new Panel();
            lblNamaUser = new Label();
            lblRoleUser = new Label();
            btnDashboard = new Button();
            btnStok = new Button();
            btnInputSuhu = new Button();
            btnPengiriman = new Button();
            lblLogo = new Label();
            btnLaporan = new Button();
            btnMaster = new Button();
            btnLogout = new Button();
            panelLogin.SuspendLayout();
            panelKanan.SuspendLayout();
            panelKiri.SuspendLayout();
            panelKonten.SuspendLayout();
            panelHeader.SuspendLayout();
            panelDashboard.SuspendLayout();
            cardTotalUnit.SuspendLayout();
            cardKapasitas.SuspendLayout();
            cardSuhu.SuspendLayout();
            cardPeringatan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRingkasanStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKondisiRuangan).BeginInit();
            panelStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStok).BeginInit();
            panelInputSuhu.SuspendLayout();
            panelPengiriman.SuspendLayout();
            panelLaporan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).BeginInit();
            panelMaster.SuspendLayout();
            tabMaster.SuspendLayout();
            tabIkan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIkan).BeginInit();
            tabGudang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGudang).BeginInit();
            tabRuang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRuang).BeginInit();
            panelTitleBar.SuspendLayout();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(panelKanan);
            panelLogin.Controls.Add(panelKiri);
            panelLogin.Location = new Point(0, 35);
            panelLogin.Margin = new Padding(4, 5, 4, 5);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(1200, 665);
            panelLogin.TabIndex = 0;
            // 
            // panelKanan
            // 
            panelKanan.BackColor = Color.White;
            panelKanan.BackgroundImage = Properties.Resources._42432421485151040;
            panelKanan.Controls.Add(lblError);
            panelKanan.Controls.Add(btnLogin);
            panelKanan.Controls.Add(txtPassword);
            panelKanan.Controls.Add(lblPassword);
            panelKanan.Controls.Add(txtUsername);
            panelKanan.Controls.Add(lblUsername);
            panelKanan.Controls.Add(lblWelcome);
            panelKanan.Dock = DockStyle.Fill;
            panelKanan.Location = new Point(500, 0);
            panelKanan.Name = "panelKanan";
            panelKanan.Size = new Size(700, 665);
            panelKanan.TabIndex = 1;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(80, 475);
            lblError.Name = "lblError";
            lblError.Size = new Size(290, 20);
            lblError.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            txtPassword.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(80, 350);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(291, 24);
            txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.DimGray;
            lblPassword.Location = new Point(80, 325);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(69, 17);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(80, 275);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(291, 24);
            txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.DimGray;
            lblUsername.Location = new Point(80, 250);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(73, 17);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.MidnightBlue;
            lblWelcome.Location = new Point(80, 150);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(222, 31);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Selamat Datang";
            // 
            // panelKiri
            // 
            panelKiri.BackColor = Color.SteelBlue;
            panelKiri.Controls.Add(lblTagline);
            panelKiri.Controls.Add(lblAppName);
            panelKiri.Dock = DockStyle.Left;
            panelKiri.Location = new Point(0, 0);
            panelKiri.Name = "panelKiri";
            panelKiri.Size = new Size(500, 665);
            panelKiri.TabIndex = 0;
            // 
            // lblTagline
            // 
            lblTagline.AutoSize = true;
            lblTagline.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTagline.ForeColor = Color.LightSkyBlue;
            lblTagline.Location = new Point(80, 330);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(297, 18);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "Cold Chain Fish Storage Monitoring System";
            lblTagline.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(130, 250);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(189, 44);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "🐟 FISHY";
            // 
            // panelKonten
            // 
            panelKonten.Controls.Add(panelHeader);
            panelKonten.Controls.Add(panelDashboard);
            panelKonten.Controls.Add(panelStok);
            panelKonten.Controls.Add(panelInputSuhu);
            panelKonten.Controls.Add(panelPengiriman);
            panelKonten.Controls.Add(panelLaporan);
            panelKonten.Controls.Add(panelMaster);
            panelKonten.Location = new Point(240, 35);
            panelKonten.Margin = new Padding(6, 8, 6, 8);
            panelKonten.Name = "panelKonten";
            panelKonten.Size = new Size(960, 665);
            panelKonten.TabIndex = 2;
            panelKonten.Visible = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Transparent;
            panelHeader.BackgroundImage = Properties.Resources._42432421485151040;
            panelHeader.Controls.Add(lblPageTitle);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(960, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Berlin Sans FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.DarkSlateGray;
            lblPageTitle.Location = new Point(20, 25);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(158, 23);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Dashboard Page";
            // 
            // panelDashboard
            // 
            panelDashboard.Controls.Add(cardTotalUnit);
            panelDashboard.Controls.Add(cardKapasitas);
            panelDashboard.Controls.Add(cardSuhu);
            panelDashboard.Controls.Add(cardPeringatan);
            panelDashboard.Controls.Add(lblRingkasanStokTitle);
            panelDashboard.Controls.Add(dgvRingkasanStok);
            panelDashboard.Controls.Add(lblKondisiRuanganTitle);
            panelDashboard.Controls.Add(dgvKondisiRuangan);
            panelDashboard.Location = new Point(0, 80);
            panelDashboard.Margin = new Padding(4, 5, 4, 5);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(960, 585);
            panelDashboard.TabIndex = 1;
            panelDashboard.Visible = false;
            // 
            // cardTotalUnit
            // 
            cardTotalUnit.BackColor = Color.SteelBlue;
            cardTotalUnit.Controls.Add(label1);
            cardTotalUnit.Controls.Add(lblTotalUnit);
            cardTotalUnit.Location = new Point(20, 20);
            cardTotalUnit.Name = "cardTotalUnit";
            cardTotalUnit.Size = new Size(210, 110);
            cardTotalUnit.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 10);
            label1.Name = "label1";
            label1.Size = new Size(53, 13);
            label1.TabIndex = 0;
            label1.Text = "Total Unit";
            // 
            // lblTotalUnit
            // 
            lblTotalUnit.AutoSize = true;
            lblTotalUnit.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalUnit.ForeColor = Color.White;
            lblTotalUnit.Location = new Point(14, 32);
            lblTotalUnit.Name = "lblTotalUnit";
            lblTotalUnit.Size = new Size(0, 36);
            lblTotalUnit.TabIndex = 0;
            // 
            // cardKapasitas
            // 
            cardKapasitas.BackColor = Color.DarkViolet;
            cardKapasitas.Controls.Add(lblKapasitas);
            cardKapasitas.Controls.Add(label2);
            cardKapasitas.Location = new Point(257, 20);
            cardKapasitas.Name = "cardKapasitas";
            cardKapasitas.Size = new Size(210, 110);
            cardKapasitas.TabIndex = 0;
            // 
            // lblKapasitas
            // 
            lblKapasitas.AutoSize = true;
            lblKapasitas.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKapasitas.ForeColor = Color.White;
            lblKapasitas.Location = new Point(14, 32);
            lblKapasitas.Name = "lblKapasitas";
            lblKapasitas.Size = new Size(33, 36);
            lblKapasitas.TabIndex = 0;
            lblKapasitas.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 10);
            label2.Name = "label2";
            label2.Size = new Size(81, 13);
            label2.TabIndex = 0;
            label2.Text = "Kapasitas Terisi";
            // 
            // cardSuhu
            // 
            cardSuhu.BackColor = Color.Teal;
            cardSuhu.Controls.Add(label3);
            cardSuhu.Controls.Add(lblSuhu);
            cardSuhu.Location = new Point(494, 20);
            cardSuhu.Margin = new Padding(4, 5, 4, 5);
            cardSuhu.Name = "cardSuhu";
            cardSuhu.Size = new Size(210, 110);
            cardSuhu.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 10);
            label3.Name = "label3";
            label3.Size = new Size(79, 13);
            label3.TabIndex = 0;
            label3.Text = "Suhu Rata-rata";
            // 
            // lblSuhu
            // 
            lblSuhu.AutoSize = true;
            lblSuhu.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSuhu.ForeColor = Color.White;
            lblSuhu.Location = new Point(14, 32);
            lblSuhu.Name = "lblSuhu";
            lblSuhu.Size = new Size(33, 36);
            lblSuhu.TabIndex = 0;
            lblSuhu.Text = "0";
            // 
            // cardPeringatan
            // 
            cardPeringatan.BackColor = Color.OrangeRed;
            cardPeringatan.Controls.Add(lblPeringatan);
            cardPeringatan.Controls.Add(label4);
            cardPeringatan.Location = new Point(731, 20);
            cardPeringatan.Margin = new Padding(4, 5, 4, 5);
            cardPeringatan.Name = "cardPeringatan";
            cardPeringatan.Size = new Size(210, 110);
            cardPeringatan.TabIndex = 0;
            // 
            // lblPeringatan
            // 
            lblPeringatan.AutoSize = true;
            lblPeringatan.Font = new Font("Berlin Sans FB", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeringatan.ForeColor = Color.White;
            lblPeringatan.Location = new Point(14, 32);
            lblPeringatan.Margin = new Padding(4, 0, 4, 0);
            lblPeringatan.Name = "lblPeringatan";
            lblPeringatan.Size = new Size(37, 37);
            lblPeringatan.TabIndex = 0;
            lblPeringatan.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Berlin Sans FB", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 10);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 13);
            label4.TabIndex = 0;
            label4.Text = "Peringatan";
            // 
            // lblRingkasanStokTitle
            // 
            lblRingkasanStokTitle.AutoSize = true;
            lblRingkasanStokTitle.Font = new Font("Berlin Sans FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRingkasanStokTitle.ForeColor = Color.MidnightBlue;
            lblRingkasanStokTitle.Location = new Point(20, 150);
            lblRingkasanStokTitle.Name = "lblRingkasanStokTitle";
            lblRingkasanStokTitle.Size = new Size(126, 20);
            lblRingkasanStokTitle.TabIndex = 0;
            lblRingkasanStokTitle.Text = "Ringkasan Stok";
            // 
            // dgvRingkasanStok
            // 
            dgvRingkasanStok.AllowUserToAddRows = false;
            dgvRingkasanStok.BackgroundColor = Color.White;
            dgvRingkasanStok.BorderStyle = BorderStyle.None;
            dgvRingkasanStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRingkasanStok.Location = new Point(20, 180);
            dgvRingkasanStok.Margin = new Padding(4, 5, 4, 5);
            dgvRingkasanStok.Name = "dgvRingkasanStok";
            dgvRingkasanStok.ReadOnly = true;
            dgvRingkasanStok.RowHeadersVisible = false;
            dgvRingkasanStok.RowHeadersWidth = 62;
            dgvRingkasanStok.Size = new Size(920, 185);
            dgvRingkasanStok.TabIndex = 0;
            // 
            // lblKondisiRuanganTitle
            // 
            lblKondisiRuanganTitle.AutoSize = true;
            lblKondisiRuanganTitle.Font = new Font("Berlin Sans FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKondisiRuanganTitle.ForeColor = Color.MidnightBlue;
            lblKondisiRuanganTitle.Location = new Point(20, 375);
            lblKondisiRuanganTitle.Name = "lblKondisiRuanganTitle";
            lblKondisiRuanganTitle.Size = new Size(138, 20);
            lblKondisiRuanganTitle.TabIndex = 0;
            lblKondisiRuanganTitle.Text = "Kondisi Ruangan";
            // 
            // dgvKondisiRuangan
            // 
            dgvKondisiRuangan.AllowUserToAddRows = false;
            dgvKondisiRuangan.BackgroundColor = Color.White;
            dgvKondisiRuangan.BorderStyle = BorderStyle.None;
            dgvKondisiRuangan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKondisiRuangan.Location = new Point(20, 405);
            dgvKondisiRuangan.Margin = new Padding(4, 5, 4, 5);
            dgvKondisiRuangan.Name = "dgvKondisiRuangan";
            dgvKondisiRuangan.ReadOnly = true;
            dgvKondisiRuangan.RowHeadersVisible = false;
            dgvKondisiRuangan.RowHeadersWidth = 62;
            dgvKondisiRuangan.Size = new Size(920, 170);
            dgvKondisiRuangan.TabIndex = 0;
            // 
            // panelStok
            // 
            panelStok.Controls.Add(btnTambahStok);
            panelStok.Controls.Add(label19);
            panelStok.Controls.Add(dgvStok);
            panelStok.Location = new Point(0, 80);
            panelStok.Margin = new Padding(4, 5, 4, 5);
            panelStok.Name = "panelStok";
            panelStok.Size = new Size(960, 585);
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
            btnTambahStok.Location = new Point(760, 20);
            btnTambahStok.Margin = new Padding(4, 5, 4, 5);
            btnTambahStok.Name = "btnTambahStok";
            btnTambahStok.Size = new Size(180, 40);
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
            label19.Location = new Point(20, 25);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(180, 23);
            label19.TabIndex = 6;
            label19.Text = "Stok dan Ruangan";
            // 
            // dgvStok
            // 
            dgvStok.AllowUserToAddRows = false;
            dgvStok.BackgroundColor = Color.White;
            dgvStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStok.Location = new Point(20, 80);
            dgvStok.Margin = new Padding(4, 5, 4, 5);
            dgvStok.Name = "dgvStok";
            dgvStok.ReadOnly = true;
            dgvStok.RowHeadersVisible = false;
            dgvStok.RowHeadersWidth = 62;
            dgvStok.Size = new Size(920, 485);
            dgvStok.TabIndex = 0;
            // 
            // panelInputSuhu
            // 
            panelInputSuhu.Controls.Add(label5);
            panelInputSuhu.Controls.Add(label6);
            panelInputSuhu.Controls.Add(cmbRuanganSuhu);
            panelInputSuhu.Controls.Add(label7);
            panelInputSuhu.Controls.Add(txtSuhuAktual);
            panelInputSuhu.Controls.Add(label8);
            panelInputSuhu.Controls.Add(cmbGradeMutu);
            panelInputSuhu.Controls.Add(label9);
            panelInputSuhu.Controls.Add(txtCatatanSuhu);
            panelInputSuhu.Controls.Add(btnSimpanSuhu);
            panelInputSuhu.Controls.Add(lblStatusSuhu);
            panelInputSuhu.Location = new Point(0, 80);
            panelInputSuhu.Margin = new Padding(4, 5, 4, 5);
            panelInputSuhu.Name = "panelInputSuhu";
            panelInputSuhu.Size = new Size(960, 585);
            panelInputSuhu.TabIndex = 0;
            panelInputSuhu.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(20, 20);
            label5.Name = "label5";
            label5.Size = new Size(301, 24);
            label5.TabIndex = 0;
            label5.Text = "Input Pengecekan Suhu Harian";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(20, 90);
            label6.Name = "label6";
            label6.Size = new Size(96, 17);
            label6.TabIndex = 0;
            label6.Text = "Pilih Ruangan";
            // 
            // cmbRuanganSuhu
            // 
            cmbRuanganSuhu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRuanganSuhu.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRuanganSuhu.FormattingEnabled = true;
            cmbRuanganSuhu.Location = new Point(20, 120);
            cmbRuanganSuhu.Name = "cmbRuanganSuhu";
            cmbRuanganSuhu.Size = new Size(340, 26);
            cmbRuanganSuhu.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(20, 170);
            label7.Name = "label7";
            label7.Size = new Size(113, 17);
            label7.TabIndex = 0;
            label7.Text = "Suhu Aktual (°C)";
            // 
            // txtSuhuAktual
            // 
            txtSuhuAktual.BorderStyle = BorderStyle.FixedSingle;
            txtSuhuAktual.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSuhuAktual.Location = new Point(20, 200);
            txtSuhuAktual.Name = "txtSuhuAktual";
            txtSuhuAktual.Size = new Size(340, 24);
            txtSuhuAktual.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(20, 245);
            label8.Name = "label8";
            label8.Size = new Size(83, 17);
            label8.TabIndex = 0;
            label8.Text = "Grade Mutu";
            // 
            // cmbGradeMutu
            // 
            cmbGradeMutu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGradeMutu.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGradeMutu.FormattingEnabled = true;
            cmbGradeMutu.Location = new Point(20, 275);
            cmbGradeMutu.Name = "cmbGradeMutu";
            cmbGradeMutu.Size = new Size(340, 26);
            cmbGradeMutu.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(20, 320);
            label9.Name = "label9";
            label9.Size = new Size(57, 17);
            label9.TabIndex = 0;
            label9.Text = "Catatan";
            // 
            // txtCatatanSuhu
            // 
            txtCatatanSuhu.BorderStyle = BorderStyle.FixedSingle;
            txtCatatanSuhu.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCatatanSuhu.Location = new Point(20, 350);
            txtCatatanSuhu.Multiline = true;
            txtCatatanSuhu.Name = "txtCatatanSuhu";
            txtCatatanSuhu.Size = new Size(340, 80);
            txtCatatanSuhu.TabIndex = 0;
            // 
            // btnSimpanSuhu
            // 
            btnSimpanSuhu.BackColor = Color.SteelBlue;
            btnSimpanSuhu.Cursor = Cursors.Hand;
            btnSimpanSuhu.FlatAppearance.BorderSize = 0;
            btnSimpanSuhu.FlatStyle = FlatStyle.Flat;
            btnSimpanSuhu.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpanSuhu.ForeColor = Color.White;
            btnSimpanSuhu.Location = new Point(20, 445);
            btnSimpanSuhu.Name = "btnSimpanSuhu";
            btnSimpanSuhu.Size = new Size(340, 45);
            btnSimpanSuhu.TabIndex = 0;
            btnSimpanSuhu.Text = "SIMPAN";
            btnSimpanSuhu.UseVisualStyleBackColor = false;
            btnSimpanSuhu.Click += btnSimpanSuhu_Click;
            // 
            // lblStatusSuhu
            // 
            lblStatusSuhu.ForeColor = Color.Green;
            lblStatusSuhu.Location = new Point(20, 500);
            lblStatusSuhu.Name = "lblStatusSuhu";
            lblStatusSuhu.Size = new Size(340, 20);
            lblStatusSuhu.TabIndex = 0;
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
            panelPengiriman.Location = new Point(0, 80);
            panelPengiriman.Name = "panelPengiriman";
            panelPengiriman.Size = new Size(960, 585);
            panelPengiriman.TabIndex = 0;
            panelPengiriman.Visible = false;
            // 
            // lblStatusKirim
            // 
            lblStatusKirim.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusKirim.ForeColor = Color.Green;
            lblStatusKirim.Location = new Point(20, 515);
            lblStatusKirim.Name = "lblStatusKirim";
            lblStatusKirim.Size = new Size(340, 20);
            lblStatusKirim.TabIndex = 0;
            // 
            // btnProsesKirim
            // 
            btnProsesKirim.BackColor = Color.Teal;
            btnProsesKirim.Cursor = Cursors.Hand;
            btnProsesKirim.FlatAppearance.BorderSize = 0;
            btnProsesKirim.FlatStyle = FlatStyle.Flat;
            btnProsesKirim.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProsesKirim.ForeColor = Color.White;
            btnProsesKirim.Location = new Point(20, 460);
            btnProsesKirim.Name = "btnProsesKirim";
            btnProsesKirim.Size = new Size(340, 45);
            btnProsesKirim.TabIndex = 0;
            btnProsesKirim.Text = "PROSES PENGIRIMAN";
            btnProsesKirim.UseVisualStyleBackColor = false;
            btnProsesKirim.Click += btnProsesKirim_Click;
            // 
            // txtKuantitasKirim
            // 
            txtKuantitasKirim.BorderStyle = BorderStyle.FixedSingle;
            txtKuantitasKirim.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKuantitasKirim.Location = new Point(20, 395);
            txtKuantitasKirim.Name = "txtKuantitasKirim";
            txtKuantitasKirim.Size = new Size(340, 24);
            txtKuantitasKirim.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DimGray;
            label15.Location = new Point(20, 370);
            label15.Name = "label15";
            label15.Size = new Size(131, 17);
            label15.TabIndex = 0;
            label15.Text = "Kuantitas Kirim (kg)";
            // 
            // cmbStokKirim
            // 
            cmbStokKirim.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStokKirim.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStokKirim.FormattingEnabled = true;
            cmbStokKirim.Location = new Point(20, 320);
            cmbStokKirim.Name = "cmbStokKirim";
            cmbStokKirim.Size = new Size(340, 26);
            cmbStokKirim.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.DimGray;
            label14.Location = new Point(20, 295);
            label14.Name = "label14";
            label14.Size = new Size(66, 17);
            label14.TabIndex = 0;
            label14.Text = "Pilih Stok";
            // 
            // txtNoArmada
            // 
            txtNoArmada.BorderStyle = BorderStyle.FixedSingle;
            txtNoArmada.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNoArmada.Location = new Point(20, 245);
            txtNoArmada.Name = "txtNoArmada";
            txtNoArmada.Size = new Size(340, 24);
            txtNoArmada.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(20, 220);
            label13.Name = "label13";
            label13.Size = new Size(103, 17);
            label13.TabIndex = 0;
            label13.Text = "Nomor Armada";
            // 
            // txtTujuan
            // 
            txtTujuan.BorderStyle = BorderStyle.FixedSingle;
            txtTujuan.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTujuan.Location = new Point(20, 170);
            txtTujuan.Name = "txtTujuan";
            txtTujuan.Size = new Size(340, 24);
            txtTujuan.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DimGray;
            label12.Location = new Point(20, 145);
            label12.Name = "label12";
            label12.Size = new Size(114, 17);
            label12.TabIndex = 0;
            label12.Text = "Tujuan Distribusi";
            // 
            // txtIdPengiriman
            // 
            txtIdPengiriman.BackColor = Color.WhiteSmoke;
            txtIdPengiriman.BorderStyle = BorderStyle.FixedSingle;
            txtIdPengiriman.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdPengiriman.Location = new Point(20, 95);
            txtIdPengiriman.Name = "txtIdPengiriman";
            txtIdPengiriman.ReadOnly = true;
            txtIdPengiriman.Size = new Size(340, 24);
            txtIdPengiriman.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(20, 70);
            label11.Name = "label11";
            label11.Size = new Size(96, 17);
            label11.TabIndex = 0;
            label11.Text = "ID Pengiriman";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.MidnightBlue;
            label10.Location = new Point(20, 20);
            label10.Name = "label10";
            label10.Size = new Size(186, 24);
            label10.TabIndex = 0;
            label10.Text = "Proses Pengiriman";
            // 
            // panelLaporan
            // 
            panelLaporan.Controls.Add(label16);
            panelLaporan.Controls.Add(label17);
            panelLaporan.Controls.Add(cmbFilterMutasi);
            panelLaporan.Controls.Add(btnFilter);
            panelLaporan.Controls.Add(dgvLaporan);
            panelLaporan.Controls.Add(lblGrafikTitle);
            panelLaporan.Controls.Add(formsPlotMutasi);
            panelLaporan.Location = new Point(0, 80);
            panelLaporan.Margin = new Padding(4, 5, 4, 5);
            panelLaporan.Name = "panelLaporan";
            panelLaporan.Size = new Size(960, 585);
            panelLaporan.TabIndex = 0;
            panelLaporan.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.MidnightBlue;
            label16.Location = new Point(20, 20);
            label16.Name = "label16";
            label16.Size = new Size(229, 24);
            label16.TabIndex = 0;
            label16.Text = "Laporan Riwayat Mutasi";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.DimGray;
            label17.Location = new Point(20, 70);
            label17.Name = "label17";
            label17.Size = new Size(121, 17);
            label17.TabIndex = 0;
            label17.Text = "Filter Jenis Mutasi";
            // 
            // cmbFilterMutasi
            // 
            cmbFilterMutasi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterMutasi.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFilterMutasi.FormattingEnabled = true;
            cmbFilterMutasi.Location = new Point(20, 95);
            cmbFilterMutasi.Name = "cmbFilterMutasi";
            cmbFilterMutasi.Size = new Size(200, 26);
            cmbFilterMutasi.TabIndex = 0;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.SteelBlue;
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(234, 95);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(150, 34);
            btnFilter.TabIndex = 0;
            btnFilter.Text = "TAMPILKAN";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // dgvLaporan
            // 
            dgvLaporan.AllowUserToAddRows = false;
            dgvLaporan.BackgroundColor = Color.White;
            dgvLaporan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaporan.Location = new Point(20, 145);
            dgvLaporan.Name = "dgvLaporan";
            dgvLaporan.ReadOnly = true;
            dgvLaporan.RowHeadersVisible = false;
            dgvLaporan.RowHeadersWidth = 62;
            dgvLaporan.Size = new Size(540, 420);
            dgvLaporan.TabIndex = 0;
            // 
            // lblGrafikTitle
            // 
            lblGrafikTitle.AutoSize = true;
            lblGrafikTitle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrafikTitle.ForeColor = Color.DimGray;
            lblGrafikTitle.Location = new Point(580, 70);
            lblGrafikTitle.Name = "lblGrafikTitle";
            lblGrafikTitle.Size = new Size(300, 17);
            lblGrafikTitle.TabIndex = 0;
            lblGrafikTitle.Text = "Grafik Mutasi Stok: Masuk vs Keluar (Manajer)";
            // 
            // formsPlotMutasi
            // 
            formsPlotMutasi.Location = new Point(580, 145);
            formsPlotMutasi.Name = "formsPlotMutasi";
            formsPlotMutasi.Size = new Size(360, 420);
            formsPlotMutasi.TabIndex = 0;
            // 
            // panelMaster
            // 
            panelMaster.Controls.Add(label18);
            panelMaster.Controls.Add(tabMaster);
            panelMaster.Location = new Point(0, 80);
            panelMaster.Margin = new Padding(4, 5, 4, 5);
            panelMaster.Name = "panelMaster";
            panelMaster.Size = new Size(960, 585);
            panelMaster.TabIndex = 0;
            panelMaster.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.MidnightBlue;
            label18.Location = new Point(20, 20);
            label18.Name = "label18";
            label18.Size = new Size(152, 29);
            label18.TabIndex = 0;
            label18.Text = "Master Data";
            // 
            // tabMaster
            // 
            tabMaster.Controls.Add(tabIkan);
            tabMaster.Controls.Add(tabGudang);
            tabMaster.Controls.Add(tabRuang);
            tabMaster.Location = new Point(20, 70);
            tabMaster.Name = "tabMaster";
            tabMaster.SelectedIndex = 0;
            tabMaster.Size = new Size(920, 495);
            tabMaster.TabIndex = 1;
            // 
            // tabIkan
            // 
            tabIkan.Controls.Add(btnTambahIkan);
            tabIkan.Controls.Add(dgvIkan);
            tabIkan.Location = new Point(4, 24);
            tabIkan.Name = "tabIkan";
            tabIkan.Padding = new Padding(4, 5, 4, 5);
            tabIkan.Size = new Size(912, 467);
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
            btnTambahIkan.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahIkan.ForeColor = Color.White;
            btnTambahIkan.Location = new Point(752, 10);
            btnTambahIkan.Name = "btnTambahIkan";
            btnTambahIkan.Size = new Size(150, 35);
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
            dgvIkan.Location = new Point(10, 55);
            dgvIkan.Name = "dgvIkan";
            dgvIkan.ReadOnly = true;
            dgvIkan.RowHeadersVisible = false;
            dgvIkan.RowHeadersWidth = 62;
            dgvIkan.Size = new Size(892, 396);
            dgvIkan.TabIndex = 0;
            // 
            // tabGudang
            // 
            tabGudang.Controls.Add(btnTambahGudang);
            tabGudang.Controls.Add(dgvGudang);
            tabGudang.Location = new Point(4, 24);
            tabGudang.Name = "tabGudang";
            tabGudang.Padding = new Padding(4, 5, 4, 5);
            tabGudang.Size = new Size(912, 467);
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
            btnTambahGudang.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahGudang.ForeColor = Color.White;
            btnTambahGudang.Location = new Point(752, 10);
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
            dgvGudang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGudang.Location = new Point(10, 55);
            dgvGudang.Name = "dgvGudang";
            dgvGudang.ReadOnly = true;
            dgvGudang.RowHeadersVisible = false;
            dgvGudang.RowHeadersWidth = 62;
            dgvGudang.Size = new Size(892, 396);
            dgvGudang.TabIndex = 2;
            // 
            // tabRuang
            // 
            tabRuang.Controls.Add(btnTambahRuang);
            tabRuang.Controls.Add(dgvRuang);
            tabRuang.Location = new Point(4, 24);
            tabRuang.Name = "tabRuang";
            tabRuang.Padding = new Padding(4, 5, 4, 5);
            tabRuang.Size = new Size(912, 467);
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
            btnTambahRuang.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahRuang.ForeColor = Color.White;
            btnTambahRuang.Location = new Point(752, 10);
            btnTambahRuang.Name = "btnTambahRuang";
            btnTambahRuang.Size = new Size(150, 35);
            btnTambahRuang.TabIndex = 5;
            btnTambahRuang.Text = "+ Tambah Ruangan";
            btnTambahRuang.UseVisualStyleBackColor = false;
            // 
            // dgvRuang
            // 
            dgvRuang.AllowUserToAddRows = false;
            dgvRuang.BackgroundColor = Color.White;
            dgvRuang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRuang.Location = new Point(10, 55);
            dgvRuang.Name = "dgvRuang";
            dgvRuang.ReadOnly = true;
            dgvRuang.RowHeadersVisible = false;
            dgvRuang.RowHeadersWidth = 62;
            dgvRuang.Size = new Size(892, 396);
            dgvRuang.TabIndex = 4;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.MidnightBlue;
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Margin = new Padding(4, 5, 4, 5);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1200, 35);
            panelTitleBar.TabIndex = 2;
            // 
            // btnMinimize
            // 
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(1080, 0);
            btnMinimize.Margin = new Padding(6, 8, 6, 8);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(40, 35);
            btnMinimize.TabIndex = 0;
            btnMinimize.Text = "─";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(1120, 0);
            btnMaximize.Margin = new Padding(6, 8, 6, 8);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(40, 35);
            btnMaximize.TabIndex = 1;
            btnMaximize.Text = "□";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1160, 0);
            btnClose.Margin = new Padding(6, 8, 6, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 35);
            btnClose.TabIndex = 2;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.SteelBlue;
            panelSidebar.Controls.Add(lblNamaUser);
            panelSidebar.Controls.Add(lblRoleUser);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(btnStok);
            panelSidebar.Controls.Add(btnInputSuhu);
            panelSidebar.Controls.Add(btnPengiriman);
            panelSidebar.Controls.Add(lblLogo);
            panelSidebar.Controls.Add(btnLaporan);
            panelSidebar.Controls.Add(btnMaster);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.ForeColor = Color.White;
            panelSidebar.Location = new Point(0, 35);
            panelSidebar.Margin = new Padding(6, 8, 6, 8);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(240, 665);
            panelSidebar.TabIndex = 2;
            panelSidebar.Visible = false;
            // 
            // lblNamaUser
            // 
            lblNamaUser.AutoSize = true;
            lblNamaUser.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNamaUser.ForeColor = Color.MidnightBlue;
            lblNamaUser.Location = new Point(20, 95);
            lblNamaUser.Margin = new Padding(4, 0, 4, 0);
            lblNamaUser.Name = "lblNamaUser";
            lblNamaUser.Size = new Size(100, 13);
            lblNamaUser.TabIndex = 1;
            lblNamaUser.Text = "Halo, [NamaUser]";
            // 
            // lblRoleUser
            // 
            lblRoleUser.AutoSize = true;
            lblRoleUser.BackColor = Color.DeepSkyBlue;
            lblRoleUser.Font = new Font("Berlin Sans FB", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoleUser.Location = new Point(20, 128);
            lblRoleUser.Margin = new Padding(4, 0, 4, 0);
            lblRoleUser.Name = "lblRoleUser";
            lblRoleUser.Size = new Size(52, 15);
            lblRoleUser.TabIndex = 2;
            lblRoleUser.Text = "Manajer";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.LightCyan;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.MidnightBlue;
            btnDashboard.Location = new Point(0, 170);
            btnDashboard.Margin = new Padding(4, 5, 4, 5);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(29, 0, 0, 0);
            btnDashboard.Size = new Size(240, 55);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "📊  Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnStok
            // 
            btnStok.BackColor = Color.Transparent;
            btnStok.Cursor = Cursors.Hand;
            btnStok.FlatAppearance.BorderSize = 0;
            btnStok.FlatStyle = FlatStyle.Flat;
            btnStok.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStok.ForeColor = Color.MidnightBlue;
            btnStok.Location = new Point(0, 225);
            btnStok.Margin = new Padding(4, 5, 4, 5);
            btnStok.Name = "btnStok";
            btnStok.Padding = new Padding(29, 0, 0, 0);
            btnStok.Size = new Size(240, 55);
            btnStok.TabIndex = 4;
            btnStok.Text = "🏪  Stok dan Ruang";
            btnStok.TextAlign = ContentAlignment.MiddleLeft;
            btnStok.UseVisualStyleBackColor = false;
            btnStok.Click += btnStok_Click;
            // 
            // btnInputSuhu
            // 
            btnInputSuhu.BackColor = Color.Transparent;
            btnInputSuhu.Cursor = Cursors.Hand;
            btnInputSuhu.FlatAppearance.BorderSize = 0;
            btnInputSuhu.FlatStyle = FlatStyle.Flat;
            btnInputSuhu.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInputSuhu.ForeColor = Color.MidnightBlue;
            btnInputSuhu.Location = new Point(0, 280);
            btnInputSuhu.Margin = new Padding(4, 5, 4, 5);
            btnInputSuhu.Name = "btnInputSuhu";
            btnInputSuhu.Padding = new Padding(29, 0, 0, 0);
            btnInputSuhu.Size = new Size(240, 55);
            btnInputSuhu.TabIndex = 5;
            btnInputSuhu.Text = "🌡️  Input Suhu";
            btnInputSuhu.TextAlign = ContentAlignment.MiddleLeft;
            btnInputSuhu.UseVisualStyleBackColor = false;
            btnInputSuhu.Click += btnInputSuhu_Click;
            // 
            // btnPengiriman
            // 
            btnPengiriman.BackColor = Color.Transparent;
            btnPengiriman.Cursor = Cursors.Hand;
            btnPengiriman.FlatAppearance.BorderSize = 0;
            btnPengiriman.FlatStyle = FlatStyle.Flat;
            btnPengiriman.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPengiriman.ForeColor = Color.MidnightBlue;
            btnPengiriman.Location = new Point(0, 335);
            btnPengiriman.Margin = new Padding(4, 5, 4, 5);
            btnPengiriman.Name = "btnPengiriman";
            btnPengiriman.Padding = new Padding(29, 0, 0, 0);
            btnPengiriman.Size = new Size(240, 55);
            btnPengiriman.TabIndex = 6;
            btnPengiriman.Text = "🚚  Pengiriman";
            btnPengiriman.TextAlign = ContentAlignment.MiddleLeft;
            btnPengiriman.UseVisualStyleBackColor = false;
            btnPengiriman.Click += btnPengiriman_Click;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.SteelBlue;
            lblLogo.Font = new Font("Berlin Sans FB", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.Location = new Point(45, 15);
            lblLogo.Margin = new Padding(4, 0, 4, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(108, 27);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "🐟 FISHY";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLaporan
            // 
            btnLaporan.BackColor = Color.Transparent;
            btnLaporan.Cursor = Cursors.Hand;
            btnLaporan.FlatAppearance.BorderSize = 0;
            btnLaporan.FlatStyle = FlatStyle.Flat;
            btnLaporan.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLaporan.ForeColor = Color.MidnightBlue;
            btnLaporan.Location = new Point(0, 390);
            btnLaporan.Margin = new Padding(4, 5, 4, 5);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Padding = new Padding(29, 0, 0, 0);
            btnLaporan.Size = new Size(240, 55);
            btnLaporan.TabIndex = 7;
            btnLaporan.Text = "📋  Laporan";
            btnLaporan.TextAlign = ContentAlignment.MiddleLeft;
            btnLaporan.UseVisualStyleBackColor = false;
            btnLaporan.Click += btnLaporan_Click;
            // 
            // btnMaster
            // 
            btnMaster.BackColor = Color.Transparent;
            btnMaster.Cursor = Cursors.Hand;
            btnMaster.FlatAppearance.BorderSize = 0;
            btnMaster.FlatStyle = FlatStyle.Flat;
            btnMaster.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMaster.ForeColor = Color.MidnightBlue;
            btnMaster.Location = new Point(0, 445);
            btnMaster.Margin = new Padding(4, 5, 4, 5);
            btnMaster.Name = "btnMaster";
            btnMaster.Padding = new Padding(29, 0, 0, 0);
            btnMaster.Size = new Size(240, 55);
            btnMaster.TabIndex = 8;
            btnMaster.Text = "⚙️  Master Data";
            btnMaster.TextAlign = ContentAlignment.MiddleLeft;
            btnMaster.UseVisualStyleBackColor = false;
            btnMaster.Click += btnMaster_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Azure;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Red;
            btnLogout.Location = new Point(0, 590);
            btnLogout.Margin = new Padding(4, 5, 4, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(29, 0, 0, 0);
            btnLogout.Size = new Size(240, 55);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "🚪  Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // FormUtama
            // 
            AutoScaleMode = AutoScaleMode.None;
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
            panelKonten.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelDashboard.ResumeLayout(false);
            panelDashboard.PerformLayout();
            cardTotalUnit.ResumeLayout(false);
            cardTotalUnit.PerformLayout();
            cardKapasitas.ResumeLayout(false);
            cardKapasitas.PerformLayout();
            cardSuhu.ResumeLayout(false);
            cardSuhu.PerformLayout();
            cardPeringatan.ResumeLayout(false);
            cardPeringatan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRingkasanStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKondisiRuangan).EndInit();
            panelStok.ResumeLayout(false);
            panelStok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStok).EndInit();
            panelInputSuhu.ResumeLayout(false);
            panelInputSuhu.PerformLayout();
            panelPengiriman.ResumeLayout(false);
            panelPengiriman.PerformLayout();
            panelLaporan.ResumeLayout(false);
            panelLaporan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporan).EndInit();
            panelMaster.ResumeLayout(false);
            panelMaster.PerformLayout();
            tabMaster.ResumeLayout(false);
            tabIkan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIkan).EndInit();
            tabGudang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGudang).EndInit();
            tabRuang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRuang).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
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
        private Label lblRingkasanStokTitle;
        private Label lblKondisiRuanganTitle;
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
        private Label lblGrafikTitle;
        private ScottPlot.WinForms.FormsPlot formsPlotMutasi;
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
        private Label lblNamaUser;
        private Label lblRoleUser;
        public Button btnDashboard;
        public Button btnStok;
        public Button btnInputSuhu;
        public Button btnPengiriman;
        public Label lblLogo;
        public Button btnLaporan;
        public Button btnMaster;
        private Button btnLogout;
        private Panel panelSidebar;
    }
}