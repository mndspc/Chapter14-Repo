using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInterfacesDemo
{
    class SmartPhone:IComparable<SmartPhone>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        //  1: swap
        //  0: retain
        // -1: don't swap
    
        public int CompareTo(SmartPhone other)
        {
         
            if (other != null)
            {
                return this.Price.CompareTo(other.Price);
            }
            else
            {
                throw new ArgumentException("Object doesn't have price");
            }
        }
    }

   
}
