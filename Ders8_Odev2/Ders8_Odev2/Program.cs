using System;
using System.Collections.Generic;
using System.Linq;

namespace Ders8_Odev2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>()
            {
                new Category{ CategoryId=1, CategoryName="Bilgisayar"},
                new Category{ CategoryId=2, CategoryName="Telefon"},
                new Category{ CategoryId=3, CategoryName="Telefon"},
                new Category{ CategoryId=4, CategoryName="Telefon"}
            };
            List<Product> products = new List<Product>
            {
                new Product{ ProductId=1, CategoryId=1, ProductName="Asus Laptop", 
                    QuantityPerUnit="32 GB Ram",UnitPrice=1000, UnitsInStock=5},
                new Product{ ProductId=2, CategoryId=1, ProductName="Acer Laptop",
                    QuantityPerUnit="16 GB Ram", UnitPrice=250, UnitsInStock=3},
                new Product{ ProductId=3, CategoryId=1, ProductName="Hp Laptop",
                    QuantityPerUnit="12 GB Ram", UnitPrice=250, UnitsInStock=1},
                new Product{ ProductId=4, CategoryId=2, ProductName="Samsung Telefon",
                    QuantityPerUnit="4 GB Ram", UnitPrice=6000, UnitsInStock=15},
                new Product{ ProductId=5, CategoryId=2, ProductName="Apple Telefon",
                    QuantityPerUnit="4 GB Ram", UnitPrice=8000, UnitsInStock=0},
            };
            //foreach (var item in products)
            //{
            //    if (item.UnitPrice>5000)
            //    {
            //        //Console.WriteLine(item.ProductName);
            //    }
            //}
            //List<Product> result = products.Where(p => p.UnitPrice > 5000).ToList();
            //foreach (var item in result)
            //{
            //    //Console.WriteLine(item.ProductName);
            //}
            Get(products);
            //Console.WriteLine(Get().Count);
            //Console.WriteLine(Get());
           
            
            //Console.WriteLine(GetLinq(categories));
           
        }
        static List<Product> Get(List<Product> products)
        {
            List<Product> filterlist = new List<Product>();
            //Listeye atmak için yeni bir filtreli ürünler için list oluşturuyorum
            foreach (var pro in products)
            {
                if (pro.UnitPrice>5000)
                {
                    filterlist.Add(pro);
                    Console.WriteLine(pro.ProductName);
                    //Burada herbir filtrelenen elemanı yeni bir listeye döndürmem lazım.
                    //oluşturduğum listeye  products listesinden dönen t parametresi ile gösterilen filtreli ürünleri atıyorum.
                }
            }
            return filterlist;//tanımladığım liste atılan filtreli ürünleri ver bana
        }
        //static List<Category> GetLinq(List<Category> categories)
        //{
        //    var a = categories.Where(p => p.CategoryName=="Telefon").ToList();
        //    //foreach (var item in a)
        //    //{
        //    //    Console.WriteLine(item.CategoryName);
        //    //}
        //    return a;
        //}
    }
}
