using System;

namespace AplikasiTerpadu
{
    // 1. KELAS KALKULATOR
    public class Calculator
    {
        public double Tambah(double a, double b) => a + b;
        public double Kurang(double a, double b) => a - b;
        public double Kali(double a, double b) => a * b;
        public double Bagi(double a, double b) => b == 0 ? 0 : a / b;

        public void JalankanMenu()
        {
            Console.WriteLine("--- MENU KALKULATOR ---");
            Console.Write("Masukkan angka pertama : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan angka kedua   : ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nHasil Penjumlahan : {Tambah(a, b)}");
            Console.WriteLine($"Hasil Pengurangan : {Kurang(a, b)}");
            Console.WriteLine($"Hasil Perkalian   : {Kali(a, b)}");
            Console.WriteLine($"Hasil Pembagian   : {(b == 0 ? "Error (Pembagi 0)" : Bagi(a, b).ToString())}");
        }
    }

    // 2. KELAS BANGUN DATAR (Mempunyai Menu Sendiri)
    public class BangunDatar
    {
        public double LuasPersegi(double s) => s * s;
        public double LuasPersegiPanjang(double p, double l) => p * l;
        public double LuasLingkaran(double r) => Math.PI * r * r;
        public double LuasSegitiga(double a, double t) => 0.5 * a * t;

        public void JalankanMenu()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("      MENU BANGUN DATAR          ");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Hitung Luas Persegi");
            Console.WriteLine("2. Hitung Luas Persegi Panjang");
            Console.WriteLine("3. Hitung Luas Lingkaran");
            Console.WriteLine("4. Hitung Luas Segitiga");
            Console.WriteLine("=================================");
            Console.Write("Pilih opsi (1-4): ");

            string pilihan = Console.ReadLine();
            Console.WriteLine();

