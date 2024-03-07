using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortwindEfCodeFirstDataAnnotions.Entities
{
    [Table("Customer")] //musteri yerine customer gibi oluşturur.
    public class Musteri
    {
        //where CustomerId = "Önder" and ContactName = "Önder Ünlü" //bu ad değişken oldugunu biliyorsak, bunu da kontrol altında tutmak istiyorsak ConcurrencyCheck kullanırız.

        [Key]
        [Column("CustomerID")]
        [MaxLength(5)]  //nvarchar olarak oluşturur.
        public string Kod { get; set; }

        [Required]
        [Column("ContactName")]
        [MaxLength(50)]
        [ConcurrencyCheck] // sadece kolonu 
        public string Ad { get; set; }

        [Required]
        [Column("CompanyName")]
        [MaxLength(50)]
        public string Sirket { get; set; }

        [Column("City")]
        [MaxLength(50)]
        public string Sehir { get; set;}

        [Column("Country")]
    
        public string Ulke { get; set; }

        [NotMapped]
        public string UlkeVeSehir  { get; set; }

        [Timestamp]
        public byte TimeStamp { get; set; }


      
        public List<Siparis> Siparisler { get; set; }

    }
}
