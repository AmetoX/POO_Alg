using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Suma cifra / pb.info / 
namespace Poo_Alg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n.SumaCifra());
        }
    }
    public static class MyExtension 
    { 
        public static int SumaCifra(this int n)
        {
            int suma= 0;
            while (n!=0)
            {

            }
            return suma;
        }
    }

}
