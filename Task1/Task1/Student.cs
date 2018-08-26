using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Student
    {
        public int Grade1 { get; set; }
        public int Grade2 { get; set; }
        public int Grade3 { get; set; }
        public virtual int SumOfGrades()
        {
            return Grade1 + Grade2 + Grade3;
        }
        public virtual int HighestGrade()
        {
            if (Grade1 > Grade2 && Grade1 > Grade3)
            {
                return Grade1;
            }
            else if (Grade2 > Grade1 && Grade2 > Grade3)
            {
                return Grade2;
            }
            else
            {
                return Grade3;
            }
        }
    }
    class ITStudent:Student
    {

        public override int SumOfGrades()
        {
            return base.SumOfGrades() / 3;
        }
        public ITStudent(int _grade1, int _grade2, int _grade3) 
        {
            Grade1 = _grade1;
            Grade2 = _grade2;
            Grade3 = _grade3;
        }
    }
    class BusinessStudent:Student
    {
        public override int HighestGrade()
        {
            if(Grade1 > Grade2 && Grade1 > Grade3)
            {
                return Grade1;
            }
            else if(Grade2 > Grade1 && Grade2 > Grade3)
            {
                return Grade2;
            }
            else
            {
                return Grade3;
            }
        }
        public BusinessStudent(int _grade1, int _grade2, int _grade3)
        {
            Grade1 = _grade1;
            Grade2 = _grade2;
            Grade3 = _grade3;
        }
    }
}
