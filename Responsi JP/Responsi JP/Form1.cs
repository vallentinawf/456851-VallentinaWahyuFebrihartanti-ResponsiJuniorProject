using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace Responsi_JP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432; Username=postgres; Password=Informatika;Database=DBVallen";
        //public static NpgsqlConnection conn = new NpgsqlConnection(connectionString = connstring);
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from karyawanInsert(:_id_karyawan,:_nama)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", tbId.Text);
                cmd.Parameters.AddWithValue("_nama", tbKaryawan.Text);
                if ((int) cmd.ExecuteScalar == 1)
                {
                    MessageBox.Show("Data Karyawan berhasil diinputkan", "Great!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    tbKaryawan.Text = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Insert Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvHR.DataSource = null;
                sql = "select * from karyawanSelect()";
                cmd = new NpgsqlCommand(sql,conn);
                dt= new DataTable();
                NpgsqlDataReader rd =  cmd.ExecuteReader();
                dt.Load(rd);
                dgvHR.DataSource = dt;
                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r = null)
            {
                MessageBox.Show("Mohon memilih data yang ingin dihapus");
                return;
            }
            if (MessageBox.Show("Apakah benar anda ingin menghapus data" + r.Cells["_nama"].Value.ToString() + "?", "Hapus Data Terkonfirmasi", MessageBoxButton.YesNo));
        }
    }
}