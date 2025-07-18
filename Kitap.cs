using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Kitap
    {
        private string ad;
        private string yazar;
        private readonly string isbn;
        private double fiyat; 

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public double Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
        }
        public string Yazar
        {
            get { return yazar; }
            set { yazar = value; }
        }

        public string ISBN
        {
            get { return isbn; }
        }
        public Kitap(string ad, string yazar, string isbn,double fiyat)
        {
            this.ad = ad;
            this.yazar = yazar;
            this.isbn = isbn;
            this.fiyat = fiyat;
        }

        public void toString()
        {
            Console.WriteLine($"Ad: {ad}, Yazar: {yazar}, ISBN: {isbn}, Fiyat: {fiyat}");
        }
    }
}