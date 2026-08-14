// Materi Perulangan For, While, dan Foreach

// Perulangan digunakan untuk menjalankan perintah berulang Otomatis
// Dengan Perulangan, Program dapat menghemat penulisan Code

// 1. FOR
// Digunakan ketika jumlah perluangan sudah diketahui

// For digunakan untuk perulangan dengan jumlah tertentu

// Isi (Parameter) dari For loop
// int i = 1    <- Nilai awal perluangan
// i <= 5       <- Kondisi selama perluangan berjalan
// i++          <- Menambahkan nilai i setiap perulangan

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Perulangan ke-" + i); // Artinya Code diulang selama variabel i kurang dari atau sama dengan 5
}

// 2. While loop
// digunakan ketika jumlah perulangan belum diketahui secara pasti

int angka = 1;
{
while (angka <= 5) // While akan berjalan selama kondisi bernilai true
    Console.WriteLine("Angka" + angka); 
    angka++; // INcrement wajib, agar perluangan tidak berjalan terus menerus
             // Jika increment tidak ditambahkan, program dapat mengalami infite loop
}

// 3. Foreach loop
// Digunakan untuk mengambil data dari kumpulan data seperti array atau list

string[] namaBuah = { "Apel", "Jeruk", "Mangga", "Pisang" };

foreach (string buah in namaBuah) // Variabel buah pada parameter foreach akan berisi data dari array namaBuah
{
    Console.WriteLine(buah);
}

// Dengan ini kita sudah mempelajari kita sudah mempelajari perulangan For loop, While loop, dan Foreach loop