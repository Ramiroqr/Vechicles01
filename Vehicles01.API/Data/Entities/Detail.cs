using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles01.API.Data.Entities
{
    public class Detail
    {
        public int Id { get; set; }

        public History History { get; set; }

        public Procedure Procedure { get; set; }

        public decimal LaborPrice { get; set; }

        public decimal SparePartsPrice { get; set; }

        public decimal TotalPrice => LaborPrice + SparePartsPrice;

        public string Remarks { get; set; }
    }
}
