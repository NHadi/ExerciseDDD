using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.UI.Konsole
{
    interface IBerjalanable
    {
        void Berjalan();
    }

    abstract class Hewan : IBerjalanable
    {
        public string nama;
        public int usia;

        public void Makan()
        {
            Console.WriteLine("Hewan makan");
        }

        public abstract void Berjalan();
        public abstract void Bersuara();
    }

    class Ayam : Hewan
    {
        public override void Berjalan()
        {
            Console.WriteLine("Ais ais ais..");
        }

        public void Bertelur()
        {
            Console.WriteLine("Ceplok..");
        }

        public override void Bersuara()
        {
            Console.WriteLine("ptok ptok..");
        }
    }

    class Kuda : Hewan
    {
        public override void Berjalan()
        {
            Console.WriteLine("tuk tik tak tik tuk..");
        }

        public void Jingkrak()
        {
            Console.WriteLine("Gedebrek..");
        }

        public override void Bersuara()
        {
            Console.WriteLine("Hiehiehiehie..");
        }
    }

    class Program2
    {
        static void Main2(string[] args)
        {
            Kuda k = new Kuda();
            k.Jingkrak();
            k.Berjalan();
            k.nama = "budi";

            Ayam a = new Ayam();
            a.Berjalan();
            a.Bertelur();


            // sebelah kanan harus hewan
            Hewan h2 = a;
            h2.nama = "Dirubah sama h2";
            Console.WriteLine(a.nama);
            a.Berjalan();
            h2.Berjalan();
            h2 = k;
            h2.Berjalan();

            IBerjalanable b = a;
            b.Berjalan();
        }
    }
}
