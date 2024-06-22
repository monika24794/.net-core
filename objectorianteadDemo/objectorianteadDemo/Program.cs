using System.Collections;
using SchoolManagementLib;
namespace objectorianteadDemo
{
    public class Program
    {
        //public void M1(object o2, int i)
        //{


        //}
        //public void M2(dynamic o2, int i) { }
        private static void Main(string[] args)
        {
       
            int userchoice;


            // WorkingWithHashtable();
            // WorkingWithArray();

            StudentOperation operation = new StudentOperation();
            do
            {
                Console.WriteLine("1.add\n 2.edit\n3.get all student\n4.delete\n5.exit ");
                 userchoice = Convert.ToInt32(Console.ReadLine());

                switch (userchoice)
                {
                    case 1:
                        Student s = new Student();
                        Console.WriteLine("enter roll no");
                        s.rollno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter name");
                        s.Studentname = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("enter city");
                        s.city = Convert.ToString(Console.ReadLine());
                        operation.AddStudent(s);
                        break;

                    case 2:
                        operation = new StudentOperation();
                        Console.WriteLine();
                        break;
                    case 3:
                        Student[] students = new Student[3];
                        students = operation.GetStudents();
                        foreach (Student student in students)
                        {
                            Console.WriteLine(student.rollno);
                            Console.WriteLine(student.Studentname);
                            Console.WriteLine(student.city);
                        }

                        break;
                    case 4:
                        operation = new StudentOperation();
                        Console.WriteLine();
                        break;
                    case 5:
                        Environment.ExitCode = 0;
                        break;

                    default:
                        Console.WriteLine();

                        break;
                }
        
            }
            while (userchoice!=5);
        }
 
        //    stack s = new stack(); 
        //    s.push(1);
        //    s.push(2.23f);
        //    s.push(3256);

        //    foreach (var item in s)
        //    {
        //        console.writeline(item);
        //    }
        //    s.pop();
        //    s.peek();
        //    s.contains(2);
        //   // array myarry=array.createinstance(typeof(object), 10);

        //    object[] myarray =new object[5];
        //    s.copyto(myarray, 0);
        //    object[] myarray2 = new object[s.count];
        //    myarray2 = s.toarray();
        //    //Stack <int> stack = new Stack<int>();


        //private static void WorkingWithArray()
        //{
        //    object o = 56;
        //    object obj = o;

        //    //var v1 = 'j';

        //    //dynamic o2 = obj;
        //    int i = 10;
        //    obj = i; //boxing
        //    Type t = obj.GetType();
        //    Console.WriteLine(t);


        //    //float g = 23.4f;
        //    //object obj2 = g;

        //    //float f = (float) obj2;//unboxing
        //    //Console.WriteLine(f);
        //    //Console.WriteLine(f.GetType());



        //    int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


        //    Array.Sort(arr);
        //    Array.Reverse(arr);
        //    foreach (var item in arr)
        //    {
        //        Console.WriteLine(item);
        //    }



        //    int[] arr2 = new int[5] { 1, 2, 3, 4, 5, };
        //    int[] arr3 = new int[5];
        //    arr[0] = 2;
        //    arr[1] = 3;
        //    arr[2] = 4;
        //    arr[3] = 5;
        //    arr[4] = 6;


        //    Array typeadArray = Array.CreateInstance(typeof(int), 5);
        //    typeadArray.SetValue(101, 0);
        //    typeadArray.SetValue(102, 1);
        //    typeadArray.SetValue(103, 2);
        //    typeadArray.SetValue(104, 3);
        //    typeadArray.SetValue(105, 4);
    }

    //private static void WorkingWithHashtable()
    //{
    //    Hashtable ht = new Hashtable();
    //    ht.Add(1, "A");
    //    ht.Add("1", "A");
    //    ht.Add(3, "d");
    //    ht.Add(2, "B");
    //    ht.Add("3", "C");
    //    ht.Add(4, "D");
    //    ht.Add(5, "E");

    //    IDictionaryEnumerator ie = ht.GetEnumerator();
    //    while (ie.MoveNext())
    //    {
    //        Console.WriteLine(ie.Key + "  " + ie.Value);
    //    }

    //    Console.WriteLine("-----------------");
    //    String name = (String)ht[5];
    //    Console.WriteLine(name);
    //}
}


