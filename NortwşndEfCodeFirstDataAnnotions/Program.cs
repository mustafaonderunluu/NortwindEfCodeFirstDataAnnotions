using NortwşndEfCodeFirstDataAnnotions.Context;
using NortwşndEfCodeFirstDataAnnotions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortwindEfCodeFirstDataAnnotions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var nortwindContext = new NortwindContext()) { 
            
            List<Musteri> musteriler =nortwindContext.Musteriler.ToList();

                foreach (var musteri in musteriler) {



                    Console.WriteLine("{0}", musteri.Ad);
                }

            
            }

            Console.ReadLine();
        }
    }
}
