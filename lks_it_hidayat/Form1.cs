using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lks_it_hidayat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kalimat1_about.Visible = false;
            kelimat2_about.Visible = false;
            guna2Button1.Visible = false;
            back_about.Visible = false;
            back_about.Visible = false;
            data_home.Visible = false;
            tersedia.Visible = false;
            home.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lKSITSOFWAREDataSet7.tb_barang' table. You can move, or remove it, as needed.
            this.tb_barangTableAdapter1.Fill(this.lKSITSOFWAREDataSet7.tb_barang);
            // TODO: This line of code loads data into the 'lKSITSOFWAREDataSet6.tb_barang' table. You can move, or remove it, as needed.
            this.tb_barangTableAdapter.Fill(this.lKSITSOFWAREDataSet6.tb_barang);
        }

        private void login_Click(object sender, EventArgs e)
        {
            Form_Login HalamanLogin = new Form_Login();
            HalamanLogin.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            kalimat1.Visible = false;
            kalimat2.Visible = false;
            login.Visible = false;
            about.Visible = false;
            kalimat1_about.Visible = true;
            kelimat2_about.Visible = true;
            guna2Button1.Visible = true;
            back_about.Visible = true;
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void kalimat1_Click(object sender, EventArgs e)
        {

        }

        private void back_about_Click(object sender, EventArgs e)
        {
            kalimat1_about.Visible = false;
            kelimat2_about.Visible = false;
            guna2Button1.Visible = false;
            back_about.Visible = false;
            kalimat1.Visible = true;
            kalimat2.Visible = true;
            login.Visible = true;
            about.Visible = true;
        }

        private void kalimat1_about_Click(object sender, EventArgs e)
        {

        }

        private void kelimat2_about_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            kalimat1.Visible = false;
            kalimat2.Visible = false;
            login.Visible = false;
            about.Visible = false;
            kalimat1_about.Visible = false;
            kelimat2_about.Visible = false;
            guna2Button1.Visible = false;
            back_about.Visible = false;
            guna2Button1.Visible = false;
            back_about.Visible = true;
            data_home.Visible = true;
            tersedia.Visible = true;
            home.Visible = true;
        }

        private void home_Click(object sender, EventArgs e)
        {
            kalimat1_about.Visible = false;
            kelimat2_about.Visible = false;
            guna2Button1.Visible = false;
            back_about.Visible = false;
            data_home.Visible = false;
            tersedia.Visible = false;
            home.Visible = false;
            kalimat1.Visible = true;
            kalimat2.Visible = true;
            login.Visible = true;
            about.Visible = true;

        }

        private void data_home_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void tersedia_Click(object sender, EventArgs e)
        {

        }
    }
}
