using NortwşndEfCodeFirstDataAnnotions.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortwindEfCodeFirstDataAnnotions.Context
{
    public class NortwindContext:DbContext
    {
        public DbSet<Musteri> Musteriler { get; set; }

        public DbSet<Siparis> Siparisler { get; set; }





    }
}
