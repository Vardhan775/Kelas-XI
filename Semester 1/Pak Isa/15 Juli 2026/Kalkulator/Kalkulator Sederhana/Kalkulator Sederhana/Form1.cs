using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_Sederhana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // Mengambil nilai dari textbox dan mengkonversinya menjadi integer
            int angka1 = Convert.ToInt32(txtAngka1.Text);
            int angka2 = Convert.ToInt32(txtAngka2.Text);

            // Lalu melakukan operasi penjumlahan
            int hasil = angka1 + angka2;

            // Setelah itu hasil penjumlahan ditampilkan di label hasil
            lblHasil.Text = "Hasil : " + hasil.ToString();
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(txtAngka1.Text);
            int angka2 = Convert.ToInt32(txtAngka2.Text);
            int hasil = angka1 - angka2;
            lblHasil.Text = "Hasil : " + hasil.ToString();
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(txtAngka1.Text);
            int angka2 = Convert.ToInt32(txtAngka2.Text);
            int hasil = angka1 * angka2;
            lblHasil.Text = "Hasil : " + hasil.ToString();
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(txtAngka1.Text);
            int angka2 = Convert.ToInt32(txtAngka2.Text);
            int hasil = angka1 / angka2;
            lblHasil.Text = "Hasil : " + hasil.ToString();
        }
    }
}
