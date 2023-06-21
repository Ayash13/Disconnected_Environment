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

namespace Disconnected_Environment
{
    public partial class Form3 : Form
    {
        private string stringConnection = "Data Source=DESKTOP-AJFQKR8\\AYASH;Initial Catalog=Mahasiswa;Persist Security Info=True;User ID=sa;Password=Rahasiatau123";
        private SqlConnection connection;
        private string nim;
        private string nama;
        private string alamat;
        private string jenisKelamin;
        private string prodi;
        private DateTime tanggal;
        private BindingSource customerBindingSource;
        public Form3()
        {
            InitializeComponent();
            connection = new SqlConnection(stringConnection);
            customerBindingSource = new BindingSource();
            refreshForm();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mahasiswaDataSet.mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.mahasiswaDataSet.mahasiswa);
            connection.Open();
            string query = "SELECT nim, nama_mahasiswa, jenis_kelamin, alamat, tgl_lahir, id_prodi FROM mahasiswa";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            customerBindingSource.DataSource = dataTable;


            connection.Close();
        }


        private void clearBinding()
        {
            txbx_nim.DataBindings.Clear();
            txbx_nama.DataBindings.Clear();
            txbx_alamat.DataBindings.Clear();
            cmb_jk.DataBindings.Clear();
            cmb_prodi.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
        }

        private void refreshForm()
        {
            clearBinding();
            txbx_nim.Text = "";
            txbx_nama.Text = "";
            txbx_alamat.Text = "";
            cmb_jk.SelectedItem = null;
            cmb_prodi.Enabled = false;
            cmb_prodi.SelectedItem = null;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void Prodicbx()
        {
            connection.Open();
            string str = "SELECT id_prodi, nama_prodi FROM dbo.prodi";
            SqlCommand cmd = new SqlCommand(str, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();

            cmb_prodi.DisplayMember = "nama_prodi";
            cmb_prodi.ValueMember = "id_prodi";
            cmb_prodi.DataSource = dt;
        }

        private void txbx_nim_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbx_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_jk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbx_alamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_prodi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Enabled = true;
            }
            dateTimePicker1.Value = DateTime.Now;
            cmb_prodi.Enabled = true;
            Prodicbx();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            nim = txbx_nim.Text.Trim();
            nama = txbx_nama.Text.Trim();
            alamat = txbx_alamat.Text.Trim();
            jenisKelamin = cmb_jk.SelectedItem.ToString();
            prodi = cmb_prodi.SelectedValue.ToString();
            tanggal = dateTimePicker1.Value;

            if (string.IsNullOrEmpty(nim) || string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(alamat) || string.IsNullOrEmpty(jenisKelamin) || string.IsNullOrEmpty(prodi))
            {
                MessageBox.Show("Please fill in all identity fields!");
            }
            else
            {
                connection.Open();
                string query = "INSERT INTO mahasiswa (nim, nama_mahasiswa, alamat, jenis_kelamin, id_prodi, tgl_lahir) VALUES (@nim, @nama_mahasiswa, @alamat, @jenis_kelamin, @id_prodi, @tgl_lahir)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nim", nim);
                command.Parameters.AddWithValue("@nama_mahasiswa", nama);
                command.Parameters.AddWithValue("@alamat", alamat);
                command.Parameters.AddWithValue("@jenis_kelamin", jenisKelamin);
                command.Parameters.AddWithValue("@id_prodi", prodi);
                command.Parameters.AddWithValue("@tgl_lahir", tanggal);
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Data has been saved to the database.");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
