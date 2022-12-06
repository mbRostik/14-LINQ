using System;
using System.Collections.Generic;
using System.Linq;
internal class Program
{
    static void Main()
    {
        Dictionary<string, int> lydi = new Dictionary<string, int>();
        while (true)
        {
            string[] all = Console.ReadLine().Split();

            if (all[0] == "End")
            {
                break;
            }
            lydi.Add(all[0]+" " + all[1], int.Parse(all[2]));;
        }

        var selectedPeople = from p in lydi
                             where p.Value>=18 && p.Value<=24
                             select p;

        foreach (var person in selectedPeople)
            Console.WriteLine(person.Key + " "+person.Value);
    }
}

