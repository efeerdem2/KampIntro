using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace OOP1
{
    internal class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        
    }
}
