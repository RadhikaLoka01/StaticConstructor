using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class Student
    {
        int Sid;
        string Sname;
        int Rollno;
        static string Schoolname;
        static string Schoolarea;
        static Student()
        {

            Schoolname = "Magneq Software";
            Schoolarea = "Ameerpet";
        }
        internal Student(int Sid, string Sname, int Rollno)
        {
            this.Sid = Sid;
            this.Sname = Sname;
            this.Rollno = Rollno;
        }
        internal void studentdisplay()
        {
            Console.WriteLine("student sid {0}",Sid);
            Console.WriteLine("student  sname {0}", Sname);
            Console.WriteLine("student studentroll :{0}", Rollno);
            Console.WriteLine("student school name :{0}",  Schoolname);
            Console.WriteLine("student school area :{0}",  Schoolarea);
        }
         static void Main(string[] args)
        {

            Student obj = new Student(101,"Radha",20000);
            obj.studentdisplay();
            Console.WriteLine();
            Student ms = new Student(102, "siri", 30000);
            ms.studentdisplay();
            Console.ReadLine();
        }
    }
}
