using System;
using System.Collections.Generic;

using System.Linq;

namespace HashTables_Demos
{
    public static class ToRemoveDuplicateNumbers
    {
        public static void RemoveDuplicate(int[] arr)
        {

            // this will remove the duplicate from array and store in Hash Set;
            var h = new HashSet<int>(arr);


            
            var arr2 = h.ToArray();
            Console.WriteLine(string.Join(",", arr2));
        }
    }
}
