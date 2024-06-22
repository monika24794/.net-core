using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementLib
{
    public class phoneBookUsingHashtable
    { 
        Hashtable ht = new Hashtable ();
        public void populataeEntries () 
        {
            ht.Add (123654, "monika");
            ht.Add(9875643, "chetana");
            ht.Add(478987, "aditya");
            ht.Add(485987, "ananya");
            ht.Add(423687, "bhina");

            foreach(DictionaryEntry entry in ht)
            {
                Console.WriteLine(entry.Key+ " "+entry.Value);
            }
        }
        public void AddData(int key, string value)
        {
            ht.Add(key, value);
        }
        public void Display() {

            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }
        }
        public string Findname(int key)
        {
            string name = (string)ht[key];
            return name;

        }
    }
}
