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
                    QuantityPerUnit="32 GB Ram",UnitPrice=10000, UnitsInStock=5},
                new Product{ ProductId=2, CategoryId=1, ProductName="Acer Laptop",
                    QuantityPerUnit="16 GB Ram", UnitPrice=250000, UnitsInStock=3},
                new Product{ ProductId=3, CategoryId=1, ProductName="Hp Laptop",
                    QuantityPerUnit="12 GB Ram", UnitPrice=500, UnitsInStock=1},
                new Product{ ProductId=4, CategoryId=2, ProductName="Samsung Telefon",
                    QuantityPerUnit="4 GB Ram", UnitPrice=6000, UnitsInStock=15},
                new Product{ ProductId=5, CategoryId=2, ProductName="Apple Telefon",
                    QuantityPerUnit="4 GB Ram", UnitPrice=8000, UnitsInStock=0},
            };
            foreach (var item in products)
            {
                if (item.UnitPrice > 5000)
                {
                    //Console.WriteLine(item.ProductName);
                }
            }
            List<Product> result = products.Where(p => p.UnitPrice > 5000).ToList();
            foreach (var item in result)
            {
                //Console.WriteLine(item.ProductName);
            }
            //Get(products);
            //Console.WriteLine(GetLinq(categories));
            //ANY(products);
            //ANY2(products);
            //Find(products);
            //FindAll(products);
            //Where(products);
            //WhereOrder(products);
            //SelecFrom(products);
            //InnerJoin(categories, products);

            GetAll();
            Console.WriteLine("******************************");
            GetProductsByCategoryId(1);
        }
        private static void GetProductsByCategoryId(int categoryId)
        {
            NorthwindContext northwindContext1 = new NorthwindContext();
            var result = northwindContext1.Products.Where(p => p.CategoryId == categoryId);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void GetAll()
        {
            //Context ile uyg ve DB arasındaki köprüyü kuruyorum;
            NorthwindContext northwindContext = new NorthwindContext();
            //NortwinContext içeriisndeki prop lara erişebilirim
            foreach (var item in northwindContext.Products)
            {
                Console.WriteLine(item.ProductName);
            }
            //Entity framework ile bri veri tabanına bağlanıp veri çekme oalyı bu kadar
        }

        private static void InnerJoin(List<Category> categories, List<Product> products)
        {
            var r = from p in products
                    join c in categories
                    on p.CategoryId equals c.CategoryId
                    select new Join
                    {
                        ProductId = p.ProductId,
                        CategoryName = c.CategoryName,
                        UnitPrice = p.UnitPrice,
                        ProductName = p.ProductName
                    };
            foreach (var item in r)
            {
                Console.WriteLine(item.ProductName + "-" + item.CategoryName);
            }
        }

        private static void SelecFrom(List<Product> products)
        {
            var r = from p in products
                    where p.UnitPrice > 6000
                    orderby p.UnitPrice descending, p.ProductName descending
                    select p;
            foreach (var item in r)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void WhereOrder(List<Product> products)
        {
            var r = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice);//order ile sıralama yapıyorum
                                                                                                 //order default asc çalıştırır. desc büyükten küçüğe
            foreach (var item in r)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void Where(List<Product> products)
        {
            var r = products.Where(p => p.ProductName.Contains("top"));
            Console.WriteLine(r);//where ifadesi ilede doğrudan yazdır dersem bellekte tutulan referans adresini getirir. 
            //o zaman bu ürünleri ikinci bir döngü ile gezip bu şekilde ekrana yazdıracağım
            foreach (var item in r)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void FindAll(List<Product> products)
        {
            var r = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(r);//FindAll doğrudan liste referansını getirir.
        }

        private static void Find(List<Product> products)
        {
            var r = products.Find(p => p.ProductId == 3);
            Console.WriteLine(r);//şimdi products listesi içeriisnde bir döngü kurdum ve ProductId = 3 olanı bulup 
            //List<Product> değişkeni ile tanımlanmış r parametresi içerisine atadım. Ekrana yukarıdaki, gibi yazdırdığımda
            //r parametresiniin bellekteki adresini getiriyor. r parametresi ProductId'si 3 olanı buşdu ve hafızasında tutuyor
            Console.WriteLine(r.ProductName);//bu şekilde yazdırdığımda is hafızada tuttuğu değerin bir özelliğini yaz demiş oldum.
        }

        private static void ANY2(List<Product> products)
        {
            var urün = products.Any(p => p.ProductName == "Dell Laptop");
            Console.WriteLine(urün);
        }

        private static void ANY(List<Product> products)
        {
            var urun = products.Any(p => p.ProductName == "Asus Laptop");
            Console.WriteLine(urun);
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
        static List<Category> GetLinq(List<Category> categories)
        {
            var a = categories.Where(p => p.CategoryName == "Telefon").ToList();
            //foreach (var item in a)
            //{
            //    Console.WriteLine(item.CategoryName);
            //}
            return a;
        }
    }
}
