using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;

namespace ListDictionary
{ 
    class StringCollections
    {
        static void Main()
        {
            StringCollection sl = new StringCollection();
            sl.Add("apples");
            sl.Add("banana");
            sl.Add("oranges");
            sl.Add("kiwi");
            sl.Add("Guvva");
            sl.Add("grapes");
            StringEnumerator sd = sl.GetEnumerator();
            while (sd.MoveNext())
            {
                Console.WriteLine(sd.Current);
            }
            Console.WriteLine("count is:{0}", sl.Count);
            Console.WriteLine("-----------------------using count property--------------");
            Console.WriteLine("count is: {0}", sl.Count);
            Console.WriteLine("Is synchrozied or not :{0}", sl.IsSynchronized);

            Console.WriteLine("list is readonly property ?:{0}", sl.IsReadOnly);
            Console.WriteLine("-----------------------using Remove method-----------------");
            String[] myArr1 = new String[] { "A", "B", "C", "D", "E" };
            //Console.WriteLine(  "Range:{0}", sl.AddRange(myArr1)); 
            sl.Remove("apples");
            Console.WriteLine("After removing---------------");
            foreach (var v in sl)
            {
                Console.WriteLine(v);
            }
            String[] myArr = new String[] { "A", "B", "C", "D", "E" };


            sl.AddRange(myArr);


            foreach (Object obj in sl)
            {
                Console.WriteLine("{0}", obj);
            }
        }
    }
}