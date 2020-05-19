using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Eksamen.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Column (TypeName = "Decimal(18,2)")]
        public decimal Price { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public int ProductImage { get; set; }

    }

}
