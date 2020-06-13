using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class PersegiPanjang : lBangunDatar
    {
        public int p,l;

        public void Luas()
        {
            Console.Write("Masukkan Panjang    = ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Lebar      = ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Luas Persegi Panjang      = " + (p * l));
        }

        public void Keliling()
        {
            Console.WriteLine("Keliling Persegi Panjang  = " + (2 * (p + l)));
        }
    }
}