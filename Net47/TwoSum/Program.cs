using System;
using System.Collections.Generic;

class TwoSum
{
    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {
        var dictionary = new Dictionary<int,int>();

        for (int i = 0; i < list.Count; i++)
        {
            var value = list[i];
            var required = sum - value;

            if (dictionary.ContainsKey(required))
                return new Tuple<int, int>(i,dictionary[required]);

            if(!dictionary.ContainsKey(value))
                dictionary.Add(value, i);
        }

        return null;
    }

    public static void Main(string[] args)
    {
        Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
        if (indices != null)
        {
            Console.WriteLine(indices.Item1 + " " + indices.Item2);
        }
    }
}