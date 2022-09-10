using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        IDictionary<ComposedKey, char> dictionary = new SortedDictionary<ComposedKey, char>(new KeyComparer());

        dictionary.Add(new ComposedKey("a", "4"), 'E');
        dictionary.Add(new ComposedKey("a", "2"), 'C');
        dictionary.Add(new ComposedKey("b", "2"), 'B');
        dictionary.Add(new ComposedKey("c", "1"), 'A');
        dictionary.Add(new ComposedKey("a", "0"), 'D');

        foreach (KeyValuePair<ComposedKey, char> pair in dictionary)
            Console.WriteLine(pair.Key + " " + pair.Value);
    }
}