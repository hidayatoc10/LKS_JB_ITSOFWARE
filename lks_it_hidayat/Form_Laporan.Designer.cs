namespace lks_it_hidayat
{
    partial class Form_Laporan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Laporan));
            this.tanggal_akhir = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.tanggal_awal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.filter = new Guna.UI2.WinForms.Guna2Button();
            this.data_laporan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idtransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgltransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalbayarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbtransaksiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.lKSITSOFWAREDataSet3 = new lks_it_hidayat.LKSITSOFWAREDataSet3();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.logout = new Guna.UI2.WinForms.Guna2Button();
            this.kelola_laporan = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.kelola_user = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbtransaksiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbtransaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lKSITSOFWAREDataSet2 = new lks_it_hidayat.LKSITSOFWAREDataSet2();
            this.tbtransaksiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tb_transaksiTableAdapter = new lks_it_hidayat.LKSITSOFWAREDataSet2TableAdapters.tb_transaksiTableAdapter();
            this.tb_transaksiTableAdapter1 = new lks_it_hidayat.LKSITSOFWAREDataSet3TableAdapters.tb_transaksiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.data_laporan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtransaksiBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKSITSOFWAREDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtransaksiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtransaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKSITSOFWAREDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtransaksiBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tanggal_akhir
            // 
            this.tanggal_akhir.BorderRadius = 10;
            this.tanggal_akhir.Checked = true;
            this.tanggal_akhir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tanggal_akhir.FillColor = System.Drawing.SystemColors.Control;
            this.tanggal_akhir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggal_akhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tanggal_akhir.Location = new System.Drawing.Point(491, 119);
            this.tanggal_akhir.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tanggal_akhir.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tanggal_akhir.Name = "tanggal_akhir";
            this.tanggal_akhir.Size = new System.Drawing.Size(204, 36);
            this.tanggal_akhir.TabIndex = 80;
            this.tanggal_akhir.Value = new System.DateTime(2024, 4, 18, 9, 10, 4, 730);
            this.tanggal_akhir.ValueChanged += new System.EventHandler(this.tanggal_akhir_ValueChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(491, 91);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(99, 22);
            this.guna2HtmlLabel4.TabIndex = 79;
            this.guna2HtmlLabel4.Text = "Tanggal Akhir";
            this.guna2HtmlLabel4.Click += new System.EventHandler(this.guna2HtmlLabel4_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(272, 91);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(95, 22);
            this.guna2HtmlLabel3.TabIndex = 76;
            this.guna2HtmlLabel3.Text = "Tanggal Awal";
            this.guna2HtmlLabel3.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(410, 14);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(241, 39);
            this.guna2HtmlLabel2.TabIndex = 75;
            this.guna2HtmlLabel2.Text = "Laporan Penjualan";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Button1.Location = new System.Drawing.Point(794, -1);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(47, 38);
            this.guna2Button1.TabIndex = 73;
            this.guna2Button1.Text = "X";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // tanggal_awal
            // 
            this.tanggal_awal.BorderRadius = 10;
            this.tanggal_awal.Checked = true;
            this.tanggal_awal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tanggal_awal.FillColor = System.Drawing.SystemColors.Control;
            this.tanggal_awal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggal_awal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tanggal_awal.Location = new System.Drawing.Point(272, 119);
            this.tanggal_awal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tanggal_awal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tanggal_awal.Name = "tanggal_awal";
            this.tanggal_awal.Size = new System.Drawing.Size(204, 36);
            this.tanggal_awal.TabIndex = 78;
            this.tanggal_awal.Value = new System.DateTime(2024, 4, 18, 9, 10, 4, 730);
            this.tanggal_awal.ValueChanged += new System.EventHandler(this.tanggal_awal_ValueChanged);
            // 
            // filter
            // 
            this.filter.BorderRadius = 10;
            this.filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.filter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.filter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.filter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.filter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.filter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.filter.ForeColor = System.Drawing.Color.Black;
            this.filter.Location = new System.Drawing.Point(701, 119);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(118, 36);
            this.filter.TabIndex = 74;
            this.filter.Text = "Filter";
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // data_laporan
            // 
            this.data_laporan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.data_laporan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_laporan.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_laporan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_laporan.ColumnHeadersHeight = 26;
            this.data_laporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.data_laporan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtransaksiDataGridViewTextBoxColumn,
            this.tgltransaksiDataGridViewTextBoxColumn,
            this.totalbayarDataGridViewTextBoxColumn});
            this.data_laporan.DataSource = this.tbtransaksiBindingSource3;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_laporan.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_laporan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data_laporan.Location = new System.Drawing.Point(272, 174);
            this.data_laporan.Name = "data_laporan";
            this.data_laporan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_laporan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data_laporan.RowHeadersVisible = false;
            this.data_laporan.Size = new System.Drawing.Size(547, 229);
            this.data_laporan.TabIndex = 77;
            this.data_laporan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.data_laporan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.data_laporan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.data_laporan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.data_laporan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.data_laporan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.data_laporan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data_laporan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.data_laporan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_laporan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_laporan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.data_laporan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.data_laporan.ThemeStyle.HeaderStyle.Height = 26;
            this.data_laporan.ThemeStyle.ReadOnly = false;
            this.data_laporan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.data_laporan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_laporan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_laporan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.data_laporan.ThemeStyle.RowsStyle.Height = 22;
            this.data_laporan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data_laporan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.data_laporan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_laporan_CellContentClick);
            // 
            // idtransaksiDataGridViewTextBoxColumn
            // 
            this.idtransaksiDataGridViewTextBoxColumn.DataPropertyName = "id_transaksi";
            this.idtransaksiDataGridViewTextBoxColumn.HeaderText = "ID Transaksi";
            this.idtransaksiDataGridViewTextBoxColumn.Name = "idtransaksiDataGridViewTextBoxColumn";
            this.idtransaksiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tgltransaksiDataGridViewTextBoxColumn
            // 
            this.tgltransaksiDataGridViewTextBoxColumn.DataPropertyName = "tgl_transaksi";
            this.tgltransaksiDataGridViewTextBoxColumn.HeaderText = "Tanggal Transaksi";
            this.tgltransaksiDataGridViewTextBoxColumn.Name = "tgltransaksiDataGridViewTextBoxColumn";
            // 
            // totalbayarDataGridViewTextBoxColumn
            // 
            this.totalbayarDataGridViewTextBoxColumn.DataPropertyName = "total_bayar";
            this.totalbayarDataGridViewTextBoxColumn.HeaderText = "Total Pembayaran";
            this.totalbayarDataGridViewTextBoxColumn.Name = "totalbayarDataGridViewTextBoxColumn";
            // 
            // tbtransaksiBindingSource3
            // 
            this.tbtransaksiBindingSource3.DataMember = "tb_transaksi";
            this.tbtransaksiBindingSource3.DataSource = this.lKSITSOFWAREDataSet3;
            // 
            // lKSITSOFWAREDataSet3
            // 
            this.lKSITSOFWAREDataSet3.DataSetName = "LKSITSOFWAREDataSet3";
            this.lKSITSOFWAREDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // logout
            // 
            this.logout.BorderRadius = 10;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.logout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.logout.ForeColor = System.Drawing.Color.Black;
            this.logout.Location = new System.Drawing.Point(24, 449);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(204, 42);
            this.logout.TabIndex = 9;
            this.logout.Text = "Logout";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // kelola_laporan
            // 
            this.kelola_laporan.BorderRadius = 10;
            this.kelola_laporan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kelola_laporan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.kelola_laporan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.kelola_laporan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.kelola_laporan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.kelola_laporan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.kelola_laporan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.kelola_laporan.ForeColor = System.Drawing.Color.Black;
            this.kelola_laporan.Location = new System.Drawing.Point(24, 390);
            this.kelola_laporan.Name = "kelola_laporan";
            this.kelola_laporan.Size = new System.Drawing.Size(204, 42);
            this.kelola_laporan.TabIndex = 8;
            this.kelola_laporan.Text = "Kelola Laporan";
            this.kelola_laporan.Click += new System.EventHandler(this.kelola_laporan_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(88, 43);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(88, 39);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "Admin";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // kelola_user
            // 
            this.kelola_user.BorderRadius = 10;
            this.kelola_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kelola_user.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.kelola_user.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.kelola_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.kelola_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.kelola_user.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.kelola_user.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.kelola_user.ForeColor = System.Drawing.Color.Black;
            this.kelola_user.Location = new System.Drawing.Point(24, 332);
            this.kelola_user.Name = "kelola_user";
            this.kelola_user.Size = new System.Drawing.Size(204, 42);
            this.kelola_user.TabIndex = 5;
            this.kelola_user.Text = "Kelola User";
            this.kelola_user.Click += new System.EventHandler(this.kelola_user_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.kelola_laporan);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.kelola_user);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 604);
            this.panel1.TabIndex = 72;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lks_it_hidayat.Properties.Resources.administrator1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbtransaksiBindingSource1
            // 
            this.tbtransaksiBindingSource1.DataMember = "tb_transaksi";
            this.tbtransaksiBindingSource1.CurrentChanged += new System.EventHandler(this.tbtransaksiBindingSource1_CurrentChanged);
            // 
            // tbtransaksiBindingSource
            // 
            this.tbtransaksiBindingSource.DataMember = "tb_transaksi";
            this.tbtransaksiBindingSource.CurrentChanged += new System.EventHandler(this.tbtransaksiBindingSource_CurrentChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(290, 409);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Hasil";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 181);
            this.chart1.TabIndex = 81;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lKSITSOFWAREDataSet2
            // 
            this.lKSITSOFWAREDataSet2.DataSetName = "LKSITSOFWAREDataSet2";
            this.lKSITSOFWAREDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbtransaksiBindingSource2
            // 
            this.tbtransaksiBindingSource2.DataMember = "tb_transaksi";
            this.tbtransaksiBindingSource2.DataSource = this.lKSITSOFWAREDataSet2;
            this.tbtransaksiBindingSource2.CurrentChanged += new System.EventHandler(this.tbtransaksiBindingSource2_CurrentChanged);
            // 
            // tb_transaksiTableAdapter
            // 
            this.tb_transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // tb_transaksiTableAdapter1
            // 
            this.tb_transaksiTableAdapter1.ClearBeforeFill = true;
            // 
            // Form_Laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(841, 602);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tanggal_akhir);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.tanggal_awal);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.data_laporan);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(841, 602);
            this.MinimumSize = new System.Drawing.Size(841, 602);
            this.Name = "Form_Laporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Laporan";
            this.Load += new System.EventHandler(this.Form_Laporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_laporan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtransaksiBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKSITSOFWAREDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtransaksiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtransaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKSITSOFWAREDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtransaksiBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tbtransaksiBindingSource;
        private Guna.UI2.WinForms.Guna2DateTimePicker tanggal_akhir;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.BindingSource tbtransaksiBindingSource1;
        private Guna.UI2.WinForms.Guna2DateTimePicker tanggal_awal;
        private Guna.UI2.WinForms.Guna2Button filter;
        private Guna.UI2.WinForms.Guna2DataGridView data_laporan;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button logout;
        private Guna.UI2.WinForms.Guna2Button kelola_laporan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button kelola_user;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private LKSITSOFWAREDataSet2 lKSITSOFWAREDataSet2;
        private System.Windows.Forms.BindingSource tbtransaksiBindingSource2;
        private LKSITSOFWAREDataSet2TableAdapters.tb_transaksiTableAdapter tb_transaksiTableAdapter;
        private LKSITSOFWAREDataSet3 lKSITSOFWAREDataSet3;
        private System.Windows.Forms.BindingSource tbtransaksiBindingSource3;
        private LKSITSOFWAREDataSet3TableAdapters.tb_transaksiTableAdapter tb_transaksiTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgltransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalbayarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusersDataGridViewTextBoxColumn;
    }
}