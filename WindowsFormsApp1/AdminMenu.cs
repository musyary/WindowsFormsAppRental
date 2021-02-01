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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            adm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult d = MessageBox.Show("Apakah anda ingin Logout? ", "Confirm Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Form1 ldm = new Form1();
                ldm.Show();
                this.Hide();

            }
            else if (d == DialogResult.No) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kendaraan ldm = new Kendaraan();
            ldm.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transaksi ldm = new Transaksi();
            ldm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sewa ldm = new Sewa();
            ldm.Show();
            this.Hide();
        }
    }
}
