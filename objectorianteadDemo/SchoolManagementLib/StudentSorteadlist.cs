using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementLib
{
    public class StudentSorteadlist
    {
        SortedList list = new SortedList();
        public StudentSorteadlist()
        {

            list.Add(1, "anita");
            list.Add(2, "vanita");
            list.Add(13, "sanita");
            list.Add(4, "pranita");
            list.Add(5, "banita");
        }
        public void AddStudent(int k, string v)
        {
            list.Add(k, v); 
        }
        public void display()
        {
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }

    }
}
