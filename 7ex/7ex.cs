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
            string nl = "";
            nl += all[0] + " " + all[1];
            List<int> temp = new();
            for (int i = 2; i != all.Length; i++)
            {
                temp.Add(int.Parse(all[i]));
            }
            lydi.Add(nl, temp);
        }

        var compL = (List<int> temp) =>
        {
            foreach(int a in temp)
            {
                if (a == 6)
                {
                    return 1;
                }
            }   

            return 0;
        };

        var selectedPeople = from p in lydi
                             where compL(p.Value) == 1
                             select p;

        foreach (var person in selectedPeople)
            Console.WriteLine(person.Key);
    }
}


