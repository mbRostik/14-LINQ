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
            string temp="";
            for(int i = 0; i!=all.Length; i++)
            {
                try
                {
                    lydi.Add(temp, int.Parse(all[i]));
                    break;
                }
                catch (Exception)
                {
                    temp += all[i]+" ";
                }
            }
        }
        var selectedPeople = from p in lydi
                             where p.Value==2
                             orderby p.Key
                             select p;

        foreach (var person in selectedPeople)
            Console.WriteLine(person.Key);
    }
}
        
