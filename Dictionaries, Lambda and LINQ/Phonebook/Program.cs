using System;
using System.Collections.Generic;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();


            while (! input.Equals("END"))
            {
                string[]inputArgs= input.Split(' ');
                string command = inputArgs[0];

                if (command.Equals("A"))
                {
                    string contact = inputArgs[1];
                    string number = inputArgs[2];

                    phonebook[contact] = number;
                }
                else if (command.Equals("S"))
                {

                    string contact = inputArgs[1];
                    if (phonebook.ContainsKey(contact))
                    {
                        Console.WriteLine("{0} -> {1}", contact, phonebook[contact]);

                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.",contact);
                    }
                    
                }
            }
        }
    }
}
