using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace HashTables_Demos
{
    public static class EmployeeHashTable
    {

        public static void EmployeeHash()
        {
            Hashtable countires = new Hashtable() { { 1, "Usa" }, { 2, "Russia" }, { 3, "India" }, { 4, "Turkey" }, { 5, "Jordhan" }, { 6, "Iraq" }, { 7, "iran" }, { 8, null } };

            foreach (DictionaryEntry item in countires)
            {
                Console.WriteLine("key {0} Value {1}", item.Key, item.Value);
            }

            // to insert
            //what if you insert duplicate values - it will except
            // what is you add duplicate keys

            //countires.Add();;

            Console.WriteLine();
            // To delete
            countires.Remove(8);
            Console.WriteLine("removed element with .remove");
            foreach (DictionaryEntry item in countires)
            {
                Console.WriteLine("key {0} Value {1}", item.Key, item.Value);
            }

            Console.WriteLine();
            Console.WriteLine("search or look up with contains or containsKey or containsValue");
            //To Search / look up
            var result = countires.Contains(1);
            Console.WriteLine(result);

            if (countires.ContainsKey(3))
                if (countires.ContainsValue("India"))
                    Console.WriteLine("3 key and value india is there");



        }
    }
}
