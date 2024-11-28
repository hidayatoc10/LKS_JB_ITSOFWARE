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
using System.Windows.Forms.DataVisualization.Charting;

namespace lks_it_hidayat
{
    public partial class Form_Laporan : Form
    {
        private SqlConnection koneksi;
        public Form_Laporan()
        {
            InitializeComponent();
            koneksi = new SqlConnection("Data Source=HIDAYATULLAH;Initial Catalog=LKSITSOFWARE;Integrated Security=True;");
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

        private void data_laporan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Laporan_Load(object sender, EventArgs e)
        {
            this.tb_transaksiTableAdapter1.Fill(this.lKSITSOFWAREDataSet3.tb_transaksi);

        }

        private void tanggal_awal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tanggal_akhir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void filter_Click(object sender, EventArgs e)
        {
            DateTime tanggalAwal = tanggal_awal.Value;
            DateTime tanggalAkhir = tanggal_akhir.Value;
                string query = "SELECT tgl_transaksi, total_bayar FROM tb_transaksi WHERE tgl_transaksi BETWEEN @tanggalAwal AND @tanggalAkhir";
                SqlCommand cmd = new SqlCommand(query, koneksi);
                cmd.Parameters.AddWithValue("@tanggalAwal", tanggalAwal);
                cmd.Parameters.AddWithValue("@tanggalAkhir", tanggalAkhir);
                koneksi.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                chart1.Series[0].Points.Clear();
                while (reader.Read())
                {
                    DateTime tglTransaksi = Convert.ToDateTime(reader["tgl_transaksi"]);
                    double totalBayar = Convert.ToDouble(reader["total_bayar"]);
                    chart1.Series[0].Points.AddXY(tglTransaksi, totalBayar);
                }
                koneksi.Close();
        }


        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbtransaksiBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbtransaksiBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void tbtransaksiBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
