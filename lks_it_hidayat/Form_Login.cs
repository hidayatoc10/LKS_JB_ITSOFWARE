using Guna.UI2.WinForms;
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

namespace lks_it_hidayat
{
    public partial class Form_Login : Form
    {
        private SqlConnection koneksi;
        public Form_Login()
        {
            InitializeComponent();
            koneksi = new SqlConnection("Data Source=HIDAYATULLAH;Initial Catalog=LKSITSOFWARE;Integrated Security=True;");
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Username dan Password Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT tipe_users FROM tb_user WHERE username = @username AND password = @password", koneksi);
                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@password", textBox1.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        string level = dr["tipe_users"].ToString().Trim().ToLower();
                        if (level.Equals("admin"))
                        {
                            InsertLogActivity(username.Text, "Login");
                            this.Hide();
                            Form_Admin HalamanAdmin = new Form_Admin();
                            HalamanAdmin.Show();
                        }
                        else if (level.Equals("gudang"))
                        {
                            InsertLogActivity(username.Text, "Login");
                            this.Hide();
                            Form_Kelola_Barang HalamanPetugas = new Form_Kelola_Barang();
                            HalamanPetugas.Show();
                        }
                        else if (level.Equals("kasir"))
                        {
                            InsertLogActivity(username.Text, "Login");
                            this.Hide();
                            Form_Kelola_Transaksi HalamanPetugas = new Form_Kelola_Transaksi();
                            HalamanPetugas.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Login Gagal, Silahkan Coba Lagi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            koneksi.Close();
        }
        private void InsertLogActivity(string username, string aktivitas)
        {
            SqlCommand getUserIdCmd = new SqlCommand("SELECT id_users FROM tb_user WHERE username = @username", koneksi);
            getUserIdCmd.Parameters.AddWithValue("@username", username);
            int userId = Convert.ToInt32(getUserIdCmd.ExecuteScalar());

            string query = "INSERT INTO tb_log (username, aktivitas, id_users) VALUES (@username, @aktivitas, @userId)";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@aktivitas", aktivitas);
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.ExecuteNonQuery();
        }
        private void reset_Click(object sender, EventArgs e)
        {
            Form1 halamanutama = new Form1();
            halamanutama.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
