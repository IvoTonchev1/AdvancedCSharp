using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _13.ActivityTracker
{
    class ActivityTracker
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            SortedDictionary<int, SortedDictionary<string, List<double>>> walkingData = new SortedDictionary<int, SortedDictionary<string, List<double>>>();
            SortedDictionary<int, SortedSet<string>> finals = new SortedDictionary<int, SortedSet<string>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int month = DateTime.Parse(input[0]).Month;
                string user = input[1];
                double distance = double.Parse(input[2]);

                if (!walkingData.ContainsKey(month))
                {
                    SortedDictionary<string, List<double>> users = new SortedDictionary<string, List<double>>();
                    List<double> distances = new List<double>();

                    distances.Add(distance);
                    users.Add(user, distances);
                    walkingData.Add(month, users);
                }

                else if (walkingData.ContainsKey(month))
                {
                    if (!walkingData[month].ContainsKey(user))
                    {
                        List<double> distances = new List<double>();
                        distances.Add(distance);

                        walkingData[month].Add(user, distances);
                    }
                    else if (walkingData[month].ContainsKey(user))
                    {
                        walkingData[month][user].Add(distance);
                    }
                }
            }

            foreach (var pair1 in walkingData)
            {
                SortedSet<string> usersInfo = new SortedSet<string>();
                foreach (var pair2 in pair1.Value)
                {
                    string userInfo = pair2.Key + "(" + pair2.Value.Aggregate((a, b) => b + a) + ")";
                    usersInfo.Add(userInfo);
                }
                finals.Add(pair1.Key, usersInfo);
            }

            foreach (var pair in finals)
            {
                Console.WriteLine("{0}: {1}", pair.Key, string.Join(", ", pair.Value));
            }
        }
    }
}
