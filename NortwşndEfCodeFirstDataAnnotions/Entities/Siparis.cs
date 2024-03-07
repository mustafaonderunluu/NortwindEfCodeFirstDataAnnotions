using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortwindEfCodeFirstDataAnnotions.Entities
{
    [Table("Orders")]
    public class Siparis
    {
   

        [Column("OrderID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Kod { get; set; }
       
        [Column("CustomerID")]
        public int MusteriKod { get; set; }

        [ForeignKey("MusteriKod")]
        public Musteri Musteri { get; set; }

        //diğer


    }
}
