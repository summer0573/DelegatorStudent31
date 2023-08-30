using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatorStudent31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();
            students.Add(new Student("정현진", 2.0));
            students.Add(new Student("김자하", 5.0));
            students.Add(new Student("백설영", 4.0));
            students.Add(new Student("백언", 2.0));
            students.Add(new Student("화운", 2.0));

            students.Print();
            students.Print((student) =>
            {
                Console.WriteLine("--------------");
                Console.WriteLine("이름 : " + student.Name);
                Console.WriteLine("점수 : " + student.Score);
            });

            Console.WriteLine("<students>");
            students.Print((student) =>
            {
                Console.WriteLine("<student>");
                Console.WriteLine("<name>" + student.Name + "</name>");
                Console.WriteLine("<score>" + student.Score + "</score>");
                Console.WriteLine("</student>");
            });
            Console.WriteLine("</students>");
        }
    }
}
