using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography;

namespace AD.Collecction
{
    public class BucketHash
    {
        public static void bucket()
        {
            Dictionary<int, Object> dict = new Dictionary<int, Object>();

            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");
            dict.Add(4, "three");
            dict.Add(5, "five");

            Hashtable ht = new Hashtable(dict);
            //Displaying the key and value
            Console.WriteLine("");
            Console.WriteLine("Displaying all Key and values");
            foreach (DictionaryEntry items in ht)
                Console.WriteLine("key:{0}, value:{1}", items.Key, items.Value);
            //Showing all the values in the bucket
            Console.WriteLine("");
            Console.WriteLine("All Values");
            foreach (var values in ht.Values)
            Console.WriteLine("Value:{0}", values);
            //Removing a item from the bucket list
            Console.WriteLine("");
            Console.WriteLine("Remove 2 from the bucket hash");
            ht.Remove(2);
            foreach (DictionaryEntry items in ht)
                Console.WriteLine("key:{0}, value:{1}", items.Key, items.Value);
        }
    }
}
