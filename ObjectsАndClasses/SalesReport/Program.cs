using System;
using System.Linq;

namespace SalesReport
{
    class Program
    {
        static void Main()
        {
            Sale[] sales = ReadSales();
            string[] towns = sales
                        .Select(s => s.Town)
                        .Distinct()
                        .OrderBy(t => t)
                        .ToArray();

            foreach (string town in towns)
            {
                decimal salesByTown = sales
                                .Where(s => s.Town == town)
                                .Select(s => s.Price * s.Quantity)
                                .Sum();
                Console.WriteLine("{0} -> {1:f2}",town,salesByTown);
            }
        }
        static Sale ReadSale()
        {
            string[] info = Console.ReadLine()
                .Split();
            return new Sale()
            {
                Town = info[0],
                Product = info[1],
                Price = decimal.Parse(info[2]),
                Quantity = decimal.Parse(info[3])
            };
        }
        static Sale[] ReadSales()
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];

            for (int i = 0; i < n; i++)
            {
                sales[i] = ReadSale();
            }
            return sales;
        }
    
    }
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
}
