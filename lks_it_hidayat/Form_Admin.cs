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
using Guna.UI2.WinForms;
using System.Data.SqlClient;

namespace lks_it_hidayat
{
    public partial class Form_Admin : Form
    {
        private SqlConnection koneksi;
        public Form_Admin()
        {
            InitializeComponent();
            koneksi = new SqlConnection("Data Source=HIDAYATULLAH;Initial Catalog=LKSITSOFWARE;Integrated Security=True;");
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cari_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = cari_tanggal.Value;
            string query = "SELECT * FROM tb_log WHERE CONVERT(date, waktu) = @selectedDate";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.Parameters.AddWithValue("@selectedDate", selectedDate.Date);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            guna2DataGridView1.DataSource = dataTable;
        }

        private void hapus_semua_data_log_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus semua data pengguna?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM tb_log";
                SqlCommand cmd = new SqlCommand(query, koneksi);

                koneksi.Open();
                cmd.ExecuteNonQuery();
                koneksi.Close();

                TampilkanDataLogActivity();

                MessageBox.Show("Semua data pengguna berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                InsertLogActivity("admin", "Hapus Semua Data Log");
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

        private void Form_Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lKSITSOFWAREDataSet.tb_log' table. You can move, or remove it, as needed.
            this.tb_logTableAdapter.Fill(this.lKSITSOFWAREDataSet.tb_log);
            TampilkanDataLogActivity();
        }
        private void TampilkanDataLogActivity()
        {
            string query = "SELECT * FROM tb_log";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            guna2DataGridView1.DataSource = dataTable;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                InsertLogActivity("admin", "Logout");
                Form_Login loginForm = new Form_Login();
                loginForm.Show();
                this.Hide();
            }
        }

        private void kelola_user_Click(object sender, EventArgs e)
        {
            Form_Kelola_User ku = new Form_Kelola_User();
            ku.Show();
            this.Hide();
        }

        private void kelola_laporan_Click(object sender, EventArgs e)
        {
            Form_Laporan ku = new Form_Laporan();
            ku.Show();
            this.Hide();
        }
    }
}
