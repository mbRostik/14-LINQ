using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string Name { get; set; }

    public string Id { get; set; }


}
internal class Program
{
    static void Main()
    {
        List<Person> list = new List<Person>();

        while(true)
        {
            string[] all = Console.ReadLine().Split();
            if (all[0] == "End")
            {
                break;
            }
            Person temp= new Person();
            temp.Name = all[0] + " " + all[1];
            temp.Id = all[2];

            list.Add(temp);
        }



        var groupedCustomerList = list
         .GroupBy(u => u.Id)
         .Select(grp => grp.ToList())
         .ToList();

        foreach (List<Person> group in groupedCustomerList)
        {
            string numb="";
            foreach(Person person in group)
            {
                numb = person.Id;
                Console.Write(person.Name+" ");
            }
            Console.Write(" - "+numb);
            Console.WriteLine();
        }
    }
}

