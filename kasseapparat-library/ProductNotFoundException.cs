using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasseapparat_library
{
    public class ProductNotFoundException : Exception
    {
        public int ProductId;
        public ProductNotFoundException(string msg, int productId) : base(msg)
        {
            ProductId = productId;
        }
    }
}
