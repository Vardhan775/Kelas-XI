// Materi Array dan Koleksi Dasar

// Pada Form ini kita mempelejari :
/// Array
// List
// serta Menyimpan banyak data dalam satu tempat


// 1. Array
// Digunakan untuk menyimpan banyak data dalam satu variabel
// Array biasanya digunakan ketika data memiliki tipe yang sama

// Array dapat menyimpan banyak data dengan tipe data yang sama

string[] namaBuah = { "Apel", "Pisang", "Jeruk" }; // Array string untuk menyimpan beberapa nama buah

// penjelasan struktur Array
// string[] <- tanda [] menunjukkan bahwa variabel adalah array

// mengambil data Array
Console.WriteLine(namaBuah[0]); // Hasilnya akan menampilkan apel (Isi pertama dari Array) karena index array dimulai dari angka 0
Console.WriteLine(namaBuah[2]);

// Array juga sering digunakan bersama dengan perulangan foreach

foreach (string buah in namaBuah)
{
    Console.WriteLine(buah);
}
// Dengan perulangan, kita dapat menghemat penulisan array tanpa harus menulis satu persatu


// 2. Koleksi Dasar: List
// adalah koleksi data yang lebih fleksibel dibanding array

List<string> namaSiswa = new List<String>();

// Menambahkan data ke List
namaSiswa.Add("Budi"); // .Add digunakan unruk menambahkan data ke list
namaSiswa.Add("Anton");
namaSiswa.Add("Siti");

// Menampilkan hasil dari list
foreach (string siswa in namaSiswa)
{
    Console.WriteLine(siswa);
}

// Bedaya dengan array, ukuran dari list lebih fleksibel dibandingkan dengan Array yang memiliki ukuran tetap
// dan cocok untuk data yang sering berubah-ubah (Dinamis)

// Dengan ini kita sudah mempelajari Array dan Koleksi Dasar untuk menyimpan banyak data di satu tempat
