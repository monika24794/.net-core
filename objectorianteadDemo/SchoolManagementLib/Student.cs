namespace SchoolManagementLib
{
    public class Student              
    {
       
        public int rollno { get; set; }
        public string Studentname { get; set; }
        public string city { get; set; }
        public Student()
        {
            
        }
        public Student(int rno, string sname, string city)
        {
            this.rollno = rno;
            this.Studentname = sname;
            this.city= city;
        }
    }
    
}
