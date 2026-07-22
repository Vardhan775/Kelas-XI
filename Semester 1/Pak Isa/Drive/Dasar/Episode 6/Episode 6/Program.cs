// Materi Array dan Koleksi Dasar

// 1. Array
// Digunakan untuk menyimpan banyak data dalam satu variabel
// Array biasanya digunakan ketika data memiliki tipe yang sama

// Array dapat menyimpan banyak data dengan tipe data yang sama

//                     0,       1,       2
string[] namaBuah = {"Apel", "Jeruk", "Mangga"}; //Array string untuk menyimpan beberapa nama buah

// penjelasan struktur Array
//string[] <- tanda [] menunjukkan bahwa variabel adalah array

//Mengambil data Array
Console.WriteLine(namaBuah[0]); // Hasilnya akan menampilkan apel (Isi pertama dari array) karena index array dimulai dari angka 0
Console.WriteLine(namaBuah[2]);

// Array juga dapat digunakan bersama dengan perulangan

foreach (string buah in namaBuah)
{
    Console.WriteLine(buah);
}

// Dengan pengulangan, kita dapat menghemat penulisan array tanpa harus menulis satu persatu


// 2. List
// adalah koleksi data yang lebih fleksibel dibanding array

List<string> namaSiswa = new List<string>(); // Membuat list untuk menyimpan data siswa

// Menambahkan data ke list
namaSiswa.Add("Budi"); // .Add digunakan untuk menambahkan data ke list
namaSiswa.Add("Anton");
namaSiswa.Add("Siti");

foreach (string siswa in namaSiswa)
{
    Console.WriteLine(siswa);
})

// Bedanya dengan array, ukuran dari list lebih fleksibel dibandingkan dengan Array yang memiliki ukuran tetap
// dan cocok untuk data yang sering berubah-ubah (Dinamis)

// Dengan ini kita dapat belajar tentang Array dan Koleksi Dasar untuk menyimpan banyak data di satu tempat