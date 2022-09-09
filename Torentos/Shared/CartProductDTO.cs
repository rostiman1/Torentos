using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torentos.Shared
{
    public class CartProductDTO
    {
        public int ProductId { get; set; }
        public string Title { get; set; } = string.Empty;
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }

    }
}
