using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Use Dictionary as a map.
        var map = new Dictionary<int, char>();

        if (map.Count == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine("not empty");
        }

        // ... Add some keys and values.
        map.Add(97, 'a');
        map.Add(98, 'b');
        map.Add(99, 'c');
        map.Add(65, 'A');
        map.Add(66, 'B');
        map.Add(67, 'C');

        foreach (int key in map.Keys)
        {
            Console.WriteLine(key);
        }
        // Print all the values
        foreach (char value in map.Values)
        {
            Console.WriteLine(value);
        }
        
        // Add value D with the key 68
        map.Add(68, 'D');
        
        // Print how many key-value pairs are in the map
        Console.WriteLine(map.Count);
        
        // Print the value that is associated with key 99
        char letter;
        map.TryGetValue(99, out letter);
        Console.WriteLine(letter);
        
        // Remove the key - value pair with key 97
        map.Remove(97);
        
        // Print whether there is an associated value with key 100 or not

        if (map.ContainsKey(100))
        {
            Console.WriteLine("present");
        }
        else
        {
            Console.WriteLine("Key 100 doesnt exist = has no value");
        }

        // Remove all the key-value pairs
        map.Clear();
        foreach (var item in map)
        {
            Console.WriteLine(item);
        }
    }
}