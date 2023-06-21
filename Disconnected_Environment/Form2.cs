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
    public partial class Form2 : Form
    {
        string connectionString = "Data Source=DESKTOP-AJFQKR8\\AYASH;Initial Catalog=Mahasiswa;Persist Security Info=True;User ID=sa;Password=Rahasiatau123";
        SqlConnection connection;
        public Form2()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            RefreshForm();
        }

        private void RefreshForm()
        {
            // Reset form components to initial state
            textBox1.Text = "";
            textBox2.Text = "";
            btn_save.Enabled = false;
            btn_clear.Enabled = false;
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
            btn_clear.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string newProdi = textBox1.Text.Trim();
            string newProdiId = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(newProdi))
            {
                MessageBox.Show("Masukkan Nama Prodi");
            } 
            else if (string.IsNullOrEmpty(newProdiId))
            {
                MessageBox.Show("Masukkan ID Prodi");
            }
            else
            {
                connection.Open();
                string query = "INSERT INTO prodi (id_prodi, nama_prodi) VALUES (@id_prodi, @nama_prodi)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_prodi", newProdiId);
                cmd.Parameters.AddWithValue("@nama_prodi", newProdi);
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Data berhasil disimpan");
                dataGridView();
                RefreshForm();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }
        private void dataGridView()
        {
            connection.Open();
            string query = "SELECT id_prodi, nama_prodi FROM prodi";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }   
}
