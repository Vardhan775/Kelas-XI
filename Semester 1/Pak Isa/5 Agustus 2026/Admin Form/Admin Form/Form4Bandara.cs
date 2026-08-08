using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Form
{
    public partial class Form4Bandara : Form
    {
        public Form4Bandara()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3Dashboard dashboard = new Form3Dashboard();
            this.Close();
            dashboard.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3Dashboard dashboard = new Form3Dashboard();
            this.Close();
            dashboard.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form5Maskapai maskapai = new Form5Maskapai();
            this.Close();
            maskapai.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form5Maskapai maskapai = new Form5Maskapai();
            this.Close();
            maskapai.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form6Jadwal jadwal = new Form6Jadwal();
            this.Close();
            jadwal.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form6Jadwal jadwal = new Form6Jadwal();
            this.Close();
            jadwal.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form7Promo promo = new Form7Promo();
            this.Close();
            promo.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form7Promo promo = new Form7Promo();
            this.Close();
            promo.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form8UbahStatus status = new Form8UbahStatus();
            this.Close();
            status.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form8UbahStatus status = new Form8UbahStatus();
            this.Close();
            status.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Close();
            login.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Close();
            login.Show();
        }
    }
}
