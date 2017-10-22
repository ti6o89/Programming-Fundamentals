using System;
using System.Collections.Generic;
using System.Linq;

namespace AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> shop = new Dictionary<string, decimal>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] productInfo = Console.ReadLine().Split('-');
                string productName = productInfo[0];
                decimal productPrice = decimal.Parse( productInfo[1]);

                if (!shop.ContainsKey(productName))
                {
                    shop.Add(productName,productPrice);
                }
                shop[productName] = productPrice;
            }

            string customerInfoLine = Console.ReadLine();
            List<Customer> customers = new List<Customer>();

            while (customerInfoLine.Equals("end of clinets"))
            {
                string[] customerArgs = customerInfoLine.Split('-', ',');
                string customerName = customerArgs[0];
                string customerWish = customerArgs[1];
                int quantity = int.Parse(customerArgs[2]);

                Customer customer = new Customer();
                customer.Name = customerName;

                if (!shop.ContainsKey(customerWish))
                {
                    customerInfoLine = Console.ReadLine();
                    continue;
                }

                customer.ShopList = new Dictionary<string, int>();
                customer.ShopList.Add(customerWish, quantity);

                if (customers.Any(c => c.Name==customerName))
                {
                    Customer existingCustomer = customers.First(c => c.Name == customerName);
                    if (existingCustomer.ShopList.ContainsKey(customerWish))
                    {
                        existingCustomer.ShopList[customerWish] += quantity;
                    }
                    else
                    {
                        existingCustomer.ShopList[customerWish] = quantity;
                    }

                }
                else
                {
                    customers.Add(customer);
                }

                customerInfoLine = Console.ReadLine();
            }

            foreach (var customer in customers)
            {
                foreach (var item in customer.ShopList)
                {

                    foreach (var product in shop)
                    {
                        if (item.Key==product.Key)
                        {
                            customer.Bill += item.Value * product.Value;
                        }
                    }
                }
            }

            var ordered = customers
                .OrderBy(c => c.Name)
                .ThenBy(x => x.Bill)
                .ToList();

            foreach (var customer in ordered)
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string,int> item in customer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine("Bil: {0:f2}",customer.Bill);
            }
            Console.WriteLine("Total bill: {0:f2}",customers.Sum(s =>s.Bill));
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string,int> ShopList { get; set; }
        public decimal Bill { get; set; }
    }
}
