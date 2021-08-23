using System;
using System.Collections.Generic;

namespace CollectionInterfacesDemo
{
    class IComparerDemo
    {
        static void Main()
        {
            List<Display> displays = new List<Display>()
            {
                new Display{PPI=250,Resolution="1120*1200",Size="14*12" },
                new Display{PPI=225,Resolution="900*1100",Size="12*11" },
                new Display{PPI=240,Resolution="950*1000",Size="10*11" }

            };

            SortDisplay sorted = new SortDisplay();
            displays.Sort(sorted);

            foreach(var display in displays)
            {
                Console.WriteLine("PPI={0}\tResolution={1}\tSize={2}",display.PPI,display.Resolution,display.Size);
            }
            Console.ReadLine();
        }
    }
}
