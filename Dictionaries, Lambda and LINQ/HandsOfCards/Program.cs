using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> playersCards = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (!input.Equals("JOKER"))
            {
                string[] comandArgs = input.Split(new char[] { ':' }, StringSplitOptions.None);
                string playerName = comandArgs[0];
                string[] cards = comandArgs[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(c => c.Trim()).ToArray();
                if (!playersCards.ContainsKey(playerName))
                {
                    playersCards.Add(playerName, new List<string>());
                }
                playersCards[playerName].AddRange(cards);

                input = Console.ReadLine();
            }
            PrintPlayersSocres(playersCards);

        }

        private static void PrintPlayersSocres(Dictionary<string, List<string>> playersCards)
        {
            foreach (var playerEntry in playersCards)
            {
                string playerName = playerEntry.Key;
                List<string> cards = playerEntry.Value.Distinct().ToList();
                int sum = 0;
                foreach (var card in cards)
                {
                    string rank = card.Substring(0, card.Length - 1);
                    string suite = card.Substring(card.Length - 1);

                    int rankPower = GetRank(rank);
                    int suitePower = GetSuite(suite);

                    sum += rankPower * suitePower;
                }
                Console.WriteLine("{0}: {1}", playerName, sum);
            }
        }

        private static int GetSuite(string suite)
        {
            switch (suite)
            {
                case "S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;
                default:
                    return 1;
            }
        }

        private static int GetRank(string rank)
        {
            switch (rank.Trim())
            {
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "10":
                    return 10;
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return 1;
            }

        }
    }
}
