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
        Student student = new Student();
        Console.WriteLine(student);

        student.Overslept += (sender, e) => {
            Console.WriteLine("Teacher: Why are you late?");
            Console.WriteLine("Student: I overslept...");
        };

        student.GotMachineGun += (sender, e) => {
            Console.WriteLine("Police: Put down your weapon!");
            Console.WriteLine("Student: I'm just joking, it's a toy gun...");
        };

        student.PassedExamOn12 += (sender, e) => {
            Console.WriteLine("Parent: Congratulations on your excellent grade!");
            Console.WriteLine("Student: Thanks, but it was just luck...");
        };

        Console.WriteLine("Something happens to the student...");
        student.SleepIn();
        Console.WriteLine();

        Console.WriteLine("Something else happens to the student...");
        student.GetWeapon();
        Console.WriteLine();

        Console.WriteLine("Yet another thing happens to the student...");
        student.PassExam();
        Console.WriteLine();
    }   
}