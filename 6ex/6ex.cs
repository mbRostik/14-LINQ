using System;
using System.Collections.Generic;
using System.Linq;
internal class Program
{
    static void Main()
    {
        Dictionary<string, string> lydi = new Dictionary<string, string>();
        while (true)
        {
            string[] all = Console.ReadLine().Split();

            if (all[0] == "End")
            {
                break;
            }
            lydi.Add(all[0] + " " + all[1], all[2]);
        }

        var selectedPeople = from p in lydi
                             where p.Value.StartsWith("+3592") || p.Value.StartsWith("02")
                             select p;

        foreach (var person in selectedPeople)
            Console.WriteLine(person.Key);
    }
}

