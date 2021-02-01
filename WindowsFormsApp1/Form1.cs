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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string us = username.Text;
            string ps = password.Text;
            DB db = new DB();
            string hasilvalidasi = db.login(us, ps);
            if (hasilvalidasi == "valid")
            {
                AdminMenu adm = new AdminMenu();
                adm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah.\n" +
                    "\nPastikan Username dan Password yang anda ketikkan sudah benar!", "Login Error! " + hasilvalidasi, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                username.Clear();
                password.Clear();
            }

          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register f1 = new Register();
            f1.Show();
            this.Hide();
        }

        private void Customer_Click(object sender, EventArgs e)
        {

        }
    }
}
