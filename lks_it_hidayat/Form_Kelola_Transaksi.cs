using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lks_it_hidayat
{
    public partial class Form_Kelola_Transaksi : Form
    {
        private SqlConnection koneksi;
        private List<Transaksi> transaksiList;
        private int userId;
        public Form_Kelola_Transaksi()
        {
            InitializeComponent();
            koneksi = new SqlConnection("Data Source=HIDAYATULLAH;Initial Catalog=LKSITSOFWARE;Integrated Security=True;");
            transaksiList = new List<Transaksi>();
            LoadBarangData();
            DisplayAllLogActivity();
            userId = GetUserId("gudang");
            lblEmptyCart.Visible = true;
        }

        private void DisplayAllLogActivity()
        {
            string query = @"
    SELECT t.id_transaksi, t.no_transaksi, t.tgl_transaksi, t.total_bayar, 
           b.nama_produk, t.id_users 
    FROM tb_transaksi t
    JOIN tb_barang b ON t.id_produk = b.id_produk";

            SqlCommand cmd = new SqlCommand(query, koneksi);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DataGridViewDataPembeli.DataSource = dataTable;
        }

        private int GetUserId(string username)
        {
            koneksi.Open();
            SqlCommand cmd = new SqlCommand("SELECT id_users FROM tb_user WHERE username = @username", koneksi);
            cmd.Parameters.AddWithValue("@username", username);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            koneksi.Close();
            return id;
        }

        private void LoadBarangData()
        {
            koneksi.Open();
            SqlCommand cmd = new SqlCommand("SELECT nama_produk FROM tb_barang", koneksi);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                pilih_menu.Items.Add(reader["nama_produk"].ToString());
            }
            reader.Close();
            koneksi.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void InsertLogActivity(string username, string activityType)
        {
            koneksi.Open();

            SqlCommand getUserIdCmd = new SqlCommand("SELECT id_users FROM tb_user WHERE username = @username", koneksi);
            getUserIdCmd.Parameters.AddWithValue("@username", username);
            int userId = Convert.ToInt32(getUserIdCmd.ExecuteScalar());

            string query = "INSERT INTO tb_log (username, aktivitas, id_users) VALUES (@username, @activityType, @userId)";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@activityType", activityType);
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.ExecuteNonQuery();

            koneksi.Close();
        }
        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                InsertLogActivity("gudang", "Logout");
                Form_Login loginForm = new Form_Login();
                loginForm.Show();
                this.Hide();
            }
        }
        private void Form_Kelola_Transaksi_Load(object sender, EventArgs e)
        {
            DisplayAllLogActivity();
        }

        private Transaksi selectedTransaksi;

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
                pilih_menu.SelectedItem = row.Cells["NamaProduk"].Value.ToString();
                total_harga.SelectedText = row.Cells["TotalHarga"].Value.ToString();
                total_bayar.SelectedText = row.Cells["TotalBayar"].Value.ToString();
                quantitas.SelectedText = row.Cells["Quantitas"].Value.ToString();
                selectedTransaksi = transaksiList.FirstOrDefault(t => t.NoTransaksi == row.Cells["NoTransaksi"].Value.ToString());
            }


        }

        private void DataGridViewDataPembeli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cari_data_pembeli_TextChanged(object sender, EventArgs e)
        {
            string searchText = cari_data_pembeli.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchLogActivity(searchText);
            }
        }
        private void SearchLogActivity(string keyword)
        {
            string query = @"
        SELECT t.id_transaksi, t.no_transaksi, t.tgl_transaksi, t.total_bayar, 
               b.nama_produk, t.id_users 
        FROM tb_transaksi t
        JOIN tb_barang b ON t.id_produk = b.id_produk
        WHERE t.id_transaksi LIKE @keyword 
           OR t.no_transaksi LIKE @keyword 
           OR t.tgl_transaksi LIKE @keyword 
           OR t.total_bayar LIKE @keyword 
           OR b.nama_produk LIKE @keyword";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DataGridViewDataPembeli.DataSource = dataTable;
        }

        private void cari_data_keranjang_TextChanged(object sender, EventArgs e)
        {

        }

        private void tambah_Click(object sender, EventArgs e)
        {
            if (pilih_menu.SelectedIndex == -1 || string.IsNullOrWhiteSpace(quantitas.Text) || string.IsNullOrWhiteSpace(harga_satuan.Text))
            {
                MessageBox.Show("Semua kolom harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblEmptyCart.Visible = false;

            string selectedItem = pilih_menu.SelectedItem.ToString();
            int quantity = int.Parse(quantitas.Text);
            double hargaPerSatuan = double.Parse(harga_satuan.Text.Replace("Rp ", "").Replace(",", ""));
            double totalHarga = hargaPerSatuan * quantity;
            total_harga.Text = "Rp " + totalHarga.ToString("#,0.##").Replace(".", ",");

            Transaksi transaksi = new Transaksi
            {
                NoTransaksi = Guid.NewGuid().ToString(),
                TglTransaksi = DateTime.Now,
                NamaProduk = selectedItem,
                TotalBayar = 0,
                IdUsers = userId,
                IdProduk = GetProductId(selectedItem),
                TotalHarga = totalHarga.ToString("#,0.##"),
                Quantitas = quantity
            };
            transaksiList.Add(transaksi);
            guna2DataGridView1.DataSource = null;
            guna2DataGridView1.DataSource = transaksiList;
            MessageBox.Show("Data pengguna berhasil ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pilih_menu.SelectedIndex = -1;
            harga_satuan.Text = "";
            quantitas.Text = "";
            total_harga.Text = "";
            total_bayar.Text = "";
            guna2HtmlLabel11.Text = "Rp. 0";
        }

        private int GetProductId(string productName)
        {
            koneksi.Open();
            SqlCommand cmd = new SqlCommand("SELECT id_produk FROM tb_barang WHERE nama_produk = @productName", koneksi);
            cmd.Parameters.AddWithValue("@productName", productName);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            koneksi.Close();
            return id;
        }

        private void PrintTransaction(Transaksi transaksi)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("A6", 420, 594);
            printDocument.PrintPage += (sender, e) =>
            {
                e.Graphics.DrawString("BUKTI TRANSAKSI", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(40, 20));
                e.Graphics.DrawString($"No Transaksi: {transaksi.NoTransaksi}", new Font("Arial", 10), Brushes.Black, new PointF(40, 50));
                e.Graphics.DrawString($"Tanggal: {transaksi.TglTransaksi}", new Font("Arial", 10), Brushes.Black, new PointF(40, 70));

                int yPos = 100;
                e.Graphics.DrawString("Nama Produk", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new PointF(40, yPos));
                e.Graphics.DrawString("Jumlah", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new PointF(160, yPos));
                e.Graphics.DrawString("Harga Satuan", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new PointF(220, yPos));
                e.Graphics.DrawString("Total Harga", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new PointF(320, yPos));

                yPos += 20;
                e.Graphics.DrawString(transaksi.NamaProduk, new Font("Arial", 10), Brushes.Black, new PointF(40, yPos));
                e.Graphics.DrawString(transaksi.Quantitas.ToString(), new Font("Arial", 10), Brushes.Black, new PointF(160, yPos));
                e.Graphics.DrawString(transaksi.TotalBayar.ToString(), new Font("Arial", 10), Brushes.Black, new PointF(220, yPos));
                e.Graphics.DrawString(transaksi.TotalHarga, new Font("Arial", 10), Brushes.Black, new PointF(320, yPos));

                yPos += 30;
                e.Graphics.DrawString($"Total Bayar: Rp {transaksi.TotalBayar}", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new PointF(220, yPos));
                e.Graphics.DrawString("Halaman 1", new Font("Arial", 8), Brushes.Black, new PointF(320, e.PageBounds.Height - 20));
            };

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            if (selectedTransaksi != null)
            {
                double totalBayar = Convert.ToDouble(total_bayar.Text.Replace("Rp ", "").Replace(".", ""));
                double totalHarga = Convert.ToDouble(total_harga.Text.Replace("Rp ", "").Replace(".", ""));

                if (totalBayar < totalHarga)
                {
                    MessageBox.Show("Maaf, Uang anda kurang.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                selectedTransaksi.TotalBayar = Convert.ToInt64(totalBayar);
                string query = "INSERT INTO tb_transaksi (no_transaksi, tgl_transaksi, total_bayar, id_users, id_produk) VALUES (@no_transaksi, @tgl_transaksi, @total_bayar, @id_users, @id_produk)";
                SqlCommand cmd = new SqlCommand(query, koneksi);
                cmd.Parameters.AddWithValue("@no_transaksi", selectedTransaksi.NoTransaksi);
                cmd.Parameters.AddWithValue("@tgl_transaksi", selectedTransaksi.TglTransaksi);
                cmd.Parameters.AddWithValue("@total_bayar", selectedTransaksi.TotalBayar);
                cmd.Parameters.AddWithValue("@id_users", selectedTransaksi.IdUsers);
                cmd.Parameters.AddWithValue("@id_produk", selectedTransaksi.IdProduk);

                try
                {
                    koneksi.Open();
                    cmd.ExecuteNonQuery();
                    koneksi.Close();
                    MessageBox.Show("Data berhasil disimpan.");
                    transaksiList.Remove(selectedTransaksi);
                    guna2DataGridView1.DataSource = null;
                    guna2DataGridView1.DataSource = transaksiList;
                    PrintTransaction(selectedTransaksi);
                    selectedTransaksi = null;
                    pilih_menu.SelectedIndex = -1;
                    harga_satuan.Text = "";
                    quantitas.Text = "";
                    total_harga.Text = "";
                    total_bayar.Text = "";
                    guna2HtmlLabel11.Text = "Rp. 0";
                }
                catch (Exception ex)
                {
                    koneksi.Close();
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Tidak ada transaksi yang dipilih.");
            }
        }
        private void total_bayar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(total_bayar.Text) && !string.IsNullOrEmpty(total_harga.Text))
            {
                double totalBayar;
                double totalHarga;
                if (!double.TryParse(total_bayar.Text.Replace("Rp ", "").Replace(".", "."), out totalBayar))
                {
                    MessageBox.Show("Masukkan hanya angka untuk total bayar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    total_bayar.Text = "";
                    return;
                }
                totalHarga = double.Parse(total_harga.Text.Replace("Rp ", "").Replace(".", "."));
                double kembalianAmount = totalBayar - totalHarga;
                kembalian.Text = "Rp " + kembalianAmount.ToString("#,0.##").Replace(".", ".");
            }
        }
        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void pilih_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pilih_menu.SelectedItem != null)
            {
                string selectedNamaBarang = pilih_menu.SelectedItem.ToString();
                string query = "SELECT harga_satuan FROM tb_barang WHERE nama_produk = @namaBarang";
                koneksi.Open();
                SqlCommand cmd = new SqlCommand(query, koneksi);
                cmd.Parameters.AddWithValue("@namaBarang", selectedNamaBarang);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    double hargaPerSatuan = double.Parse(reader["harga_satuan"].ToString().Replace(".", ","));
                    harga_satuan.Text = "Rp " + hargaPerSatuan.ToString("#,0.##");
                }
                koneksi.Close();
            }
        }

        private void hapus_Click(object sender, EventArgs e)
        {

        }

        private void total_harga_TextChanged(object sender, EventArgs e)
        {

        }

        private void harga_satuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantitas_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(harga_satuan.Text) && !string.IsNullOrEmpty(quantitas.Text))
            {
                double hargaPerSatuan;
                int jumlahBarang;
                if (!int.TryParse(quantitas.Text, out jumlahBarang))
                {
                    MessageBox.Show("Masukkan hanya angka untuk jumlah barang.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    quantitas.Text = "";
                    return;
                }
                hargaPerSatuan = double.Parse(harga_satuan.Text.Replace("Rp ", "").Replace(".", "."));
                double totalHarga = hargaPerSatuan * jumlahBarang;
                total_harga.Text = "Rp " + totalHarga.ToString("#,0.##").Replace(".", ".");
                guna2HtmlLabel11.Text = "Rp " + totalHarga.ToString("#,0.##").Replace(".", ".");
            }
        }


        private void kembalian_Click(object sender, EventArgs e)
        {

        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        public class Transaksi
        {
            public string NoTransaksi { get; set; }
            public DateTime TglTransaksi { get; set; }
            public string NamaProduk { get; set; }
            public long TotalBayar { get; set; }
            public int IdUsers { get; set; }
            public int IdProduk { get; set; }
            public string TotalHarga { get; set; }
            public long Quantitas { get; set; }
        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void lblEmptyCart_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
