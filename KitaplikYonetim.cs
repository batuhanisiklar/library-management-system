using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class KitaplikYonetim
    {
        private Kitaplik kitaplik;

        public KitaplikYonetim(Kitaplik kitaplik)
        {
            this.kitaplik = kitaplik;
        }

        public bool KitapSat(Kitap kitap, Kart kart)
        {
            int bulunan = kitaplik.kitapAra(kitap.Ad);

            if (bulunan != -1)
            {
                if (kart.OdemeYap(kitap.Fiyat))
                {
                    kitaplik.kitapSil(bulunan,kitap);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }

}
