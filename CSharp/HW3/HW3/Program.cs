using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.PrintInfo();
            Console.ReadKey();
            Console.Clear();
            student = new Student() 
            { 
                DateBirth = DateTime.Now.AddYears(-29),
                FirstName = "Даниил",
                LastName = "Мельников",
                MiddleName = "Викторович",
                Group = new Group() { Name = "ВПО19-2" }
            };
            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 4; i < 10; i++)
            {
                if (random.Next(0,10) > 3)
                    student.AddAssessment(Subjects.Design, i);
                if (random.Next(0, 10) > 3)
                    student.AddAssessment(Subjects.Administration, i + 1);
                if (random.Next(0, 10) > 3)
                    student.AddAssessment(Subjects.Programming, i + 2);
            }
            student.PrintInfo();
            Console.ReadKey();
        }
    }
}
