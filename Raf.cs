using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Raf
    {
        private List<Kitap> kitaplar = new List<Kitap>();
        public void KitapEkle(Kitap kitap)
        {
            kitaplar.Add(kitap);
        }

        public bool kitapSil(Kitap kitap)
        {
            if (kitaplar.Contains(kitap))
            {
                kitaplar.Remove(kitap);
                return true;
            }
            return false;
        }

        public bool kitapSilSıraNo(int index)
        {
            if (index >= 0 && index < kitaplar.Count)
            {
                kitaplar.RemoveAt(index);
                return true;
            }
            return false;
        }

        public void RafGoster()
        {
            for (int i = 0; i < kitaplar.Count; i++)
            {
                kitaplar[i].toString();
            }
        }

        public Kitap[] getKitaplar()
        {
            return kitaplar.ToArray();
        }
    }
}
