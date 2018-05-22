using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasseapparat_library
{
    public interface ISystem
    {
        void AddProduct(int product_id);
        void RemoveProduct(int product_id);
        Product GetProductByID(int id);
        List<Product> GetProducts();
        void CreateProduct(string ProductName, decimal ProductPrice, int ProductDiscountRequirement, int ProductDiscount);
        void DeleteProduct(string ProductName, decimal ProductPrice, int ProductDiscountRequirement, int ProductDiscount);
    }
}
