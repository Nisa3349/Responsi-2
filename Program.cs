using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Hapus Penjualan");
            Console.WriteLine("3. Tampilkan Penjualan");
            Console.WriteLine("4. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            Console.WriteLine("Tambah Data Penjualan");
            Console.WriteLine();

            Console.Write("Nota: ");
            string nota = Console.ReadLine();
            Console.Write("Tanggal: ");
            string tanggal = Console.ReadLine();
            Console.Write("Customer: ");
            string customer = Console.ReadLine();
            Console.Write("Jenis[T/K]: ");
            char jenis = Convert.ToChar(Console.ReadLine());
            string Jenis;
            if (jenis == 'T' || jenis == 't')
                Jenis = "Tunai";
            else
                Jenis = "Kredit";
            Console.Write("Total Nota: ");
            int Total = Convert.ToInt32(Console.ReadLine());

            Penjualan mhs = new Penjualan();
            mhs.Nota = nota;
            mhs.Tanggal = tanggal;
            mhs.Customer = customer;
            mhs.Jenis = Jenis;
            mhs.Total = Total;

            daftarPenjualan.Add(mhs);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            Console.WriteLine("Hapus Data Penjualan");
            Console.Write("Nota: ");
            string Nota = Console.ReadLine();

            int i = 0;
            int size = daftarPenjualan.Count();

            foreach (Penjualan a in daftarPenjualan.ToList())
            {
                if (a.Nota == Nota)
                {
                    daftarPenjualan.Remove(daftarPenjualan[i]);
                    Console.WriteLine("Data Penjualan Berhasil dihapus");

                }
                else
                {
                    if (i == size - 1)
                    {
                        Console.WriteLine("Nota Tidak Ditemukan");
                    }
                }
                i++;
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();



            Console.WriteLine("Data Penjualan");
            Console.WriteLine();

            int i = 0;

            foreach (Penjualan a in daftarPenjualan)
            {
                i++;
                Console.WriteLine($"{i}. {a.Nota}, {a.Tanggal}, {a.Customer}, {a.Jenis}, {a.Total}");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
