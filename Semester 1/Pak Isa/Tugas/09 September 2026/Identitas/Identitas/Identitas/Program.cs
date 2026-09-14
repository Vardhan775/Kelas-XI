using System;

namespace AplikasiDataSiswa
{
    class Program
    {
        static void Main(string[] args)
        {
            bool berjalan = true;

            while (berjalan)
            {
                Console.Clear();
                Console.WriteLine("Identitas diri");
                Console.WriteLine("1. Lihat Identitas");
                Console.WriteLine("2. Lihat Mata Pelajaran");
                Console.WriteLine("3. Lihat Absensi");
                Console.WriteLine("4. Lihat Nilai");
                Console.WriteLine("5. Keluar");
                Console.Write("Pilih menu (1-5): ");

                string pilihan = Console.ReadLine();
                Console.Clear();

                switch (pilihan)
                {
                    case "1":
                        MenuIdentitas();
                        break;
                    case "2":
                        MataPelajaran.NonProduktif();
                        Console.WriteLine();
                        MataPelajaran.Produktif();
                        break;
                    case "3":
                        MenuAbsensi();
                        break;
                    case "4":
                        MataPelajaran.NilaiMataPelajaran.MapelNonProduktif();
                        Console.WriteLine();
                        MataPelajaran.NilaiMataPelajaran.MapelProduktif();
                        break;
                    case "5":
                        berjalan = false;
                        Console.WriteLine("Terima kasih telah menggunakan aplikasi ini.");
                        continue;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        break;
                }

                Console.WriteLine("\nTekan Enter untuk Kembali ke Menu Utama...");
                Console.ReadKey();
            }
        }

        static void MenuIdentitas()
        {
            Identitas.Siswa();
            Identitas.TanggalLahir();
            Identitas.Alamat();
            Identitas.AsalSekolah();
            Identitas.Wali();
        }

        static void MenuAbsensi()
        {
            MataPelajaran.Absensi.Januari();
            Console.WriteLine();
            MataPelajaran.Absensi.Februari();
            Console.WriteLine();
            MataPelajaran.Absensi.Maret();
            Console.WriteLine();
            MataPelajaran.Absensi.April();
            Console.WriteLine();
            MataPelajaran.Absensi.Mei();
            Console.WriteLine();
            MataPelajaran.Absensi.Juni();
            Console.WriteLine();
            MataPelajaran.Absensi.Juli();
        }
    }

    class Identitas
    {
        public static void Siswa()
        {
            Console.WriteLine("IDENTITAS");
            Console.WriteLine("Nama    : Aditya Vardhan Irwansyah");
            Console.WriteLine("NIS     : 0093036859");
            Console.WriteLine("Kelas   : 11 RPL");
        }
        public static void TanggalLahir()
        {
            Console.WriteLine("Tempat dan Tanggal lahir : Sidoarjo, 30 Desember 2009");
        }
        public static void Alamat()
        {
            Console.WriteLine("Alamat  : Bluru Permain, Jalan Ikan Lele No.3 RT 07 RW 11, Blok CK - 11");
        }
        public static void AsalSekolah()
        {
            Console.WriteLine("TK  : Da'watul Hasana");
            Console.WriteLine("SD  : SD Pucang Negeri 2 Sidoarjo");
            Console.WriteLine("SMP : SMP Negeri 6 Sidoarjo");
        }
        public static void Wali()
        {
            Console.WriteLine("Nama Wali     : Iwan");
            Console.WriteLine("Pekerjaan     : Perbankan");
            Console.WriteLine("No. Handphone : 081234567890");
        }
    }

    class MataPelajaran
    {
        public static void NonProduktif()
        {
            Console.WriteLine("MATA PELAJARAN NONPRODUKTIF:");
            Console.WriteLine("B. Jepang");
            Console.WriteLine("B. Inggris");
            Console.WriteLine("B. Jerman");
            Console.WriteLine("B. Jawa");
            Console.WriteLine("B. Indonesia");
            Console.WriteLine("Pjok");
            Console.WriteLine("Matematika");
            Console.WriteLine("PKWU / KIK");
            Console.WriteLine("Sejarah");
            Console.WriteLine("Pancasila");
        }
        public static void Produktif()
        {
            Console.WriteLine("MATA PELAJARAN PRODUKTIF:");
            Console.WriteLine("PPLG");
        }

        // Ditambahkan akses modifier 'public' agar bisa dipanggil dari luar class
        public class Absensi
        {
            public static void Januari()
            {
                Console.WriteLine("JANUARI :");
                Console.WriteLine("Masuk : 21");
                Console.WriteLine("Izin  : 1");
                Console.WriteLine("Sakit : 0");
                Console.WriteLine("Alpha : 0");
            }
            public static void Februari()
            {
                Console.WriteLine("FEBRUARI :");
                Console.WriteLine("Masuk : 18");
                Console.WriteLine("Izin  : 0");
                Console.WriteLine("Sakit : 2");
                Console.WriteLine("Alpha : 0");
            }
            public static void Maret()
            {
                Console.WriteLine("MARET :");
                Console.WriteLine("Masuk : 20");
                Console.WriteLine("Izin  : 0");
                Console.WriteLine("Sakit : 1");
                Console.WriteLine("Alpha : 0");
            }
            public static void April()
            {
                Console.WriteLine("APRIL :");
                Console.WriteLine("Masuk : 21");
                Console.WriteLine("Izin  : 0");
                Console.WriteLine("Sakit : 1");
                Console.WriteLine("Alpha : 0");
            }
            public static void Mei()
            {
                Console.WriteLine("MEI :");
                Console.WriteLine("Masuk : 21");
                Console.WriteLine("Izin  : 0");
                Console.WriteLine("Sakit : 0");
                Console.WriteLine("Alpha : 0");
            }
            public static void Juni()
            {
                Console.WriteLine("JUNI :");
                Console.WriteLine("Masuk : 22");
                Console.WriteLine("Izin  : 0");
                Console.WriteLine("Sakit : 0");
                Console.WriteLine("Alpha : 0");
            }
            public static void Juli()
            {
                Console.WriteLine("JULI :");
                Console.WriteLine("Masuk : 22");
                Console.WriteLine("Izin  : 0");
                Console.WriteLine("Sakit : 1");
                Console.WriteLine("Alpha : 0");
            }
        }

        // Ditambahkan akses modifier 'public'
        public class NilaiMataPelajaran
        {
            public static void MapelNonProduktif()
            {
                Console.WriteLine("MAPEL NONPRODUKTIF :");
                Console.WriteLine("B. Jepang    : 90");
                Console.WriteLine("B. Inggris   : 95");
                Console.WriteLine("B. Jerman    : 91");
                Console.WriteLine("B. Jawa      : 89");
                Console.WriteLine("B. Indonesia : 92");
                Console.WriteLine("Matematika   : 94");
                Console.WriteLine("PKWU / KIK   : 93");
                Console.WriteLine("Sejarah      : 88");
                Console.WriteLine("Pancasila    : 88");
                Console.WriteLine("Pjok         : 90");
            }
            public static void MapelProduktif()
            {
                Console.WriteLine("MAPEL PRODUKTIF :");
                Console.WriteLine("PPLG         : 100");
            }
        }
    }
}