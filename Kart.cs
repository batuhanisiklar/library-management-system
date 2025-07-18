using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public abstract class Kart
    {
        public int Id { get; private set; }
        public string Sahip { get; private set; }
        public double Bakiye { get; protected set; }

        protected Kart(int id, string sahip, double bakiye)
        {
            Id = id;
            Sahip = sahip;
            Bakiye = bakiye;
        }
        public abstract bool OdemeYap(double tutar);
        public override string ToString()
        {
            return $"Id: {Id}, Sahip: {Sahip}, Bakiye: {Bakiye}";
        }
    }
}