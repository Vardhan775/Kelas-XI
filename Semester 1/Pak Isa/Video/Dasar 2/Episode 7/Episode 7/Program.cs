// Method / Fungsi Sederhana

// Pada Form ini kita akan mempelajari :
// 1. Method / Fungsi
// 2. Parameter
// 3. Return Value


// 1. Method
// adalah kumpulan code yang digunakan untuk menjalankan tugas tertentu
// dapat membantu program menjadi :
// - Lebih rapih
// - Lebih terstruktur
// - dan dapat digunakan kembali (Reuse)

//     void karena method tidak mengembalikan nilai (tanpa return Value)
static void Salam()// Method bersama salam
{
    Console.WriteLine("Hello World!"); //  Method memiliki tugas untuk menampilkan "hello world"
}

// Memanggil Method tanpa return Value dan tanpa Parameter
Salam();

// 2. Method dengan Parameter
// Parameter digunakan untuk mengirim data ke method 

static void Sapa(string nama) // Parameter bertipe String
{
    Console.WriteLine("Halo " + nama); // Variabel Parameter dimasukkan ke dalam method
}

// Memanggil Method dengan parameter sesuai dengan tipe parameter pada method kita buat sebelumnya
Sapa("Budi");


// 3. Method dengan return value
// Method juga dapat mengembalikan nilai (Return Value)

static int Tambah(int a, int b) // Method akan menampilkan nilai bertipe int
{
    return a + b; // return digunakan untuk mengembalikan hasil
}

// Memanggil method dengan return value
Console.WriteLine(Tambah(5 , 7));

// Method digunakan untuk menjalankan tugas tertentu
// Parameter digunakan untuk menerima data
// return digunakan untuk mengembalikan nilai

// Dengan ini kita sudah mempelajari Method / Fungsi dasar
