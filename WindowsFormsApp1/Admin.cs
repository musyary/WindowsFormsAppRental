using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BDD25M1\FUNTECH;Initial Catalog=RentalMobil;User ID=sa;Password=kijang12345");
        SqlCommand cmd;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalMobilDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.rentalMobilDataSet.Customer);

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string idbooking = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            string nama = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            string nik = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            string sim = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            string telp = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            string alamat = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
        

            tb_id.Text = idbooking;
            tb_nama.Text = nama;
            tb_nik.Text = nik;
            tb_sim.Text = sim;
            tb_telp.Text = telp;
            tb_alamat.Text = alamat;
       

            tb_id.Enabled = false;
            tb_nama.Enabled = true;
            tb_nik.Enabled = true;
            tb_sim.Enabled = true;
            tb_telp.Enabled = true;
            tb_alamat.Enabled = true;

            add.Visible = true;
         
            done.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMenu adm = new AdminMenu();
            adm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            tb_id.Text = "";
            tb_nama.Text = "";
            tb_nik.Text = "";
            tb_sim.Text = "";
            tb_telp.Text = "";
            tb_alamat.Text = "";

            add.Visible = false;
            tb_id.Enabled = false;
            done.Visible = true;
        }

        private void done_Click(object sender, EventArgs e)
        {
            string nama = tb_nama.Text;
            string nik = tb_nik.Text;
            string sim = tb_sim.Text;
            string telp = tb_telp.Text;
            string alamat = tb_alamat.Text;

            DB data = new DB();
            data.customer(nama, nik, sim, telp, alamat);

            Admin f1 = new Admin();
            f1.Show();
            this.Hide();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Customer where ID_Customer='" + tb_id.Text + "'";

            cmd.ExecuteNonQuery();
            con.Close();
            Admin f1 = new Admin();
            f1.Show();
            this.Hide();
            MessageBox.Show("Data Customer Dihapus");
        }

        private void update_Click(object sender, EventArgs e)
        {
            
                con.Open();
                string str = "update Customer set " +
                    "Nama=@Nama, Nik=@Nik, No_sim=@No_sim, No_telp=@No_telp, Alamat=@Alamat where ID_Customer=@ID_Customer";
                SqlCommand cmd = new SqlCommand(str, con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("ID_Customer", tb_id.Text));
                cmd.Parameters.Add(new SqlParameter("Nama", tb_nama.Text));
                cmd.Parameters.Add(new SqlParameter("Nik", tb_nik.Text));
                cmd.Parameters.Add(new SqlParameter("No_sim", tb_sim.Text));
                cmd.Parameters.Add(new SqlParameter("No_telp", tb_telp.Text));
                cmd.Parameters.Add(new SqlParameter("Alamat", tb_alamat.Text));


                cmd.ExecuteNonQuery();
                Admin f1 = new Admin();
                f1.Show();
                this.Hide();

                con.Close();
           
                MessageBox.Show("Record Updated Successfully");
          
        }
    }
}
