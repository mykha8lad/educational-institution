using System;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using EducationInstitution.Students;
using EducationInstitution.WaysComparer;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EducationInstitution;

internal class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        students.Add(new("Crona", "Fred", "Giovanni"));
        students.Add(new("Batz", "Arnoldo", "Ransom"));
        students.Add(new("Beier", "Natalia", "Tyrel"));
        students.Add(new("Ernser", "Ezra", "Finn"));
        students.Add(new("Goldner", "Ada", "Deontae"));

        Group group = new Group();

        #region using foreach for class object Group
        foreach (Student stud in group)
        {
            Console.WriteLine(stud);
        }
        #endregion

        #region sorting students by the arithmetic mean of grades
        students.Sort(new AverageMarkComparer());
        foreach (Student student in students)
        {
            Console.WriteLine($"Student {student.Lastname} - {student.GetAverageMark()}");
        }
        #endregion

        Console.WriteLine();

        #region sorting students by last name in alphabetical order
        students.Sort(new LastNameComparer());
        foreach (Student student in students)
        {
            Console.WriteLine($"Student {student.Lastname}");
        }
        #endregion
    }
}