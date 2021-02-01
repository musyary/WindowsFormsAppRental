using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BDD25M1\FUNTECH;Initial Catalog=RentalMobil;Integrated Security=True");

        public void signup(string username, string password)
        {
            con.Open();
            string str = "INSERT INTO Admin VALUES(@Nama_admin, @Pass)";
            SqlCommand cmd = new SqlCommand(str, con);

            cmd.CommandType = CommandType.Text;
          
            cmd.Parameters.Add(new SqlParameter("Nama_admin", username));
            cmd.Parameters.Add(new SqlParameter("Pass", password));

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public string login(string usnm, string pw)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Admin WHERE Nama_admin='" + usnm + "' and Pass='" + pw + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                return ("valid");
            }
            else
            {
                return ("invalid");
            }
        }

        public void kendaraan(string naker, string nopol, string harga)
        {
            con.Open();
            string str = "INSERT INTO Kendaraan VALUES(@Nama_Kendaraan, @Nopol, @Harga_sewa)";
            SqlCommand cmd = new SqlCommand(str, con);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("Nama_Kendaraan", naker));
            cmd.Parameters.Add(new SqlParameter("Nopol", nopol));
            cmd.Parameters.Add(new SqlParameter("Harga_sewa", harga));

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void customer(string nama, string nik, string sim, string telp, string alamat)
        {
            con.Open();
            string str = "INSERT INTO Customer VALUES(@Nama, @Nik, @No_sim, @No_telp, @Alamat)";
            SqlCommand cmd = new SqlCommand(str, con);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("Nama", nama));
            cmd.Parameters.Add(new SqlParameter("Nik", nik));
            cmd.Parameters.Add(new SqlParameter("No_sim", sim));
            cmd.Parameters.Add(new SqlParameter("No_telp", telp));
            cmd.Parameters.Add(new SqlParameter("Alamat", alamat));

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void transaksi(string cust, string mobs, string date, string total, string hari)
        {
            con.Open();
            string str = "INSERT INTO Transaksi VALUES(@Nama, @Nama_Kendaraan, @tgl_sewa, @Sub_total, @hari)";
            
            SqlCommand cmd = new SqlCommand(str, con);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("Nama", cust));
            cmd.Parameters.Add(new SqlParameter("Nama_Kendaraan", mobs));
            cmd.Parameters.Add(new SqlParameter("tgl_sewa", date));
            cmd.Parameters.Add(new SqlParameter("Sub_total", total));
            cmd.Parameters.Add(new SqlParameter("hari", hari));

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
