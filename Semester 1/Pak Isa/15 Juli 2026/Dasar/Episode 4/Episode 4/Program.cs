// Materi Percabangan
// Pada materi ini kita mempelajari percabangan : If, Else, Else If, dan Switch
// Percabangan digunakan untu mengambil keputusan pada program
// Program dapat menjalankan perintah berbeda tergantung kondisi tertentu

// IF
int umur = 15;

if (umur >= 17) // If digunakan untuk mengecek kondisi,
                // Kondisi akan menghasilkan true atau false
{
    Console.WriteLine("Boleh membuat KTP"); // Ini output jika hasilnya true
}

// ELSE
else // Else dijalankan jika kondisinya false
     // Else digunakan sebagai alternatif jika kondisi pada if tidak terpenuhi
{
    Console.WriteLine("Belum boleh membuat KTP"); 
}

// ELSE IF

int nilai = 85;

if (nilai >= 90)
{
    Console.WriteLine("Nilai A");
}
else if (nilai >= 75) // Else If digunakan untuk menambahkan kondisi lain
                      // Else If memungkinkan program memeriksa beberapa kondisi berbeda
{
    Console.WriteLine("Nilai B");
}
else {
    Console.WriteLine("Nilai C");
}

// SWITCH

// Digunakan untuk memilih kondisi berdasarkan nilai dari sebuah variabel

string hari = "Rabu";

switch (hari) // switch digunakan untuk memeriksa nilai variabel
{
    case "Senin": // case adalah pilihan kondisi
        Console.WriteLine("Hari pertama");
        break; // break digunakan untuk menghentikan switch
    case "Minggu":
        Console.WriteLine("Hari Ketujuh");
        break;
    default: // default digunakan jika tidak ada kondisi yang cocok (mirip seperti false di Else If)
        Console.WriteLine("Hari tidak valid");
        break;
}

// Dengan materi ini kita sudah mempelajari percabangan If, Else, Else IF, serta Switch