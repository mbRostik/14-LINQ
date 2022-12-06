using System;
using System.Collections.Generic;
using System.Linq;
internal class Program
{
    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
    static void Main()
    {
        List<Person> lydi = new List<Person>();

        var compL = (Person x, Person y) =>
        {
            if (x.LastName.CompareTo(y.LastName) == 1) { return 1; }

            else if (x.LastName.CompareTo(y.LastName) == 0)
            {
                if (x.Name.CompareTo(y.Name) == 1) { return -1; }
                else { return 1; }
            }
            else return -1;
        };

        while (true)
        {
            string[] all = Console.ReadLine().Split();
            if (all[0] == "End")
            {
                break;
            }
            Person temp = new Person();
            temp.Name = all[0];
            temp.LastName = all[1];
            lydi.Add(temp);
        }

        for (int i = 0; i < lydi.Count - 1; i++)
        {
            for (int j = i + 1; j < lydi.Count; j++)
            {
                if (compL(lydi[i], lydi[j])==1)
                {
                    Person temp = lydi[i];
                    lydi[i] = lydi[j];
                    lydi[j] = temp;
                    j--;
                }
            }
        }
        foreach(Person temp in lydi)
        {
            Console.WriteLine(temp.Name+" "+temp.LastName);
        }
        
    }
}

