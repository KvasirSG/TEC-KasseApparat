using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace kasseapparat_library
{
    static internal class SQL
    {
        static string dbPath = Path.Combine(Directory.GetCurrentDirectory(), "products.db");

        static internal void CreateProductTable()
        {
            var db = new SQLiteConnection(dbPath);

            db.CreateTable<Product>();
        }

        static internal List<Product> GetProducts()
        {
            var db = new SQLiteConnection(dbPath);
            List<Product> temp = new List<Product>();

            var query = db.Table<Product>();

            foreach (Product product in query)
            {
                temp.Add(product);
            }

            return temp;
        }

        static internal void AddProduct(Product product)
        {
            var db = new SQLiteConnection(dbPath);

            var s = db.Insert(product);
        }

        static internal void RemoveProduct(Product product)
        {
            var db = new SQLiteConnection(dbPath);

            var s = db.Delete(product);
        }
    }
}
