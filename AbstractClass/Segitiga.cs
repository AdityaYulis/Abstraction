using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Segitiga : BangunDatar
    {
        public int s = 0;
        public float a,t;

        public override void Luas()
        {
            Console.Write("Masukkan Alas       = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Tinggi     = ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Sisi       = ");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Luas Segitiga             = " + ((a * t) / 2));
        }

        public override void Keliling()
        {
            Console.WriteLine("Keliling Segitiga         = " + (s + s + s));
        }
    }
}