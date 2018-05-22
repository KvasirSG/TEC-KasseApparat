using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace kasseapparat_library
{
    public class RegisterSystem : ISystem
    {
        private List<Product> _products = new List<Product>();
        private List<Product> _shoppinglist = new List<Product>();

        public RegisterSystem()
        {
            LoadProducts(ref _products);
        }

        private void LoadProducts(ref List<Product> products)
        {
            SQL.CreateProductTable();
            _products.AddRange(SQL.GetProducts());
        }

        public void AddProduct(int product_id)
        {
            _shoppinglist.Add(GetProductByID(product_id));
        }

        public Product GetProductByID(int id)
        {
            Product temp = _products.Find(p => p.ProductID == id);
            if (temp != null) return temp;
            throw new ProductNotFoundException("The Specified product was not found",id);
        }

        public void RemoveProduct(int product_id)
        {
            _shoppinglist.Remove(GetProductByID(product_id));
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public void CreateProduct(string ProductName, decimal ProductPrice, int ProductDiscountRequirement, int ProductDiscount)
        {
            SQL.AddProduct(new Product(ProductName, ProductPrice, ProductDiscountRequirement, ProductDiscount));
        }

        public void DeleteProduct(string ProductName, decimal ProductPrice, int ProductDiscountRequirement, int ProductDiscount)
        {
            SQL.RemoveProduct(new Product(ProductName, ProductPrice, ProductDiscountRequirement, ProductDiscount));
        }
    }
}
