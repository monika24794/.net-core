
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementLib
{
    public class StudentOperations
    {
        static List <Student> studentList = new List<Student> ();
        static StudentOperations()
        {
            studentList.Add(new Student(rno: 1, sname: "monika", city: "pune"));
            studentList.Add(new Student(2, "nashik", "kajal"));
            studentList.Add( new Student(3, "hima", "delhi"));

        }
        public void AddStudent(Student student)
        {
            //Student s = new Student(rno: student.rollno,sname:student.Studentname,city:student.city);
            //or
            Student s = new Student();
            studentList.Append(student);
            s.Studentname = student.Studentname;
            s.rollno = student.rollno;
            s.city = student.city;
            studentList.Add (s);
            //studentList.Append (s);
        }
        public void UpdateStudent(Student student)
        {
            stu
        }
        public void DeleteStudent(Student student)
        { 
            studentList.Remove (student);

        }

        public List <Student> GetStudents()
        {
            return studentList;

        }



    }
}
