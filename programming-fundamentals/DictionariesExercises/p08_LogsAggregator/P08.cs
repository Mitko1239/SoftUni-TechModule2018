using System;
using System.Collections.Generic;
using System.Linq;

namespace p08_LogsAggregator
{
    class P08
    {
        static void Main(string[] args)
        {
            int numOfLogs = int.Parse(Console.ReadLine());
            var dictOfUsers = new SortedDictionary<string, SortedDictionary<string, int>>();
            for (int i = 0; i < numOfLogs; i++)
            {
                string[] userInfo = Console.ReadLine().Split().ToArray();
                string IP = userInfo[0];
                string username = userInfo[1];
                int duration = int.Parse(userInfo[2]);

                if(!dictOfUsers.ContainsKey(username))
                {
                    dictOfUsers.Add(username, new SortedDictionary<string, int>());
                }
                if(!dictOfUsers[username].ContainsKey(IP))
                {
                    dictOfUsers[username].Add(IP, duration);
                }
                else
                {
                    dictOfUsers[username][IP] += duration;
                }
            }
            foreach (var user in dictOfUsers)
            {
                int totalDurationOfUser = dictOfUsers[user.Key].Values.Sum();
                List<string> listOfIps = user.Value.Keys.ToList();
                Console.WriteLine($"{user.Key}: {totalDurationOfUser} [{string.Join(", ", listOfIps)}]");
            }
        }
    }
}
