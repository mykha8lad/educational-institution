using System;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Xml;
using EducationInstitution.Students;
using EducationInstitution.WaysComparer;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EducationInstitution;

internal class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>
        {
            new Student(),
            new Student(),
            new Student(),
            new Student(),
            new Student(),
            new Student(),
            new Student(),
            new Student(),
            new Student(),
            new Student(),
            new Student(),
            new Student(),
            new Student()
        };
        
        Console.WriteLine("Unsorted:");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name} - {student.GetAverageMark()}");
        }

        SortStudents(students, RateCriteria);
        Console.WriteLine();

        Console.WriteLine("Sorted:");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name} - {student.GetAverageMark()}");
        }
    }

    static void SortStudents(List<Student> students, Comparison<Student> comparison)
    {
        students.Sort(comparison);
    }

    static int RateCriteria(Student a, Student b) => b.GetAverageMark().CompareTo(a.GetAverageMark());    
}