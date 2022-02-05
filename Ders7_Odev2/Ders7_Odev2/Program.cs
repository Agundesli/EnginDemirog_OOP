<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Ders7_Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{ CategoryId=1, CategoryName="Bilgisayar"},
                new Category{ CategoryId=2, CategoryName="Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ ProductId=1, CategoryId=1, ProductName="Asus Laptop",
                    QuantityPerUnit="32 GB Ram", UnitPrice=1000, UnitsInStock=5},
                new Product{ ProductId=2, CategoryId=1, ProductName="Acer Laptop",
                    QuantityPerUnit="16 GB Ram", UnitPrice=250, UnitsInStock=3},
                new Product{ ProductId=3, CategoryId=1, ProductName="Hp Laptop",
                    QuantityPerUnit="12 GB Ram", UnitPrice=250, UnitsInStock=1},
                new Product{ ProductId=4, CategoryId=2, ProductName="Samsung Telefon",
                    QuantityPerUnit="4 GB Ram", UnitPrice=5000, UnitsInStock=15},
                new Product{ ProductId=5, CategoryId=2, ProductName="Apple Telefon",
                    QuantityPerUnit="4 GB Ram", UnitPrice=8000, UnitsInStock=0},
            };
            //Test(products);
            //Console.WriteLine("Algoritmik Methot--------------------------------------------");
            //Urun_Getir(products);
            //Console.WriteLine("Linq Methot--------------------------------------------");
            //Urun_Getir_Linq(products);
            //Console.WriteLine("*************************************************");
            //Any metoduyla birlikte içerisinde ilgili elemanın varlığını sorgularız.Any bool türünde çalışır
            //AnyTest(categories, products);
            //Find metotdu ile parametre Id ile verilen ürüne ait istenilen bilgileri getirir
            //Find(products);
            ////İlgili şarta uyan tüm ürünler için bütün elemanları getirir  
            //FindAll(products);
            //Where komutu ilede FindAll da yaptığımız gibi ilgili şarta göre mevcut ürünleri listeleyebiliriz
            //Where(products);
            //Where ile birlikte gelen ürünleri orderby ile artan veya azalan sıra ile getirebiliriz
            //ilk orderby sıralamasında eşit olan satırlar thenbby ile ikinci bir sıralamaya tabi tutulabilir
            //Where_Thenby_Orderby(products);
            //linq yazmanın alternatifi select from yapısı, her bir p parametresini dönderiyor
            //şarta uyanları listeye ekliyor ve ekrana yazdırıyoruz
            //Select(products);
            //Random_Query(products);
            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         select new JoinList { 
                             ProductId=p.ProductId, 
                             CategoryId=c.CategoryId, 
                             ProductName=p.ProductName, 
                             CategoryName=c.CategoryName,
                             UnitPrice=p.UnitPrice
                         };
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName+"//"+item.CategoryId+"-"+item.CategoryName);
            }
        }

        private static void Random_Query(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 600
                         orderby p.UnitPrice
                         select p;
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void Select(List<Product> products)
        {
            var result = from p in products select p;
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductId + "-" + item.ProductName);
            }
        }

        private static void Where_Thenby_Orderby(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).
                OrderByDescending(p => p.UnitPrice).ThenBy(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void Where(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("Lap"));
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAll(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("Tel"));
            foreach (var p in result)
            {
                Console.WriteLine(p.ProductName);
            }

        }

        private static void Find(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName + " " + result.QuantityPerUnit);
        }

        private static void AnyTest(List<Category> categories, List<Product> products)
        {
            bool r = products.Any(p => p.ProductName == "Acer");
            bool p = categories.Any(p => p.CategoryName == "Kimyasal");
            Console.WriteLine(r);
            Console.WriteLine(p);
        }
        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algoritmik----------------------------------------");
            foreach (var item in products)
            {
                if (item.UnitPrice > 5000 && item.UnitsInStock > 3)
                {
                    Console.WriteLine(item.ProductName);
                }
            }
            Console.WriteLine("Linq----------------------------------------------");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }
        static List<Product> Urun_Getir(List<Product> productss)
        {
            List<Product> filterProduct = new List<Product>();
            foreach (var p in productss)
            {
                if (p.UnitPrice>5000 && p.UnitsInStock>3)
                {
                    Console.WriteLine(p.ProductName);
                }
            }
            return filterProduct;
        }
        static List<Product> Urun_Getir_Linq(List<Product>products)
        {
            return products.Where(product => product.UnitPrice > 5000).ToList();
        }
    }



    //VeriTabanı tabloları sutunları oluşturulurken ilişkisek durumlardan faydalanılır.
    //Aşağıda Category ve Product isimli iki tablo var ediyorum. Bunları birbiri ile ilişkilendirmek 
    //için Product Tablomdaki ürünlerimin hangi kategoryde olduğunu Category ismi ile değil
    //Category Id ile tutmalıyım. İlerde yaşanacak her türlü değişiklite Bütün ürünlerin CategoryName
    //sutunu değiştirmektense Category tablomdaki ilgili Id ye karşılık gelen ismi  değiştirmem 
    //yeterli olacaktır.
    class  Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
    class JoinList
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Ders7_Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{ CategoryId=1, CategoryName="Bilgisayar"},
                new Category{ CategoryId=2, CategoryName="Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ ProductId=1, CategoryId=1, ProductName="Asus Laptop",
                    QuantityPerUnit="32 GB Ram", UnitPrice=1000, UnitsInStock=5},
                new Product{ ProductId=2, CategoryId=1, ProductName="Acer Laptop",
                    QuantityPerUnit="16 GB Ram", UnitPrice=250, UnitsInStock=3},
                new Product{ ProductId=3, CategoryId=1, ProductName="Hp Laptop",
                    QuantityPerUnit="12 GB Ram", UnitPrice=250, UnitsInStock=1},
                new Product{ ProductId=4, CategoryId=2, ProductName="Samsung Telefon",
                    QuantityPerUnit="4 GB Ram", UnitPrice=5000, UnitsInStock=15},
                new Product{ ProductId=5, CategoryId=2, ProductName="Apple Telefon",
                    QuantityPerUnit="4 GB Ram", UnitPrice=8000, UnitsInStock=0},
            };
            //Test(products);
            //Console.WriteLine("Algoritmik Methot--------------------------------------------");
            //Urun_Getir(products);
            //Console.WriteLine("Linq Methot--------------------------------------------");
            //Urun_Getir_Linq(products);
            //Console.WriteLine("*************************************************");
            //Any metoduyla birlikte içerisinde ilgili elemanın varlığını sorgularız.Any bool türünde çalışır
            //AnyTest(categories, products);
            //Find metotdu ile parametre Id ile verilen ürüne ait istenilen bilgileri getirir
            //Find(products);
            ////İlgili şarta uyan tüm ürünler için bütün elemanları getirir  
            //FindAll(products);
            //Where komutu ilede FindAll da yaptığımız gibi ilgili şarta göre mevcut ürünleri listeleyebiliriz
            //Where(products);
            //Where ile birlikte gelen ürünleri orderby ile artan veya azalan sıra ile getirebiliriz
            //ilk orderby sıralamasında eşit olan satırlar thenbby ile ikinci bir sıralamaya tabi tutulabilir
            //Where_Thenby_Orderby(products);
            //linq yazmanın alternatifi select from yapısı, her bir p parametresini dönderiyor
            //şarta uyanları listeye ekliyor ve ekrana yazdırıyoruz
            //Select(products);
            //Random_Query(products);
            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         select new JoinList { 
                             ProductId=p.ProductId, 
                             CategoryId=c.CategoryId, 
                             ProductName=p.ProductName, 
                             CategoryName=c.CategoryName,
                             UnitPrice=p.UnitPrice
                         };
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName+"//"+item.CategoryId+"-"+item.CategoryName);
            }
        }

        private static void Random_Query(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 600
                         orderby p.UnitPrice
                         select p;
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void Select(List<Product> products)
        {
            var result = from p in products select p;
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductId + "-" + item.ProductName);
            }
        }

        private static void Where_Thenby_Orderby(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).
                OrderByDescending(p => p.UnitPrice).ThenBy(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void Where(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("Lap"));
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAll(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("Tel"));
            foreach (var p in result)
            {
                Console.WriteLine(p.ProductName);
            }

        }

        private static void Find(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName + " " + result.QuantityPerUnit);
        }

        private static void AnyTest(List<Category> categories, List<Product> products)
        {
            bool r = products.Any(p => p.ProductName == "Acer");
            bool p = categories.Any(p => p.CategoryName == "Kimyasal");
            Console.WriteLine(r);
            Console.WriteLine(p);
        }
        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algoritmik----------------------------------------");
            foreach (var item in products)
            {
                if (item.UnitPrice > 5000 && item.UnitsInStock > 3)
                {
                    Console.WriteLine(item.ProductName);
                }
            }
            Console.WriteLine("Linq----------------------------------------------");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }
        static List<Product> Urun_Getir(List<Product> productss)
        {
            List<Product> filterProduct = new List<Product>();
            foreach (var p in productss)
            {
                if (p.UnitPrice>5000 && p.UnitsInStock>3)
                {
                    Console.WriteLine(p.ProductName);
                }
            }
            return filterProduct;
        }
        static List<Product> Urun_Getir_Linq(List<Product>products)
        {
            return products.Where(product => product.UnitPrice > 5000).ToList();
        }
    }
    //VeriTabanı tabloları sutunları oluşturulurken ilişkisek durumlardan faydalanılır.
    //Aşağıda Category ve Product isimli iki tablo var ediyorum. Bunları birbiri ile ilişkilendirmek 
    //için Product Tablomdaki ürünlerimin hangi kategoryde olduğunu Category ismi ile değil
    //Category Id ile tutmalıyım. İlerde yaşanacak her türlü değişiklite Bütün ürünlerin CategoryName
    //sutunu değiştirmektense Category tablomdaki ilgili Id ye karşılık gelen ismi  değiştirmem 
    //yeterli olacaktır.
    class  Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
    class JoinList
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
>>>>>>> f4b0bdcc5788429c9acae95480d667bbed9a1c89
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Ders7_Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{ CategoryId=1, CategoryName="Bilgisayar"},
                new Category{ CategoryId=2, CategoryName="Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ ProductId=1, CategoryId=1, ProductName="Asus Laptop",
                    QuantityPerUnit="32 GB Ram", UnitPrice=1000, UnitsInStock=5},
                new Product{ ProductId=2, CategoryId=1, ProductName="Acer Laptop",
                    QuantityPerUnit="16 GB Ram", UnitPrice=250, UnitsInStock=3},
                new Product{ ProductId=3, CategoryId=1, ProductName="Hp Laptop",
                    QuantityPerUnit="12 GB Ram", UnitPrice=250, UnitsInStock=1},
                new Product{ ProductId=4, CategoryId=2, ProductName="Samsung Telefon",
                    QuantityPerUnit="4 GB Ram", UnitPrice=5000, UnitsInStock=15},
                new Product{ ProductId=5, CategoryId=2, ProductName="Apple Telefon",
                    QuantityPerUnit="4 GB Ram", UnitPrice=8000, UnitsInStock=0},
            };
            //Test(products);
            //Console.WriteLine("Algoritmik Methot--------------------------------------------");
            //Urun_Getir(products);
            //Console.WriteLine("Linq Methot--------------------------------------------");
            //Urun_Getir_Linq(products);
            //Console.WriteLine("*************************************************");
            //Any metoduyla birlikte içerisinde ilgili elemanın varlığını sorgularız.Any bool türünde çalışır
            //AnyTest(categories, products);
            //Find metotdu ile parametre Id ile verilen ürüne ait istenilen bilgileri getirir
            //Find(products);
            ////İlgili şarta uyan tüm ürünler için bütün elemanları getirir  
            //FindAll(products);
            //Where komutu ilede FindAll da yaptığımız gibi ilgili şarta göre mevcut ürünleri listeleyebiliriz
            //Where(products);
            //Where ile birlikte gelen ürünleri orderby ile artan veya azalan sıra ile getirebiliriz
            //ilk orderby sıralamasında eşit olan satırlar thenbby ile ikinci bir sıralamaya tabi tutulabilir
            //Where_Thenby_Orderby(products);
            //linq yazmanın alternatifi select from yapısı, her bir p parametresini dönderiyor
            //şarta uyanları listeye ekliyor ve ekrana yazdırıyoruz
            //Select(products);
            //Random_Query(products);
            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         select new JoinList { 
                             ProductId=p.ProductId, 
                             CategoryId=c.CategoryId, 
                             ProductName=p.ProductName, 
                             CategoryName=c.CategoryName,
                             UnitPrice=p.UnitPrice
                         };
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName+"//"+item.CategoryId+"-"+item.CategoryName);
            }
        }

        private static void Random_Query(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 600
                         orderby p.UnitPrice
                         select p;
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void Select(List<Product> products)
        {
            var result = from p in products select p;
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductId + "-" + item.ProductName);
            }
        }

        private static void Where_Thenby_Orderby(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).
                OrderByDescending(p => p.UnitPrice).ThenBy(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void Where(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("Lap"));
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAll(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("Tel"));
            foreach (var p in result)
            {
                Console.WriteLine(p.ProductName);
            }

        }

        private static void Find(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName + " " + result.QuantityPerUnit);
        }

        private static void AnyTest(List<Category> categories, List<Product> products)
        {
            bool r = products.Any(p => p.ProductName == "Acer");
            bool p = categories.Any(p => p.CategoryName == "Kimyasal");
            Console.WriteLine(r);
            Console.WriteLine(p);
        }
        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algoritmik----------------------------------------");
            foreach (var item in products)
            {
                if (item.UnitPrice > 5000 && item.UnitsInStock > 3)
                {
                    Console.WriteLine(item.ProductName);
                }
            }
            Console.WriteLine("Linq----------------------------------------------");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }
        static List<Product> Urun_Getir(List<Product> productss)
        {
            List<Product> filterProduct = new List<Product>();
            foreach (var p in productss)
            {
                if (p.UnitPrice>5000 && p.UnitsInStock>3)
                {
                    Console.WriteLine(p.ProductName);
                }
            }
            return filterProduct;
        }
        static List<Product> Urun_Getir_Linq(List<Product>products)
        {
            return products.Where(product => product.UnitPrice > 5000).ToList();
        }
    }
    //VeriTabanı tabloları sutunları oluşturulurken ilişkisek durumlardan faydalanılır.
    //Aşağıda Category ve Product isimli iki tablo var ediyorum. Bunları birbiri ile ilişkilendirmek 
    //için Product Tablomdaki ürünlerimin hangi kategoryde olduğunu Category ismi ile değil
    //Category Id ile tutmalıyım. İlerde yaşanacak her türlü değişiklite Bütün ürünlerin CategoryName
    //sutunu değiştirmektense Category tablomdaki ilgili Id ye karşılık gelen ismi  değiştirmem 
    //yeterli olacaktır.
    class  Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
    class JoinList
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
>>>>>>> f4b0bdcc5788429c9acae95480d667bbed9a1c89
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Ders7_Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{ CategoryId=1, CategoryName="Bilgisayar"},
                new Category{ CategoryId=2, CategoryName="Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ ProductId=1, CategoryId=1, ProductName="Asus Laptop",
                    QuantityPerUnit="32 GB Ram", UnitPrice=1000, UnitsInStock=5},
                new Product{ ProductId=2, CategoryId=1, ProductName="Acer Laptop",
                    QuantityPerUnit="16 GB Ram", UnitPrice=250, UnitsInStock=3},
                new Product{ ProductId=3, CategoryId=1, ProductName="Hp Laptop",
                    QuantityPerUnit="12 GB Ram", UnitPrice=250, UnitsInStock=1},
                new Product{ ProductId=4, CategoryId=2, ProductName="Samsung Telefon",
                    QuantityPerUnit="4 GB Ram", UnitPrice=5000, UnitsInStock=15},
                new Product{ ProductId=5, CategoryId=2, ProductName="Apple Telefon",
                    QuantityPerUnit="4 GB Ram", UnitPrice=8000, UnitsInStock=0},
            };
            //Test(products);
            //Console.WriteLine("Algoritmik Methot--------------------------------------------");
            //Urun_Getir(products);
            //Console.WriteLine("Linq Methot--------------------------------------------");
            //Urun_Getir_Linq(products);
            //Console.WriteLine("*************************************************");
            //Any metoduyla birlikte içerisinde ilgili elemanın varlığını sorgularız.Any bool türünde çalışır
            //AnyTest(categories, products);
            //Find metotdu ile parametre Id ile verilen ürüne ait istenilen bilgileri getirir
            //Find(products);
            ////İlgili şarta uyan tüm ürünler için bütün elemanları getirir  
            //FindAll(products);
            //Where komutu ilede FindAll da yaptığımız gibi ilgili şarta göre mevcut ürünleri listeleyebiliriz
            //Where(products);
            //Where ile birlikte gelen ürünleri orderby ile artan veya azalan sıra ile getirebiliriz
            //ilk orderby sıralamasında eşit olan satırlar thenbby ile ikinci bir sıralamaya tabi tutulabilir
            //Where_Thenby_Orderby(products);
            //linq yazmanın alternatifi select from yapısı, her bir p parametresini dönderiyor
            //şarta uyanları listeye ekliyor ve ekrana yazdırıyoruz
            //Select(products);
            //Random_Query(products);
            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         select new JoinList { 
                             ProductId=p.ProductId, 
                             CategoryId=c.CategoryId, 
                             ProductName=p.ProductName, 
                             CategoryName=c.CategoryName,
                             UnitPrice=p.UnitPrice
                         };
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName+"//"+item.CategoryId+"-"+item.CategoryName);
            }
        }

        private static void Random_Query(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 600
                         orderby p.UnitPrice
                         select p;
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void Select(List<Product> products)
        {
            var result = from p in products select p;
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductId + "-" + item.ProductName);
            }
        }

        private static void Where_Thenby_Orderby(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).
                OrderByDescending(p => p.UnitPrice).ThenBy(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void Where(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("Lap"));
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAll(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("Tel"));
            foreach (var p in result)
            {
                Console.WriteLine(p.ProductName);
            }

        }

        private static void Find(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName + " " + result.QuantityPerUnit);
        }

        private static void AnyTest(List<Category> categories, List<Product> products)
        {
            bool r = products.Any(p => p.ProductName == "Acer");
            bool p = categories.Any(p => p.CategoryName == "Kimyasal");
            Console.WriteLine(r);
            Console.WriteLine(p);
        }
        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algoritmik----------------------------------------");
            foreach (var item in products)
            {
                if (item.UnitPrice > 5000 && item.UnitsInStock > 3)
                {
                    Console.WriteLine(item.ProductName);
                }
            }
            Console.WriteLine("Linq----------------------------------------------");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }
        static List<Product> Urun_Getir(List<Product> productss)
        {
            List<Product> filterProduct = new List<Product>();
            foreach (var p in productss)
            {
                if (p.UnitPrice>5000 && p.UnitsInStock>3)
                {
                    Console.WriteLine(p.ProductName);
                }
            }
            return filterProduct;
        }
        static List<Product> Urun_Getir_Linq(List<Product>products)
        {
            return products.Where(product => product.UnitPrice > 5000).ToList();
        }
    }
    //VeriTabanı tabloları sutunları oluşturulurken ilişkisek durumlardan faydalanılır.
    //Aşağıda Category ve Product isimli iki tablo var ediyorum. Bunları birbiri ile ilişkilendirmek 
    //için Product Tablomdaki ürünlerimin hangi kategoryde olduğunu Category ismi ile değil
    //Category Id ile tutmalıyım. İlerde yaşanacak her türlü değişiklite Bütün ürünlerin CategoryName
    //sutunu değiştirmektense Category tablomdaki ilgili Id ye karşılık gelen ismi  değiştirmem 
    //yeterli olacaktır.
    class  Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
    class JoinList
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
>>>>>>> f4b0bdcc5788429c9acae95480d667bbed9a1c89
