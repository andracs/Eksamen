using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eksamen.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ImageId { get; set; }
    }
}
