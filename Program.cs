using System;
using System.IO;
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
        #region write data in file        
        Group group = new();

        using (StreamWriter writer = new StreamWriter(@"D:\c#-projects\EducationInstitution\EducationInstitution\StudentsData.txt"))
        {
            foreach (Student student in group)
            {
                writer.WriteLine("{0}, {1}, {2}, {3}", student.Name, student.Birthday, student.Address, student.PhoneNumber);
            }
        }

        Console.WriteLine("Data written to file.");
        #endregion
    }
}