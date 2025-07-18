using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class YetiskinKart: Kart
    {
        public YetiskinKart(int id, string sahip, double bakiye) : base(id, sahip, bakiye)
        {
        }
        public override bool OdemeYap(double tutar)
        {
            if (Bakiye == 0)
            {
                Console.WriteLine("Bakiye Yetersiz");
                return false;
            }

            if (Bakiye >= tutar)
            {
                if (Bakiye >= tutar)
                {
                    Bakiye -= tutar;
                }

                Console.WriteLine("Ödeme gerçekleştirildi.");
                return true;
            }
            else
            {
                Console.WriteLine("Bakiye Yetersiz");
                return false;
            }
        }
    }
}
