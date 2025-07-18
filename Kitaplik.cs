using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Kitaplik
    {
        private List<Raf> raflar = new List<Raf>();
        public Kitaplik(int rafSayisi)
        {
            for (int i = 0; i < rafSayisi; i++)
            {
                raflar.Add(new Raf());
            }
        }

        public void kitapEkle(Kitap kitap, int rafNumarasi)
        {
            if (rafNumarasi >= 0 && rafNumarasi < raflar.Count)
                raflar[rafNumarasi].KitapEkle(kitap);
            else
                Console.WriteLine("Geçersiz raf numarası!");
        }

        public void KitapSilSıraNo(int rafNumarasi, int index)
        {
            if (rafNumarasi >= 0 && rafNumarasi < raflar.Count)
            {
                if (!raflar[rafNumarasi].kitapSilSıraNo(index))
                    Console.WriteLine("Geçersiz sıra numarası!");
            }
            else
                Console.WriteLine("Geçersiz raf numarası!");
        }

        public void kitapSil(int rafNumarasi, Kitap kitap)
        {
            if (rafNumarasi >= 0 && rafNumarasi < raflar.Count)
            {
                if (!raflar[rafNumarasi].kitapSil(kitap))
                    Console.WriteLine("Kitap bulunamadı!");
            }
            else
                Console.WriteLine("Geçersiz raf numarası!");
        }

        public int kitapAra(String ad)
        {
            for (int i = 0; i < raflar.Count; i++)
            {
                Kitap[] kitaplar = raflar[i].getKitaplar();
                for (int j = 0; j < kitaplar.Length; j++)
                {
                    if (kitaplar[j].Ad == ad)
                    {
                        Console.WriteLine($"Kitap {i}. Rafta");
                        return i;
                    }
                }
            }
            return -1;
        }

        public void gosterRaf(int rafNumarasi)
        {
            if (rafNumarasi >= 0 && rafNumarasi < raflar.Count)
            {
                Console.WriteLine($"--- {rafNumarasi}. Raf ---");
                raflar[rafNumarasi].RafGoster();
            }
            else
            {
                Console.WriteLine("Geçersiz raf numarası!");
            }
        }

        public void tumRaflariGoster()
        {
            for (int i = 0; i < raflar.Count; i++)
            {
                Console.WriteLine($"{i}. Raf");
                raflar[i].RafGoster();
            }
        }
    }
}
