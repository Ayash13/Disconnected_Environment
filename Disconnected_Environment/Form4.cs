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
    public partial class Form4 : Form
    {
        private string stringConnection = "Data Source=DESKTOP-AJFQKR8\\AYASH;Initial Catalog=Mahasiswa;Persist Security Info=True;User ID=sa;Password=Rahasiatau123";
        private SqlConnection connection;
        public Form4()
        {
            InitializeComponent();
            connection = new SqlConnection(stringConnection);
            refreshForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmb_nama_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedNama = cmb_nama.SelectedItem.ToString();

            connection.Open();
            string query = "SELECT nim FROM mahasiswa WHERE nama_mahasiswa = @nama_mahasiswa";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@nama_mahasiswa", selectedNama);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string nim = reader.GetString(0);
                txbx_nim.Text = nim;
            }
            else
            {
                txbx_nim.Text = "";
            }
            reader.Close();
            connection.Close();
        }

        private void cmb_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_tahun_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            cmb_nama.Enabled = true;
            cmb_status.Enabled = true;
            cmb_tahun.Enabled = true;
            cbTahunMasuk();
            cbNama();
            btn_add.Enabled = false;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string nim = txbx_nim.Text;
            string statusMahasiswa = cmb_status.SelectedItem.ToString();
            string tahunMasuk = cmb_tahun.SelectedItem.ToString();

            int count = 0;
            string tempKodeStatus = "";
            string kodeStatus = "";

            connection.Open();
            string query = "SELECT COUNT(*) FROM status_mahasiswa";
            SqlCommand command = new SqlCommand(query, connection);
            count = (int)command.ExecuteScalar();

            if (count == 0)
            {
                kodeStatus = "1";
            }
            else
            {
                query = "SELECT TOP 1 id_status FROM status_mahasiswa ORDER BY id_status DESC";
                command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    tempKodeStatus = reader.GetString(0);
                }
                reader.Close();

                int tempKode = int.Parse(tempKodeStatus);
                tempKode++;
                kodeStatus = tempKode.ToString();
            }

            query = "INSERT INTO status_mahasiswa (id_status, nim, status_mahasiswa, tahun_masuk) VALUES (@id_status, @nim, @status_mahasiswa, @tahun_masuk)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id_status", kodeStatus);
            command.Parameters.AddWithValue("@nim", nim);
            command.Parameters.AddWithValue("@status_mahasiswa", statusMahasiswa);
            command.Parameters.AddWithValue("@tahun_masuk", tahunMasuk);
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Data Berhasil Disimpan");

            refreshForm();
            dataGridView();
        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void refreshForm()
        {
            cmb_nama.Enabled = false;
            cmb_status.Enabled = false;
            cmb_tahun.Enabled = false;
            btn_add.Enabled = true;

            cmb_nama.Items.Clear(); // Clear the ComboBox items
            cmb_nama.SelectedIndex = -1;
            cmb_status.SelectedIndex = -1;
            cmb_tahun.SelectedIndex = -1;
            txbx_nim.Clear(); // Clear the TextBox value

            cbNama(); // Populate the cmb_nama ComboBox again
        }
        private void dataGridView()
        {
            connection.Open();
            string query = "SELECT * FROM status_mahasiswa";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void cbNama()
        {
            connection.Open();
            string query = "SELECT nama_mahasiswa FROM mahasiswa";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmb_nama.Items.Add(reader.GetString(0));
            }
            reader.Close();
            connection.Close();
        }

        private void cbTahunMasuk()
        {
            int currentYear = DateTime.Now.Year;
            for (int i = 2010; i <= currentYear; i++)
            {
                cmb_tahun.Items.Add(i.ToString());
            }
        }

        private void txbx_nim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
