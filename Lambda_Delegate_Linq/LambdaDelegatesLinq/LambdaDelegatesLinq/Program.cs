using LambdaDelegatesLinq.Entities;
using LambdaDelegatesLinq.Services;
using System;
using System.Collections.Generic;

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

        delegate void BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);
        }
    }
}
