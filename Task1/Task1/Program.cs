using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student ITStu1 = new ITStudent(79, 56, 48);
            Student ITStu2 = new ITStudent(86, 12, 63);
            Student ITStu3 = new ITStudent(54, 0, 25);
            Student ITStu4 = new ITStudent(23, 79, 99);
            Student ITStu5 = new ITStudent(19, 74, 87);
            Student BusStu1 = new BusinessStudent(50, 46, 35);
            Student BusStu2 = new BusinessStudent(100, 78, 44);
            Student BusStu3 = new BusinessStudent(79, 38, 36);
            Student BusStu4 = new BusinessStudent(13, 100, 100);
            Student BusStu5 = new BusinessStudent(100, 100, 100);
            List<Student> list = new List<Student>
            {
                ITStu1, ITStu2, ITStu3, ITStu4, ITStu5, BusStu1, BusStu2, BusStu3, BusStu4, BusStu5
            };
            Console.WriteLine("--- IT Students' Sum of Grades ---\n");
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine(list[i].SumOfGrades());
            //}
            //for (int i = 6; i < 11; i++)
            //{
            //    Console.WriteLine(list[i].HighestGrade());
            //}
            foreach(Student x in list)
            {
                if(x.GetType().ToString() == "Task1.ITStudent")
                    Console.WriteLine("-- Sum of Grades ---");
                    Console.WriteLine(x.SumOfGrades());
                if (x.GetType().ToString() == "Task1.BusinessStudent")
                    Console.WriteLine("--- Highest Grade ---");
                    Console.WriteLine(x.HighestGrade());
            }
        }
    }
}
