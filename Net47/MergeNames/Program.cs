using System;
using System.Collections.Generic;
using System.Linq;


public class MergeNames
{
    public static string[] UniqueNames(string[] names1, string[] names2)
    {
        var result = new List<string>();
        result.AddRange(names1);
        result.AddRange(names2);

        return result.Distinct().ToArray();

    }

    public static void Main(string[] args)
    {
        string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
        string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
        Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
    }
}