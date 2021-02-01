using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Sewa : Form
    {
        public Sewa()
        {
            InitializeComponent();
        }

        private void Sewa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalMobilDataSet4.Kendaraan' table. You can move, or remove it, as needed.
            this.kendaraanTableAdapter.Fill(this.rentalMobilDataSet4.Kendaraan);
            // TODO: This line of code loads data into the 'rentalMobilDataSet3.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.rentalMobilDataSet3.Customer);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string harga = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);

            tb_harga.Text = harga;
            tb_harga.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double LamaSewa, HargaSewa, JumlahBayar;

            //LamaSewa = double.Parse(this.tb_hari.Text);

            //HargaSewa = double.Parse(this.tb_harga.Text);

            //JumlahBayar = double.Parse(this.tb_total.Text);

            //JumlahBayar = LamaSewa * HargaSewa;

            //this.tb_total.Text = JumlahBayar.ToString("N");

            int a, b, c;
            a = Convert.ToInt32(tb_harga.Text);
            b = Convert.ToInt32(tb_hari.Text);
            c = a * b;
            tb_total.Text = c.ToString();
        }

        private void next_Click(object sender, EventArgs e)
        {
            string cust = tbcust.Text;
            string mobs = tbmobs.Text;
            string date = dateTimePicker1.Text;
            string total = tb_total.Text;
            string hari = tb_hari.Text;

            DB data = new DB();
            data.transaksi(cust, mobs, date, total, hari);
            Transaksi f1 = new Transaksi();
            f1.Show();
            this.Hide();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            AdminMenu f1 = new AdminMenu();
            f1.Show();
            this.Hide();
        }
    }
}
