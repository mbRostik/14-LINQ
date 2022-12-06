using System;
using System.Collections.Generic;
using System.Linq;
internal class Program
{
    class Company
    {
        public string Name { get; set; }
        public string Product { get; set; }

        public int Amount { get; set; }

        public Company(string name, string product, int am)
        {
            Name = name;
            Product = product;
            Amount = am;
        }
    }
    static void Main()
    {
        
        List<Company> list = new List<Company>();

        while (true)
        {
            string[] all = Console.ReadLine().Split('<', '>', '-', ' ', '|');
            List<string> temp=new List<string>();

            if (all[0] == "End")
            {
                break;
            }
            foreach (string s in all)
            {
                if(s!=""&& s!=" ")
                {
                    temp.Add(s);
                }
            }
            list.Add(new Company(temp[0], temp[2], int.Parse(temp[1])));
        }

        var groupedCustomerList = list
        .GroupBy(u => u.Name)
        .Select(grp => grp.ToList())
        .ToList();

        foreach (List<Company> group in groupedCustomerList)
        {
            Console.Write(group[0].Name+" ");
            foreach(Company s in group)
            {
                Console.Write(s.Product+" "+s.Amount+"; ");
            }
            Console.WriteLine();
        }
    }
}

