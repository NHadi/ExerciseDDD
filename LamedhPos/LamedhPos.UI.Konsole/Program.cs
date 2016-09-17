using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.UI.Konsole
{
    struct Karyawan
    {
        private string nama;
        private int usia;

        public void SetNama(string nama)
        {
            this.nama = nama;
        }

        public void SetUsia(int usia)
        {
            if (usia >= 0)
                this.usia = usia;
        }

        public void Perkenalkan()
        {
            Console.WriteLine("Halo {0} berusia ({1})", nama, usia);
        }
    }

    struct PersegiPanjang
    {
        public int Tinggi;
        public int Panjang;

        public void Tampilkan()
        {
            for (int t = 0; t < Tinggi; t++)
            {
                for (int p = 0; p < Panjang; p++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }

        public int CariLuas()
        {
            return Tinggi * Panjang;
        }
    }

    class Program
    {
        static void Main1(string[] args)
        {
            Console.Write("Nama: ");
            string nama = Console.ReadLine();
            Console.Write("Usia: ");
            int usia = int.Parse(Console.ReadLine());

            Console.Write("Nama: ");
            string nama2 = Console.ReadLine();
            Console.Write("Usia: ");
            int usia2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Halo {0} ({1})", nama, usia);
            Console.WriteLine("Halo {0} ({1})", nama2, usia2);
        }
    }
}
