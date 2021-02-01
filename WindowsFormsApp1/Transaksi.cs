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
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalMobilDataSet8.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter1.Fill(this.rentalMobilDataSet8.Transaksi);
            // TODO: This line of code loads data into the 'rentalMobilDataSet2.Transaksi' table. You can move, or remove it, as needed.
            //this.transaksiTableAdapter.Fill(this.rentalMobilDataSet2.Transaksi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMenu f1 = new AdminMenu();
            f1.Show();
            this.Hide();
        }
    }
}
