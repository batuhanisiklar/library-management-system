using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class OgrenciKart : Kart
    {
        public double Bonus { get; private set; }

        public OgrenciKart(int id, string sahip, double bakiye) : base(id, sahip, bakiye)
        {
            Bonus = 0;
        }

        public override bool OdemeYap(double tutar)
        {
            if (Bakiye == 0)
            {
                if (Bonus >= tutar)
                {
                    Bonus -= tutar;
                    Console.WriteLine("Ödeme bonus ile gerçekleştirildi.");
                    return true;
                }
                Console.WriteLine("Bakiye Yetersiz");
                return false;
            }
            

            if (Bakiye >= tutar)
            {
                Bakiye -= tutar;

                double kazanilanBonus = tutar * 0.25;
                Bonus += kazanilanBonus;
                Console.WriteLine("Ödeme gerçekleştirildi.");
                return true;
            }
            else if (Bonus >= tutar)
            {
                Bonus -= tutar;
                Console.WriteLine("Ödeme bonus ile gerçekleştirildi.");
                return true;
            }
            else
            {
                Console.WriteLine("Bakiye Yetersiz");
                return false;
            }
        }
        public override string ToString()
        {
            return $"Id: {Id}, Sahip: {Sahip}, Bakiye: {Bakiye}, Bonus: {Bonus} ";
        }
    }
}