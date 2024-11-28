using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace lks_it_hidayat
{
    public partial class Form_Kelola_Barang : Form
    {
        private SqlConnection koneksi;
        public Form_Kelola_Barang()
        {
            InitializeComponent();
            koneksi = new SqlConnection("Data Source=HIDAYATULLAH;Initial Catalog=LKSITSOFWARE;Integrated Security=True;");
        }
        private void TampilkanData()
        {
            string query = "SELECT * FROM tb_barang";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            guna2DataGridView1.DataSource = dataTable;
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void harga_per_satuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void expired_data_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedUserId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["id_produk"].Value);
                kode_barang.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["kode_produk"].Value.ToString();
                nama_barang.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["nama_produk"].Value.ToString();
                expired_data.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["expired"].Value.ToString();
                jumlah_barang.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["jumlah_produk"].Value.ToString();
                harga_satuan.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["harga_satuan"].Value.ToString();
                ComboBox_satuan.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["satuan"].Value.ToString();
            }
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string createData = "INSERT INTO tb_barang (kode_produk, nama_produk, expired, jumlah_produk, satuan, harga_satuan) VALUES (@kode_barang, @nama_barang, @expired, @jumlah_barang, @satuan, @harga_per_satuan)";
            SqlCommand cmd = new SqlCommand(createData, koneksi);
            cmd.Parameters.AddWithValue("@kode_barang", kode_barang.Text);
            cmd.Parameters.AddWithValue("@nama_barang", nama_barang.Text);

            DateTime expiredDate;
            if (DateTime.TryParse(expired_data.Text, out expiredDate))
            {
                cmd.Parameters.AddWithValue("@expired", expiredDate);
            }
            else
            {
                cmd.Parameters.AddWithValue("@expired", DBNull.Value);
            }

            cmd.Parameters.AddWithValue("@jumlah_barang", jumlah_barang.Text);
            cmd.Parameters.AddWithValue("@harga_per_satuan", harga_satuan.Text);
            cmd.Parameters.AddWithValue("@satuan", ComboBox_satuan.SelectedItem.ToString());

            int i = cmd.ExecuteNonQuery();

            MessageBox.Show("Data barang berhasil tambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            kode_barang.Text = "";
            nama_barang.Text = "";
            expired_data.Text = "";
            jumlah_barang.Text = "";
            ComboBox_satuan.SelectedIndex = -1;
            harga_satuan.Text = "";
            TampilkanData();

            koneksi.Close();
            InsertLogActivity("gudang", "Tambah Data Barang");
        }

        private void Form_Kelola_Barang_Load(object sender, EventArgs e)
        {
            TampilkanData();
        }

        private void harga_satuan_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(harga_satuan.Text))
            {
                int hargaSatuan;
                if (!int.TryParse(harga_satuan.Text, out hargaSatuan))
                {
                    MessageBox.Show("Masukkan hanya angka untuk jumlah barang.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    harga_satuan.Text = "";
                }
            }
        }

        private void ComboBox_satuan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            kode_barang.Text = "";
            nama_barang.Text = "";
            expired_data.Text = "";
            jumlah_barang.Text = "";
            jumlah_barang.Text = "";
            satuan.Text= "";
            ComboBox_satuan.SelectedIndex = -1;
            harga_satuan.Text = "";
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus barang ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedUserId = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells["id_produk"].Value);

                    string query = "DELETE FROM tb_barang WHERE id_produk = @id_barang";
                    SqlCommand cmd = new SqlCommand(query, koneksi);
                    cmd.Parameters.AddWithValue("@id_barang", selectedUserId);

                    koneksi.Open();
                    cmd.ExecuteNonQuery();
                    koneksi.Close();

                    TampilkanData();

                    MessageBox.Show("Data barang berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InsertLogActivity("gudang", "Hapus Data Barang");
                    kode_barang.Text = "";
                    nama_barang.Text = "";
                    expired_data.Text = "";
                    jumlah_barang.Text = "";
                    harga_satuan.Text = "";
                    ComboBox_satuan.SelectedIndex = -1;

                }
            }
            else
            {
                MessageBox.Show("Silakan pilih pengguna yang ingin dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private int selectedUserId;

        private void jumlah_barang_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(jumlah_barang.Text))
            {
                int jumlahBarang;
                if (!int.TryParse(jumlah_barang.Text, out jumlahBarang))
                {
                    MessageBox.Show("Masukkan hanya angka untuk jumlah barang.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    jumlah_barang.Text = "";
                }
            }
        }


        private void edit_Click(object sender, EventArgs e)
        {
            if (selectedUserId != 0)
            {
                if (string.IsNullOrEmpty(kode_barang.Text) || string.IsNullOrEmpty(nama_barang.Text) || string.IsNullOrEmpty(jumlah_barang.Text) || string.IsNullOrEmpty(harga_satuan.Text) || ComboBox_satuan.SelectedIndex == -1)
                {
                    MessageBox.Show("Mohon lengkapi semua kolom", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "UPDATE tb_barang SET kode_produk = @kode_produk, nama_produk = @nama_produk, expired = @expired, jumlah_produk = @jumlah_produk, satuan = @satuan, harga_satuan = @harga_satuan WHERE id_produk = @userId";
                SqlCommand cmd = new SqlCommand(query, koneksi);
                cmd.Parameters.AddWithValue("@kode_produk", kode_barang.Text);
                cmd.Parameters.AddWithValue("@nama_produk", nama_barang.Text);

                DateTime expiredDate;
                if (DateTime.TryParse(expired_data.Text, out expiredDate))
                {
                    cmd.Parameters.AddWithValue("@expired", expiredDate);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@expired", DBNull.Value);
                }

                cmd.Parameters.AddWithValue("@jumlah_produk", jumlah_barang.Text);
                cmd.Parameters.AddWithValue("@satuan", ComboBox_satuan.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@harga_satuan", harga_satuan.Text);
                cmd.Parameters.AddWithValue("@userId", selectedUserId);

                koneksi.Open();
                cmd.ExecuteNonQuery();
                koneksi.Close();

                TampilkanData();

                MessageBox.Show("Data pengguna berhasil diperbarui", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                InsertLogActivity("gudang", "Edit Data Barang");

                kode_barang.Text = "";
                nama_barang.Text = "";
                expired_data.Text = "";
                jumlah_barang.Text = "";
                satuan.Text = "";
                ComboBox_satuan.SelectedIndex = -1;
                harga_satuan.Text = "";
            }
            else
            {
                MessageBox.Show("Silakan pilih pengguna yang ingin diedit", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void SearchLogActivity(string keyword)
        {
            string query = "SELECT * FROM tb_barang WHERE id_produk LIKE @keyword OR kode_produk LIKE @keyword OR nama_produk LIKE @keyword OR expired LIKE @keyword OR jumlah_produk LIKE @keyword OR satuan LIKE @keyword OR tanggal LIKE @keyword OR harga_satuan LIKE @keyword";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            guna2DataGridView1.DataSource = dataTable;
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = guna2TextBox1.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchLogActivity(searchText);
            }
            else
            {
                TampilkanData();
            }
        }
    }
}
