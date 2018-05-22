using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kasseapparat_library;

namespace CLI_kasseapparat
{
    class Program
    {
        static void Main(string[] args)
        {
            ISystem system = new RegisterSystem();

            foreach (Product pro in system.GetProducts())
            {
                Console.WriteLine(pro.ProductName);
            }

            Console.ReadLine();
            


        }
    }
}
