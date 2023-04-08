using System;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using EducationInstitution.Students;

namespace EducationInstitution;

internal class Program
{
    static void Main(string[] args)
    {
        #region students list sort
        List<Student> students = new List<Student>();

        students.Add(new("Crona", "Fred", "Giovanni"));
        students.Add(new("Batz", "Arnoldo", "Ransom"));
        students.Add(new("Beier", "Natalia", "Tyrel"));
        students.Add(new("Ernser", "Ezra", "Finn"));
        students.Add(new("Goldner", "Ada", "Deontae"));

        students.Sort();

        foreach (Student student in students)
        {
            Console.WriteLine($"Student {student.Name} - {student.GetAverageMark()}");
        }
        #endregion

        #region use static function for comparison students
        StudentComparison(students);
        #endregion
    }

    static void StudentComparison(List<Student> students)
    {
        int student1 = 0;
        for (int student2 = 1; student2 < students.Count; student2++, student1++)
        {
            if (students[student2].CompareTo(students[student1]) > 0) { Console.WriteLine($"Student {students[student2].Name} performs better than student {students[student1].Name} ({students[student2].GetAverageMark()} > {students[student1].GetAverageMark()})"); }
            if (students[student2].CompareTo(students[student1]) < 0) { Console.WriteLine($"Student {students[student1].Name} performs better than student {students[student2].Name} ({students[student2].GetAverageMark()} < {students[student1].GetAverageMark()})"); }
            if (students[student2].CompareTo(students[student1]) == 0) { Console.WriteLine($"Student {students[student2].Name} with the same academic performance as student {students[student1].Name} ({students[student2].GetAverageMark()} = {students[student1].GetAverageMark()})"); }
        }
    }
}