using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortwindEfCodeFirstDataAnnotions.Entities
{
    [ComplexType]
    public class MusteriSiparisDTO
    {
        public int CustomerID { get; set; }
        public int OrderID { get; set; }

        //diğer


    }
}
