// Variabel, Tipe Data, dan Operator Sederhana

int umur = 17; // <- Ini adalah bentuk variabel di C#

String // <- Ini adalah Tipe Data yang menyatukan sebuah Variabel.
    nama = "Budi"; // <- Setelah itu diikuti dengan (Nama Variabel) = (Nilai Variabel)

// Ada 5 Variabel yang sering digunakan di C#

// Integer, yaitu angka bulat
int tahun = 2008;

// Double atau Float, yaitu angka desimal
double tinggi = 170.5;

// Char, yaitu satu karakter huruf (Tidak bisa lebih dari satu huruf)
char nilai = 'A'; // beda dengan Sting, Char menggunakan satu petik ('')

// String, yaitu kumpulan dari karakter huruf, angka, symbol, bisa lebih dari beberapa huruf bahkan kalimat
String alamat = "Sidoarjo, Perumahan Bluru Permai";

// Bool (Boolean) yaitu variabel yang terdiri dari dua nilai antara true atau false saja
bool gemarMembaca = true; // True berarti benar
bool sudahMakan = false; // False berarti salah

// Operator Sederhana
// Operasi sederhana untuk menjumlahkan, mengurangi, mengalikan, dserta membagi bilangan, serta menampilkan nya.

// 1. Variabel
int a = 12;
int b = 5;

// Operasi sederhana untuk Menjumlahkan, mengurangi, dan mengali

// Menjumlahkan
// ada dua cara untuk mengoperasikan, yaitu dengan membuat variabel baru atau langsung menulis di dalam WriteLine

// Cara 1 membuat Variabel terlebih dahulu
//int hasilPenjumlahan = a + b;
//Console.WriteLine(hasilPenjumlahan);

// Cara 2 langsung menulis di dalam WriteLine
Console.WriteLine(a + b);

// 2. Mengurangi
// sama seperti penjumlahan, dan kita bisa menggunakan ke dua cara seperti penjumlahan di atas

Console.WriteLine(a - b);

// 3. Mengalikan
// Untuk mengalikan, kita menggunakan symbol asteris (*)

Console.WriteLine(a * b);

// 4. Pembagian
// unruk pembagian dengan hasil decimal, kita juga harus mempunyai variabel dengan tipe data decimal seperti Float atau Double.
// untuk pembagian, kita menggunakan simbol garis miring (/)

Console.WriteLine(a / b);

// hasil akan menjadi angka bulat dan tidak akurat, kita harus mengganti atau membuat variabel dengan tipe data double

double c = 12.0;
double d = 7.0;

Console.WriteLine(c / d);

// Dengan ini kita sudah mempelajari Variabel, Tipe Data, dan juga Operasi Sederhana.