using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> category = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="bilgisayar"},
                new Category{CategoryId=2,CategoryName="teleon"}

            };
            List<Product> products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="acer bilgisayar",QuantityPerUnit="32 GB RAM ",UnitPrice=10000,UnitsInStock=20},
                new Product{ProductId=2,CategoryId=1,ProductName="asus bilgisayar",QuantityPerUnit="62 GB RAM ",UnitPrice=8000,UnitsInStock=15},
                new Product{ProductId=3,CategoryId=1,ProductName="HP bilgisayar",QuantityPerUnit="20 GB RAM ",UnitPrice=6000,UnitsInStock=5},
                new Product{ProductId=4,CategoryId=2,ProductName="samsun telefon",QuantityPerUnit="8 GB RAM ",UnitPrice=5000,UnitsInStock=8},
                new Product{ProductId=5,CategoryId=2,ProductName="appel telefon",QuantityPerUnit="10 GB RAM ",UnitPrice=8000,UnitsInStock=1 }
            };

            Console.WriteLine("algoritmik-----------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 5)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            Console.WriteLine("linq--------------");
            var result = products.Where(product => product.UnitPrice > 6000 && product.UnitsInStock > 8);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            GetProducts(products);
        }
        static List<Product> GetProducts(List<Product>products)
        {
            List<Product>filTeredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 5)
                {
                    filTeredProducts.Add(product);
                }
            }
            return filTeredProducts;
        }
        static List<Product>GetProductsLinq(List<Product>products)
        {
            return products.Where(product => product.UnitPrice > 6000 && product.UnitsInStock > 8).ToList();
        }
        
        }
        class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }
        class Product
        {
            public int ProductId { get; set; }
            public int CategoryId { get; set; }
            public string QuantityPerUnit { get; set; }
            public string ProductName { get; set; }
            public decimal UnitPrice { get; set; }
            public int UnitsInStock { get; set; }
        }
    }
