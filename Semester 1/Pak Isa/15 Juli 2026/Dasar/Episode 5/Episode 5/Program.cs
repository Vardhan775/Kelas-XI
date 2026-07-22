// Materi Perulangan For, While, dan Foreach

// Perulangan digunakan untuk menjalankan perintah berulang Otomatis
// Dengan Perulangan, Program dapat menghemat penulisan code

// 1. FOR Loop
// Digunakan ketika jumlah perulangan sudah diketahui


// For digunakan untuk perulangan dengan jumlah tertentu

// Isi (Parameter) dari For loop
// int i = 1 <- Nilai awal perulangan
// i <= 5 <- Kondisi selama perulangan berjalan
// i++ <- Menambahkan nilai i setiap perulangan

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Perulangan ke-" + i); // Artinya Code diulang selama variabel i kurang dari satu sama dengan 5
}


// 2. While Loop
// Digunakan ketika jumlah perulangan belum diketahui secara pasti

int angka = 1;

while (angka <= 5) // while akan berjalan selama kondisi bernilai true
{
    Console.WriteLine("Perulangan ke-" + angka); 
    angka++;  // Increment wajib agar perulangan tidak berjalan terus menerus
              // Increment wajib tidak ditambahkan, program dapat mengalami infinite loop
}

// 3. Foreach Loop
// Digunakan untuk mengambil data dari kumpulan data seperti Array atau List

// Foreach membaca data dari satu per satu dari array

string[] namaBuah = { "Apel", "Pisang", "Mangga" };

foreach (string buah in namaBuah) // variabel buah pada parameter foreach akan berisi data dari array namaBuah
{
    Console.WriteLine(buah); 
})

// Pada materi ini kita dapat mempelajari pengulangan menggunakan For loop, While loop, dan Foreach loop.