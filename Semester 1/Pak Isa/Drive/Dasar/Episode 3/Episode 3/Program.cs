// Variabel, Tipe Data, dan Operator Sederhana

int umur = 17;  // <- ini adalah bentuk variabel di c#

String // <- ini adalah Tipe data yang menentukan sebuah variabel
    nama = "Budi"; // <-setelah itu diikuti dengan nama variabel = nilai variabel

// VARIABEL dan TIPE DATA
// Ada 5 variabel yang biasanya digunakan di c#

// Integer, yaitu angka bulat
int tahun = 2008;

//Double atau float , yaitu angka desimal
double tinggiBadan = 1.75;

// Char, yaitu satu karakter huruf (Tidak bisa lebih dari satu huruf)
char nilai = 'A'; //beda dengan string, char menggunakan satu petik ('')

// String, yaitu kumpulan dari karakter huruf, angka, symbol, bisa lebih dari beberapa huruf bahkan kalimat
String namaLengkap = "Budi Santoso";
String alamat = "Sidoarjo, Jawa Timur";

// Bool (Boolean) yaitu variabel yang terdiri dari dua nilai antara true atau false
bool gemarMembaca = true; // true berarti benar
bool sudahMakan = false; // false berarti salah

// Operator Sederhana
// Operasi sederhana unruk menjumlahkan, mengurangi, serta membagi bilangan, serta menampilkan nya.

// Variabel
int a = 12;
int b = 5;

// Operasi sederhana untuk menjumlahkan, mengurangi, dan mengali

// 1. Menjumlahkan
// Ada dua cara untuk mengoperasikan, yaitu dengan membuat variabel baru atau langsung menulis di dalam Writeline

// Cara 1 membuat Variabel terlebih dahulu
int hasilPenjumlahan = a + b;
Console.WriteLine(hasilPenjumlahan);

// Hasilnya akan keluar di dalam Console CMD

// Cara 2 langsung menulis di dalam Writeline
Console.WriteLine(a + b);

// Hasilnya akan sama saja


// 2. Mengurangi
// Sama seperti di atas, kita menggunakan kedua cara tersebut

Console.WriteLine(a - b);


// 3. Mengali
// Untuk mengalikan, kita  menggunakan symbol asteris (*)

Console.WriteLine(a * b);

// 4. Pembagian
// Untuk pembagian dengan hasil decimal, kita juga harus mempunyai variabel dengan tipe data decimal, seperti double atau float
// Untuk pembagian, kita menggunakan symbol garis miring (/)

Console.WriteLine(a / b);

// hasil akan menjadi angka bulat dan tidak akurat, kita harus menggunakan atau memnbuat variabel baru dengan tipe data double
// Biasanya tipe data double dilanjutkan dengan angka di belakangnya, namun jika hasilnya bulat dibiarkan kosong tanpa angka koma di belakang

double c = 12.0;
double d = 5.0;

Console.WriteLine(c / d);

// Dengan ini kita sudah mempelajari Variabel, Tipe Data, dan Operator Sederhana