using ExceptionLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationInstitution.Students;

public class Aspirant : Student
{
    string _dissertationTopic;

    public string DissertationTopic
    {
        get => _dissertationTopic;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) throw new StringException();
            _dissertationTopic = value;
        }
    }

    public Aspirant(string name, string lastname, string surname, DateTime birthday, string phoneNumber, string city, string street, string homeNumber, string dissertationTopic)
        : base(name, lastname, surname, birthday, phoneNumber, city, street, homeNumber)
    {
        DissertationTopic = dissertationTopic;
    }
    public Aspirant(string name, string lastname, string surname, DateTime birthday, string phoneNumber, string dissertationTopic) :
        this(name, lastname, surname, birthday, phoneNumber, "None", "None", "None", dissertationTopic)
    { }
    public Aspirant(string name, string lastname, string surname, string dissertationTopic) :
        this(name, lastname, surname, new DateTime(1, 1, 1), "(000)000-0000", "None", "None", "None", dissertationTopic)
    { }
    public Aspirant() :
        this("None", "None", "None", new DateTime(1, 1, 1), "(000)000-0000", "None", "None", "None", "C# (Default Disertation Topic)")
    { }

    public override string ToString()
    {
        return $"ID: {Id}\n" +
            $"Aspirant: {Lastname} {Name} {Surname}\n" +
            $"Birthday: {Birthday.Date.ToString("d")}\n" +
            $"Address: {Address}\n" +
            $"Phone number: {PhoneNumber}\n" +
            $"Rating\n" +
            $"Scores offsets - {GetListOffsetsForToString()}\n" +
            $"Scores hometasks - {GetListHometasksForToString()}\n" +
            $"Scores exams - {GetListExamsForToString()}\n" +
            $"Average score: {GetAverageMark()}\n" +
            $"Topic dissertation: {DissertationTopic}\n";
    }
}
