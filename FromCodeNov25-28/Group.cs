using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromCodeNov25_28
{
    internal class Group
    {
        public string GroupNo { get; set; }
        string _no;
        public int Limit { get; set; }

        Student[] Students = new Student[0];

        //////public void AddStudent(Student student)
        //////{
        //////    if(Students.Length==Limit)
        //////    {
        //////        Console.WriteLine("Group doludur.");
        //////        return;
        //////    }
        //////}
        ///
        public bool AddStudent(Student student)
        {
            if(Students.Length < Limit)
            {
                Array.Resize(ref Students, Students.Length+1);
                Students[Students.Length-1] = student;
                return true;
            }
            return false;
        }

        public Student[] GetStudents()=>Students;

        public void GetStudents2(Student student)
        {
            foreach(Student item in Students)
            {
                Console.WriteLine(student.ToString());
            }
        }


    }
}
