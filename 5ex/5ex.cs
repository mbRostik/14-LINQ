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
            lydi.Add(all[0]+" "+all[1], all[2]);
        }

        var compL = (string temp) =>
        {
            string[] all = temp.Split("@");

            if (all[1] == "gmail.com")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        };

        var selectedPeople = from p in lydi
                             where compL(p.Value) == 1
                             select p;

        foreach (var person in selectedPeople)
            Console.WriteLine(person.Key);
    }
}

