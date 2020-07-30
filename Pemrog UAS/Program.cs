using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMobil
{
    class Program
    {

        static List<Mobil> daftarMobil = new List<Mobil>();

        static void Main(string[] args)
        {
            Console.Title = "Rental Mobil";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMobil();
                        break;

                    case 2:
                        HapusMobil();
                        break;

                    case 3:
                        TampilMobil();
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
            Console.WriteLine("\n1. Tambah Mobil");
            Console.WriteLine("2. Hapus Mobil");
            Console.WriteLine("3. Tampilkan Mobil");
            Console.WriteLine("4. Keluar");

        }

        static void TambahMobil()
        {
            Console.Clear();


            Mobil mobil = new Mobil();
            Console.WriteLine("Tambah Data Mobil ");
            Console.Write("Nomor Plat                 : ");
            mobil.Plat = Console.ReadLine();
            Console.Write("Merek                      : ");
            mobil.Merek = Console.ReadLine();
            Console.Write("Kondisi Mobil [B/K]        : ");
            string Jenis = Console.ReadLine();
            mobil.Jenis = (Jenis == "B" || Jenis == "K") ? "Bersih" : "Kotor";
            Console.Write("Warna                      : ");
            mobil.Warna = Console.ReadLine();
            daftarMobil.Add(mobil);
            Console.WriteLine();



            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMobil()
        {
            Console.Clear();


            int no = -1, hapus = -1;
            Console.WriteLine("Hapus Data Mobil\n");
            Console.Write("Nomor Plat : ");
            string Plat = Console.ReadLine();
            foreach (Mobil mobil in daftarMobil)
            {
                no++;
                if (mobil.Plat == Plat)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                daftarMobil.RemoveAt(hapus);
                Console.WriteLine("\nData Mobil Berhasil dihapus");
            }
            else
            {
                Console.WriteLine("\nPlat Mobil tidak ditemukan");
            }



            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMobil()
        {
            Console.Clear();


            int no = 0;
            Console.WriteLine("Data Mobil\n");
            foreach (Mobil mobil in daftarMobil)
            {
                no++;
                string jenis;
                if (mobil.Jenis == "B")
                {
                    jenis = "Bersih";
                }
                else if (mobil.Jenis == "K")
                {
                    jenis = "Kotor";
                }

                Console.WriteLine("{0}. {1}, {2}, {3:N0}, {4:N0}", no, mobil.Plat, mobil.Merek, mobil.Jenis, mobil.Warna);
            }
            if (no < 1)
            {
                Console.WriteLine("Data Mobil Kosong");
            }


            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
