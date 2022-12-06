using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string Name { get; set; }

    public string Id { get; set; }


}

class Faculty
{
    public string Name { get; set; }

    public string Id { get; set; }


}


internal class Program
{
    static void Main()
    {

        List<Person> listP = new List<Person>();
        List<Faculty> listF = new List<Faculty>();

        while (true)
        {
            string[] all = Console.ReadLine().Split();
            if (all[0] == "End")
            {
                break;
            }
            Faculty temp = new Faculty();
            temp.Name = all[0] + " " + all[1];
            temp.Id = all[2];

            listF.Add(temp);
        }

        while (true)
        {
            string[] all = Console.ReadLine().Split();
            if (all[0] == "End")
            {
                break;
            }
            Person temp = new Person();
            temp.Name = all[1] + " " + all[2];
            temp.Id = all[0];

            listP.Add(temp);
        }


        var query =
          from person in listP
          join faculty in listF on person.Id equals faculty.Id 
          orderby person.Name
          select new
          {
             pname = person.Name, fname =faculty.Name, fnumb= faculty.Id
          };

       foreach(var smth in query)
        {
            Console.WriteLine(smth.pname + " "+ smth.fname + " "+ smth.fnumb);
        }
    }
}

