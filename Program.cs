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
        #region delegate
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
        #endregion

        #region events       
        Student studentEvents = new Student("Vladislav", "Mykhailichenko", "Sergeevich");
        Console.WriteLine("\n" + studentEvents);

        studentEvents.Overslept += (sender, e) =>
        {
            Console.WriteLine("Teacher: Why are you late?");
            Console.WriteLine("Student: I overslept...");
        };

        studentEvents.GotMachineGun += (sender, e) =>
        {
            Console.WriteLine("Police: Put down your weapon!");
            Console.WriteLine("Student: I'm just joking, it's a toy gun...");
        };

        studentEvents.PassedExamOn12 += (sender, e) =>
        {
            Console.WriteLine("Parent: Congratulations on your excellent grade!");
            Console.WriteLine("Student: Thanks, but it was just luck...");
        };

        Console.WriteLine("Something happens to the student...");
        studentEvents.SleepIn();
        Console.WriteLine();

        Console.WriteLine("Something else happens to the student...");
        studentEvents.GetWeapon();
        Console.WriteLine();

        Console.WriteLine("Yet another thing happens to the student...");
        studentEvents.PassExam();
        Console.WriteLine();
        #endregion
    }

    static void SortStudents(List<Student> students, Comparison<Student> comparison)
    {
        students.Sort(comparison);
    }

    static int RateCriteria(Student a, Student b) => b.GetAverageMark().CompareTo(a.GetAverageMark());
}