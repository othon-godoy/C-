using LambdaDelegatesLinq.Entities;
using LambdaDelegatesLinq.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaDelegatesLinq
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            // delegate
            // list.Sort(CompareProducts);

            // Comparison<Product> comp = CompareProducts;
            // list.Sort(comp);

            // Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            // list.Sort(comp);

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        */

        /*
        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
        */

        /*
        delegate double BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;

            double result = op(a, b);
            double result2 = op.Invoke(a, b);

            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
        */

        /*
        delegate void BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);
        }
        */

        /*
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // list.RemoveAll(p => p.Price >= 100.0);

            list.RemoveAll(ProductTest);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100;
        }
        */

        /*
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // Action<Product> act = UpdatePrice;

            // Action<Product> act = p => { p.Price += p.Price * 0.1; };

            // list.ForEach(act);

            // list.ForEach(UpdatePrice);

            list.ForEach(p => { p.Price += p.Price * 0.1; });

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
        */

        /*
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // List<string> result = list.Select(NameUpper).ToList();

            // Func<Product, string> func = NameUpper;
            // List<string> result = list.Select(func).ToList();

            // Func<Product, string> func = p => p.Name.ToUpper();
            // List<string> result = list.Select(func).ToList();

            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
        */

        /*
        static void Main(string[] args)
        {
            // specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // define the query expression
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // execute the query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
        */

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 }
            };

            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.0
                select p;

            Print("Tier 1 and Price < 900: ", r1);


            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;

            Print("Names of products from tools", r2);


            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new
                {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name
                };

            Print("Names started with 'C' and anonymous object", r3);


            var r4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Name
                orderby p.Price
                select p;

            Print("Tier 1 order by price then by name", r4);


            var r5 =
                (from p in r4
                 select p)
                .Skip(2)
                .Take(4);

            Print("Tier 1 order by price then by name skip 2 take 4", r5);


            var r16 =
                from p in products
                group p by p.Category;

            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ": ");

                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }

                Console.WriteLine();
            }

            /*
            var r1 = products
                .Where(p => p.Category.Tier == 1 && p.Price < 900);

            Print("Tier 1 and Price < 900: ", r1);


            var r2 = products
                .Where(p => p.Category.Name == "Tools")
                .Select(p => p.Name);

            Print("Names of products from tools", r2);


            var r3 = products
                .Where(p => p.Name[0] == 'C')
                .Select(p => new
                {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name
                });

            Print("Names started with 'C' and anonymous object", r3);


            var r4 = products
                .Where(p => p.Category.Tier == 1)
                .OrderBy(p => p.Price)
                .ThenBy(p => p.Name);

            Print("Tier 1 order by price then by name", r3);


            var r5 = r4
                .Skip(2)
                .Take(4);

            Print("Tier 1 order by price then by name skip 2 take 4", r5);


            var r6 = products.First();
            Console.WriteLine("First: " + r6);


            var r7 = products
                .Where(p => p.Price > 3000.0)
                .FirstOrDefault();

            Console.WriteLine("First or default: " + r7);


            var r8 = products
                .Where(p => p.Id == 3)
                .SingleOrDefault();

            Console.WriteLine("Single or default: " + r8);


            var r10 = products
                .Max(p => p.Price);

            Console.WriteLine("Max price: " + r10);


            var r11 = products
               .Min(p => p.Price);

            Console.WriteLine("Max price: " + r11);


            var r12 = products
                .Where(p => p.Category.Id == 1)
                .Sum(p => p.Price);

            Console.WriteLine("Category 1 Sum prices: " + r12);


            var r13 = products
                .Where(p => p.Category.Id == 1)
                .Average(p => p.Price);

            Console.WriteLine("Category 1 Average prices: " + r13);


            var r14 = products
                .Where(p => p.Category.Id == 5)
                .Select(p => p.Price)
                .DefaultIfEmpty(0.0)
                .Average();

            Console.WriteLine("Category 5 Average prices: " + r14);


            var r15 = products
                .Where(p => p.Category.Id == 1)
                .Select(p => p.Price)
                .Aggregate(0.0, (x, y) => x + y);

            Console.WriteLine("Category 1 aggregate sum: " + r15);


            Console.WriteLine();

            var r16 = products.GroupBy(p => p.Category);

            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ": ");

                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }

                Console.WriteLine();
            }
            */
        }

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);

            foreach(T obj in collection)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
        }
    }
}
