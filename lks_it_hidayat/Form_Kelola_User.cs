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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace lks_it_hidayat
{
    public partial class Form_Kelola_User : Form
    {
        private SqlConnection koneksi;
        public Form_Kelola_User()
        {
            InitializeComponent();
            koneksi = new SqlConnection("Data Source=HIDAYATULLAH;Initial Catalog=LKSITSOFWARE;Integrated Security=True;");
        }
}
}
