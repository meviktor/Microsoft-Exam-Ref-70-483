﻿using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

//Using GetConsumingEnumerable on a BlockingCollection
namespace Chapter1
{
    public static class Listing_1_29
    {
        public static void Main()
        {
            BlockingCollection<string> col = new BlockingCollection<string>();

            Task read = Task.Run(() =>
            {
                foreach (string v in col.GetConsumingEnumerable())
                    Console.WriteLine(v);
            });

            Task write = Task.Run(() =>
            {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) break;
                    col.Add(s);
                }
            });

            write.Wait();
        }
    }
}