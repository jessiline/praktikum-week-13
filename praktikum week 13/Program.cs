using System;
using System.Collections.Generic;
namespace praktikum_w13
{
    class Program
    {
        static void Main(string[] args)
        {
            string tambahData = "y";
            int halo = 0;
            while (tambahData == "y")
            {
                Console.Write("Berapa Data = ");
                int input = Convert.ToInt32(Console.ReadLine());
                var isi = new List<string>();
                for (int i = halo + 1; i <= input; i++)
                {
                    Console.WriteLine($"data ke {i}");
                    Console.Write("NIM : ");
                    int nim = Convert.ToInt32(Console.ReadLine());
                    for (int j = 0; j < isi.Count; j++)
                    {
                        string cek = Convert.ToString(nim);
                        if (cek == isi[j])
                        {
                            Console.Write("NIM SUDAH ADA, MASUKKAN NIM LAIN !!!");
                            Console.Write("NIM : ");
                            nim = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    Console.Write("NAMA : ");
                    string nama = Console.ReadLine();
                    Console.Write("JENIS KELAMIN : ");
                    string kelamin = Console.ReadLine();
                    Console.Write("TAHUN MASUK : ");
                    int tahun = Convert.ToInt32(Console.ReadLine());
                    Console.Write("PROGRAM STUDI : ");
                    string studi = Console.ReadLine();
                    Console.Write("KELAS : ");
                    string kelas = Console.ReadLine();
                    Console.WriteLine();
                    isi.Add(Convert.ToString(nim));
                    isi.Add(nama);
                    isi.Add(kelamin);
                    isi.Add(Convert.ToString(tahun));
                    isi.Add(studi);
                    isi.Add(kelas);
                    halo++;
                }
                Console.Write("PRINT HASIL ? (y/n) ");
                string print = Console.ReadLine();
                if (print == "y")
                {
                    string[,] tabel = new string[7, input];
                    tabel[0, 0] = "NO";
                    tabel[1, 0] = "NIM";
                    tabel[2, 0] = "NAMA";
                    tabel[3, 0] = "JENIS KELAMIN";
                    tabel[4, 0] = "TAHUN MASUK";
                    tabel[5, 0] = "PROGRAM STUDI";
                    tabel[6, 0] = "KELAS";
                    Console.WriteLine();
                    string s = string.Format("{0,-7}{1,-8}{2,-23}{3,-20}{4,-17}{5,-16}{6,10}", tabel[0, 0], tabel[1, 0], tabel[2, 0], tabel[3, 0], tabel[4, 0], tabel[5, 0], tabel[6, 0]).ToUpper();
                    Console.WriteLine(s);
                    for (int i = 0; i < input; i++)
                    {
                        string t = string.Format("{0,-7}{1,-8}{2,-23}{3,-20}{4,-17}{5,-14}{6,10}", i + 1, isi[i], isi[i + 1], isi[i + 2], isi[i + 3], isi[i + 4], isi[i + 5]).ToUpper();
                        Console.WriteLine(t);
                    }
                }
                Console.Write("Tambah Data? (y/n) ");
                tambahData = Console.ReadLine();
            }
        }
    }
}