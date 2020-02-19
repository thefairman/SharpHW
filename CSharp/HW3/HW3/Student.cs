using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    enum Subjects { Programming, Administration, Design }
    class Group
    {
        public string Name { get; set; }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Group Group { get; set; }
        public DateTime DateBirth { get; set; }
        // если можно придумать логику корректной работы с массивом оценок с использованием зубчатого массива, хотелось бы посмотреть
        int[][] assessments;
        public Student()
        {
            FirstName = MiddleName = LastName = "";
            assessments = new int[Enum.GetNames(typeof(Subjects)).Length][];
        }
        public void AddAssessment(Subjects subjects, int assessment)
        {
            if (assessments[(int)subjects] == null)
            {
                assessments[(int)subjects] = new int[] { assessment };
                return;
            }
            int[] newAssessments = new int[assessments[(int)subjects].Length + 1];
            assessments[(int)subjects].CopyTo(newAssessments, 0);
            newAssessments[assessments[(int)subjects].Length] = assessment;
            assessments[(int)subjects] = newAssessments;
        }
        public int[] GetAssessment(Subjects subjects)
        {
            return assessments[(int)subjects] ?? new int[0];
        }
        public double GetAvgAssessment(Subjects subjects)
        {
            if (assessments[(int)subjects] == null)
                return 0d;
            return assessments[(int)subjects].Average();
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{LastName ?? ""} {FirstName ?? ""} {MiddleName ?? ""}");
            Console.WriteLine($"Состоит в группе: {Group?.Name ?? "Не определено!"}");

            int subjectsCount = Enum.GetNames(typeof(Subjects)).Length;
            for (int i = 0; i < subjectsCount; i++)
            {
                Console.Write($"Оценок по предмету \"{((Subjects)i).ToString()}\": {GetAssessment((Subjects)i).Length}. ");
                Console.WriteLine($"Средняя оценко по предмету \"{((Subjects)i).ToString()}\": {GetAvgAssessment((Subjects)i)}");
            }
            
        }
    }
}
