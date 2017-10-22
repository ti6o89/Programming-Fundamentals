using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> resource = new Dictionary<string, long>();
            string resourceType = Console.ReadLine();

            while (!resourceType.Equals("stop"))
            {
                long resourceQuantity = long.Parse(Console.ReadLine());
                if (!resource.ContainsKey(resourceType))
                {
                    resource.Add(resourceType, 0);
                }
                resource[resourceType] += resourceQuantity;

                resourceType = Console.ReadLine();
            }
            foreach (KeyValuePair<string, long> pair in resource)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
