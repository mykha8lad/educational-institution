using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using EducationInstitution.PersonData;
using ExceptionLibrary;

namespace EducationInstitution.Students;

public class Student : Person
{
    const int _numberOfSemesters = 7;

    int _id;
    public int Id
    {
        get => _id;
        set => _id = value;
    }

    List<int> _offsets = new List<int>();
    List<int> _hometasks = new List<int>();
    List<int> _exams = new List<int>();

    public List<int> Offsets
    {
        get => _offsets;
        set
        {
            if (value == null)
                throw new ArgumentException();
            _offsets = value;
        }
    }
    public List<int> Hometasks
    {
        get => _hometasks;
        set
        {
            if (value == null)
                throw new ArgumentException();
            _hometasks = value;
        }
    }
    public List<int> Exams
    {
        get => _exams;
        set
        {
            if (value == null)
                throw new ArgumentException();
            _exams = value;
        }
    }

    public Student(string name, string lastname, string surname, DateTime birthday, string phoneNumber, string city, string street, string homeNumber)
        : base(name, lastname, surname, birthday, phoneNumber, city, street, homeNumber)
    {
        SetId();
        FillingLists();
    }
    public Student(string name, string lastname, string surname, DateTime birthday, string phoneNumber) :
        this(name, lastname, surname, birthday, phoneNumber, "None", "None", "None")
    { }
    public Student(string name, string lastname, string surname) :
        this(name, lastname, surname, new DateTime(1, 1, 1), "(000)000-0000", "None", "None", "None")
    { }
    public Student() :
        this("None", "None", "None", new DateTime(1, 1, 1), "(000)000-0000", "None", "None", "None")
    { }

    /*public void GetSuccessfulStudent()
    {

    }*/    
    public double GetAverageMark()
    {
        double avgMark = 0;
        avgMark += Offsets.Average() + Hometasks.Average() + Exams.Average();

        return Math.Truncate(avgMark);
    }
    public void FillingLists()
    {
        for (int semester = 0; semester < _numberOfSemesters; ++semester)
        {
            Offsets.Add(new Random().Next(1, 13));
            Hometasks.Add(new Random().Next(1, 13));
            Exams.Add(new Random().Next(1, 13));
        }
    }

    void SetId() => Id = new Random().Next(357943, 8357235);

    // operator overloading
    public override int GetHashCode() => GetAverageMark().GetHashCode();
    public override bool Equals(object? obj)
    {
        Student? student = obj as Student;
        if (student == null || GetType() != student.GetType()) { throw new ArgumentException(); }

        return GetAverageMark() == student.GetAverageMark();
    }

    public static bool operator ==(Student firstStudent, Student secondStudent)
    {
        if (ReferenceEquals(firstStudent, secondStudent)) { return true; }

        if (ReferenceEquals(firstStudent, null) || ReferenceEquals(secondStudent, null)) { return false; }

        return firstStudent.GetAverageMark() == secondStudent.GetAverageMark();
    }
    public static bool operator !=(Student firstStudent, Student secondStudent) { return !(firstStudent == secondStudent); }

    public static bool operator >(Student firstStudent, Student secondStudent)
    {
        return firstStudent.GetAverageMark() > secondStudent.GetAverageMark();
    }
    public static bool operator <(Student firstStudent, Student secondStudent)
    {
        return firstStudent.GetAverageMark() > secondStudent.GetAverageMark();
    }

    public static bool operator >=(Student firstStudent, Student secondStudent)
    {
        return firstStudent.GetAverageMark() > secondStudent.GetAverageMark();
    }
    public static bool operator <=(Student firstStudent, Student secondStudent)
    {
        return firstStudent.GetAverageMark() > secondStudent.GetAverageMark();
    }
    // operator overloading

    // overloading CompareTo()
    /*public int CompareTo(object? obj)
    {
        Student? student = obj as Student;
        if (GetAverageMark() > student.GetAverageMark()) return 1;
        if (GetAverageMark() < student.GetAverageMark()) return -1;
        return 0;
    }*/

    public string GetListOffsetsForToString() { return string.Join(" ", Offsets); }
    public string GetListHometasksForToString() { return string.Join(" ", Hometasks); }
    public string GetListExamsForToString() { return string.Join(" ", Exams); }

    public override string ToString()
    {
        return $"ID: {Id}\n" +
            $"Student: {Lastname} {Name} {Surname}\n" +
            $"Birthday: {Birthday.Date.ToString("d")}\n" +
            $"Address: {Address}\n" +
            $"Phone number: {PhoneNumber}\n" +
            $"Rating\n" +
            $"Scores offsets - {GetListOffsetsForToString()}\n" +
            $"Scores hometasks - {GetListHometasksForToString()}\n" +
            $"Scores exams - {GetListExamsForToString()}\n" +
            $"Average score: {GetAverageMark()}\n";
    }
}