            switch (pilihan)
            {
                case "1":
                    Console.Write("Masukkan sisi: ");
                    double s = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Luas Persegi: {LuasPersegi(s)}");
                    break;

                case "2":
                    Console.Write("Masukkan panjang: ");
                    double p = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan lebar: ");
                    double l = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Luas Persegi Panjang: {LuasPersegiPanjang(p, l)}");
                    break;

                case "3":
                    Console.Write("Masukkan jari-jari: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Luas Lingkaran: {LuasLingkaran(r):F2}");
                    break;

                case "4":
                    Console.Write("Masukkan alas: ");
                    double alas = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan tinggi: ");
                    double tinggi = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Luas Segitiga: {LuasSegitiga(alas, tinggi)}");
                    break;

                default:
                    Console.WriteLine("Pilihan tidak valid!");
                    break;
            }
        }
    }

    // 3. KELAS BANGUN RUANG (Mempunyai Menu Sendiri)
    public class BangunRuang
    {
        public double VolumeKubus(double s) => Math.Pow(s, 3);
        public double VolumeBalok(double p, double l, double t) => p * l * t;
        public double VolumeTabung(double r, double t) => Math.PI * Math.Pow(r, 2) * t;
        public double VolumeBola(double r) => (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);

        public void JalankanMenu()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("      MENU BANGUN RUANG          ");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Hitung Volume Kubus");
            Console.WriteLine("2. Hitung Volume Balok");
            Console.WriteLine("3. Hitung Volume Tabung");
            Console.WriteLine("4. Hitung Volume Bola");
            Console.WriteLine("=================================");
            Console.Write("Pilih opsi (1-4): ");

            string pilihan = Console.ReadLine();
            Console.WriteLine();

            switch (pilihan)
            {
                case "1":
                    Console.Write("Masukkan sisi kubus: ");
                    double sk = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Volume Kubus: {VolumeKubus(sk)}");
                    break;

                case "2":
                    Console.Write("Masukkan panjang: ");
                    double p = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan lebar: ");
                    double l = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan tinggi: ");
                    double t = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Volume Balok: {VolumeBalok(p, l, t)}");
                    break;

                case "3":
                    Console.Write("Masukkan jari-jari tabung: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan tinggi tabung: ");
                    double tt = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Volume Tabung: {VolumeTabung(r, tt):F2}");
                    break;

                case "4":
                    Console.Write("Masukkan jari-jari bola: ");
                    double rb = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Volume Bola: {VolumeBola(rb):F2}");
                    break;

                default:
                    Console.WriteLine("Pilihan tidak valid!");
                    break;
            }
        }
    }

    // 4. KELAS ZODIAK
    public class Zodiak
    {
        public string TentukanZodiak(int tanggal, int bulan)
        {
            if ((bulan == 3 && tanggal >= 21) || (bulan == 4 && tanggal <= 19)) return "Aries";
            if ((bulan == 4 && tanggal >= 20) || (bulan == 5 && tanggal <= 20)) return "Taurus";
            if ((bulan == 5 && tanggal >= 21) || (bulan == 6 && tanggal <= 20)) return "Gemini";
            if ((bulan == 6 && tanggal >= 21) || (bulan == 7 && tanggal <= 22)) return "Cancer";
            if ((bulan == 7 && tanggal >= 23) || (bulan == 8 && tanggal <= 22)) return "Leo";
            if ((bulan == 8 && tanggal >= 23) || (bulan == 9 && tanggal <= 22)) return "Virgo";
            if ((bulan == 9 && tanggal >= 23) || (bulan == 10 && tanggal <= 22)) return "Libra";
            if ((bulan == 10 && tanggal >= 23) || (bulan == 11 && tanggal <= 21)) return "Scorpio";
            if ((bulan == 11 && tanggal >= 22) || (bulan == 12 && tanggal <= 21)) return "Sagitarius";
            if ((bulan == 12 && tanggal >= 22) || (bulan == 1 && tanggal <= 19)) return "Capricorn";
            if ((bulan == 1 && tanggal >= 20) || (bulan == 2 && tanggal <= 18)) return "Aquarius";
            if ((bulan == 2 && tanggal >= 19) || (bulan == 3 && tanggal <= 20)) return "Pisces";

            return "Tanggal atau bulan tidak valid!";
        }

        public void JalankanMenu()
        {
            Console.WriteLine("--- MENU CEK ZODIAK ---");
            Console.Write("Masukkan Tanggal Lahir (1-31): ");
            int tgl = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Bulan Lahir (1-12)  : ");
            int bln = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nZodiak Anda adalah: {TentukanZodiak(tgl, bln)}");
        }
    }

    // 5. KELAS UTAMA MENU
    public class Menu
    {
        public static void Main(string[] args)
        {
            // Instansiasi objek
            Calculator kalkulator = new Calculator();
            BangunDatar bangunDatar = new BangunDatar();
            BangunRuang bangunRuang = new BangunRuang();
            Zodiak zodiak = new Zodiak();

            bool berjalan = true;

            while (berjalan)
            {
                Console.Clear();
                Console.WriteLine("PILIHAN MENU UTAMA");
                Console.WriteLine("");
                Console.WriteLine("1. Kalkulator");
                Console.WriteLine("2. Bangun Datar");
                Console.WriteLine("3. Bangun Ruang");
                Console.WriteLine("4. Cek Zodiak");
                Console.WriteLine("5. Keluar");
                Console.WriteLine("");
                Console.Write("Pilih menu (1-5): ");

                string pilihan = Console.ReadLine();
                Console.Clear();

                switch (pilihan)
                {
                    case "1":
                        kalkulator.JalankanMenu();
                        break;
                    case "2":
                        bangunDatar.JalankanMenu();
                        break;
                    case "3":
                        bangunRuang.JalankanMenu();
                        break;
                    case "4":
                        zodiak.JalankanMenu();
                        break;
                    case "5":
                        berjalan = false;
                        Console.WriteLine("Terima kasih telah menggunakan program!");
                        continue;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        break;
                }

                Console.WriteLine("\nTekan sembarang tombol untuk kembali ke menu utama...");
                Console.ReadKey();
            }
        }
    }
}