using System;
using System.Collections.Generic;
using System.Linq;
internal class Program
{
    static void Main()
    {
        Dictionary<string, List<int>> lydi = new Dictionary<string, List<int>>();
        while (true)
        {
            string[] all = Console.ReadLine().Split();

            if (all[0] == "End")
            {
                break;
            }
            List<int> temp = new();
            for (int i = 1; i != all.Length; i++)
            {
                temp.Add(int.Parse(all[i]));
            }
            lydi.Add(all[0], temp);
        }

        var selectedPeople = from p in lydi
                             where p.Key.EndsWith("14") || p.Key.EndsWith("15")
                             select p;

        foreach (var person in selectedPeople)
        {
            foreach (int n in person.Value)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}


