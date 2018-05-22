using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace kasseapparat_library
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductDiscountRequirement { get; set; }
        public int ProductDiscount { get; set; }

        public Product()
        {

        }
        public Product(string ProductName, decimal ProductPrice, int ProductDiscountRequirement, int ProductDiscount)
        {
            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
            this.ProductDiscountRequirement = ProductDiscountRequirement;
            this.ProductDiscount = ProductDiscount;
        }
    }
}
