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

        var subtract = (Person x, Person y) =>
        {
            if (x.LastName.CompareTo(y.LastName) == -1) { return x - y; }
            else return y - x;
        };

        while (true)
        {
            string[] all = Console.ReadLine().Split();

            if (all[0] == "End")
            {
                break;
            }
            Person temp = new Person();
            temp.Name= all[0];
            temp.LastName = all[1];
            lydi.Add(temp);
        }

        var selectedPeople = from p in lydi
                             where p.LastName.CompareTo(p.)
                             select p;

        foreach (var person in selectedPeople)
            Console.WriteLine(person.Key + " " + person.Value);
    }
}

