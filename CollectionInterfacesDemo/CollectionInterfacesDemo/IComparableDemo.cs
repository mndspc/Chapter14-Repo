using System;
using System.Collections.Generic;

namespace CollectionInterfacesDemo
{
    class IComparableDemo
    {
        static void Main()
        {
            //List<int> intList = new List<int>() {12,3,14,2,1,7,8,9 };
            //intList.Sort();
            //foreach(var i in intList)
            //{
            //    Console.WriteLine(i);
            //}
            List<SmartPhone> smartPhones = new List<SmartPhone> {
                new SmartPhone{Name="One Plus",Price=30000 },
                new SmartPhone{ Name="MI",Price=20000},
                new SmartPhone{Name="SAMSUNG",Price=25000 }
            };
            smartPhones.Sort();
            foreach(var smartphone in smartPhones)
            {
                Console.WriteLine("Name={0} Price={1}",smartphone.Name,smartphone.Price);
            }
            Console.ReadLine();
        }
    }
}
