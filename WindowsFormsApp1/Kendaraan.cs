using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Kendaraan : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BDD25M1\FUNTECH;Initial Catalog=RentalMobil;Integrated Security=True");
        SqlCommand cmd;


        public Kendaraan()
        {
            InitializeComponent();
        }

        private void Kendaraan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalMobilDataSet1.Kendaraan' table. You can move, or remove it, as needed.
            this.kendaraanTableAdapter.Fill(this.rentalMobilDataSet1.Kendaraan);
            // TODO: This line of code loads data into the 'rentalMobilDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.rentalMobilDataSet.Customer);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
     
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            string namakendaraan = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            string nopol = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            string harga = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);



            tb_id.Text = id;
            tb_namaker.Text = namakendaraan;
            tb_nopol.Text = nopol;
            tb_harga.Text = harga;

            tb_id.Enabled = false;
            tb_namaker.Enabled = true;
            tb_nopol.Enabled = true;
            tb_harga.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMenu adm = new AdminMenu();
            adm.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            tb_id.Text = "";
            tb_namaker.Text = "";
            tb_nopol.Text = "";
            tb_harga.Text = "";

            add.Enabled = false;
            tb_id.Enabled = false;
            done.Visible = true;
        
        }

        private void done_Click(object sender, EventArgs e)
        {
            string namakendaraan = tb_namaker.Text;
            string nopol = tb_nopol.Text;
            string harga = tb_harga.Text;
           

           

            DB data = new DB();
            data.kendaraan(namakendaraan, nopol, harga);

            Kendaraan f1 = new Kendaraan();
            f1.Show();
            this.Hide();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Kendaraan where ID_Mobil='" + tb_id.Text + "'";

            cmd.ExecuteNonQuery();
            con.Close();
            Kendaraan f1 = new Kendaraan();
            f1.Show();
            this.Hide();
            MessageBox.Show("Data Kendaraan Dihapus");
        }

        private void edit_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "update Kendaraan set " +
                "Nama_Kendaraan=@Nama_Kendaraan, Nopol=@Nopol, Harga_sewa=@Harga_sewa where ID_Mobil=@ID_Mobil";
            SqlCommand cmd = new SqlCommand(str, con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("ID_Mobil", tb_id.Text));
            cmd.Parameters.Add(new SqlParameter("Nama_Kendaraan", tb_namaker.Text));
            cmd.Parameters.Add(new SqlParameter("Nopol", tb_nopol.Text));
            cmd.Parameters.Add(new SqlParameter("Harga_sewa", tb_harga.Text));
          


            cmd.ExecuteNonQuery();
            Kendaraan f1 = new Kendaraan();
            f1.Show();
            this.Hide();

            con.Close();

            MessageBox.Show("Record Updated Successfully");
        }
    }
}
