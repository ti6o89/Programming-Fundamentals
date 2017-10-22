using System;
using System.Collections.Generic;
using System.Linq;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            string userNames = Console.ReadLine();
            string[] domains = {".uk", ".us" };

            while (!userNames.Equals("stop"))
            {
                string email = Console.ReadLine();
                emails.Add(userNames, email);
                userNames = Console.ReadLine();
            }

            foreach (var domain in domains)
            {
                var filtredEmails = emails.Where(x => x.Value.EndsWith(domain)).ToList();
                foreach (var userEntry in filtredEmails)
                {
                    emails.Remove(userEntry.Key);
                }
            }
        }
    }
}
