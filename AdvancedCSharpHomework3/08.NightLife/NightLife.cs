using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _08.NightLife
{
    class NightLife
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Dictionary<string, SortedDictionary<string, SortedSet<string>>> result = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
            while (line != "END")
            {
                string[] input = line.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
                string city = input[0];
                string venue = input[1];
                string performer = input[2];
                if (!result.ContainsKey(city))
                {
                    SortedSet<string> performers = new SortedSet<string>();
                    performers.Add(performer);
                    SortedDictionary<string, SortedSet<string>> venues = new SortedDictionary<string, SortedSet<string>>();
                    venues.Add(venue, performers);
                    result.Add(city,venues);
                }
                else
                {
                    if (!result[city].ContainsKey(venue))
                    {
                        SortedSet<string> performers = new SortedSet<string>();
                        performers.Add(performer);
                        result[city].Add(venue, performers);
                    }
                    else
                    {
                        result[city][venue].Add(performer);
                    }
                }
                line = Console.ReadLine();
            }
            Console.WriteLine();
            foreach (var city in result)
            {
                Console.WriteLine(city.Key);
                foreach (var venue in city.Value)
                {
                    Console.WriteLine("->" + venue.Key + ": " + string.Join(", ", venue.Value));
                }
            }
        }
    }
}
