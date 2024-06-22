using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementLib
{
    public class ArrayListdemo
    {
        ArrayList arrayList= new ArrayList(4);
 
        public ArrayListdemo()
        {
            arrayList.Add(134);
            arrayList.Add(123.56d);
            arrayList.Add(new DateTime(2024,12,23));
            arrayList.Add("hello");

        }

       
        public ArrayList GettheArrayList()
        {
             return arrayList; 
            
        }
        public void AddElement(object obj)
        {

           // arrayList.Add(obj);
           arrayList.Insert(4, obj);// specific location
            ArrayList a1 = new ArrayList(5);
            a1.Add(1);
            a1.Add(2);
            a1.Add(3);
            a1.Add(4);
            a1.Add(5);
          //  arrayList[4] = obj; adding in position
            arrayList.AddRange(a1); //adding another arraylistor collection
            arrayList.InsertRange(3,a1);
        }
    }
}
