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
    public partial class Form3Dashboard : Form
    {
        public Form3Dashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Close();
            login.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Close();
            login.Show();
        }

        private void Form3Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form4Bandara bandara = new Form4Bandara();
            this.Hide();
            bandara.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4Bandara bandara = new Form4Bandara();
            this.Hide();
            bandara.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form5Maskapai maskapai = new Form5Maskapai();
            this.Hide();
            maskapai.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form5Maskapai maskapai = new Form5Maskapai();
            this.Hide();
            maskapai.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form6Jadwal jadwal = new Form6Jadwal();
            this.Hide();
            jadwal.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form6Jadwal jadwal = new Form6Jadwal();
            this.Hide();
            jadwal.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form7Promo promo = new Form7Promo();
            this.Hide();
            promo.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form7Promo promo = new Form7Promo();
            this.Hide();
            promo.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form8UbahStatus status = new Form8UbahStatus();
            this.Hide();
            status.Show();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            Form8UbahStatus status = new Form8UbahStatus();
            this.Hide();
            status.Show();
        }

        private void label7_Click_1(object sender, EventArgs e)
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
