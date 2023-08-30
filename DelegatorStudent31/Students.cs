using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatorStudent31
{
    internal class Students
    {
        private List<Student> students = new List<Student>();
        public delegate void PrintProcess(Student student);

        public void Add(Student student)
        {
            students.Add(student);
        }

        public void Print(PrintProcess process) {
            students.ForEach((student) => process(student));
            //foreach (Student student in students)
            //{
            //    process(student);
            //}
        }

        public void Print()
        {
            Print((student) => Console.WriteLine(student));
        }
    }
}
