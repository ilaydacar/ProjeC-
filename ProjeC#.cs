using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurasecim_Oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim;
            do
            {
                Console.WriteLine("Kuraya kaç kişi katılacak?");
                int kisiSayisi = int.Parse(Console.ReadLine());
                string[] kisiListesi = new string[kisiSayisi];
                for (int i = 0; i < kisiListesi.Length; i++)
                {
                    Console.WriteLine("Kuraya katılacak ismi giriniz.");
                    kisiListesi[i] = Console.ReadLine();
                }

                int kuraSiralamasi = new Random().Next(0, kisiListesi.Length - 1);
                Console.WriteLine("Kazanan:{0}", kisiListesi[kuraSiralamasi]);
                Console.WriteLine("Yeni bir kura başlatmak için 1'i tuşlayınız.");
                secim = int.Parse(Console.ReadLine());
                Console.Clear();

            } while (secim == 1);
            Console.ReadKey();
        }
    }
}
