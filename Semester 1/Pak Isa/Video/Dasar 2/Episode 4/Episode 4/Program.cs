// Materi Percabangan

// Pada kesempatan kali ini kita akan mempelajari percabangan : If, If Else, If Else If, Switch

// Percabangan digunakan untuk mengambil keputusan pada program
// Program dapat menjalankan perintah berbeda tergantung kondisi tertentu

// IF 
int umur = 16;

//if (umur >= 17) // If digunakan untuk mengecek kondisi
//                // Kondisi akan menghasilkan true atau false
//{
//    Console.WriteLine("Boleh membuat KTP."); // ini output jika hasilnya true
//}

// Else

if (umur >= 17) // If digunakan untuk mengecek kondisi
                // Kondisi akan menghasilkan true atau false
{
    Console.WriteLine("Boleh membuat KTP."); // ini output jika hasilnya true
}

else // Else dijalankan jika kondisi kondisi false
     // Else digunakan sebagai alternatif ketika kondisi if tidak terpenuhi
{
    Console.WriteLine("Tidak boleh membuat KTP.");
}

// Else If

int nilai = 85;

if (nilai >= 90) 
{
    Console.WriteLine("Nilai A");
}else if (nilai >= 75)
{
    Console.WriteLine("Nilai B");
}
else
{
    Console.WriteLine("Nilai C");
}

// Switch

// Digunakan untuk memilih kondisi berdasarkan nilai tertentu

String hari = "Senin";

switch (hari) // Switch digunakan untuk memeriksa nilai variabel
{
    case "Senin": // case adalah pilihan kondisi
        Console.WriteLine("Hari Pertama");
        break; // break digunakan untuk menghentikan switch

    case "Minggu":
        Console.WriteLine("Hari Ketujuh");
        break;

    default: // default dijalankan jika tidak ada konsisi yang cocok (mirip seperti false di Else IF)
        Console.WriteLine("Hari Lain");
        break;
}

// Dengan ini kita sudah mempelajari percabangan IF, Else, Else If, serta Switch
