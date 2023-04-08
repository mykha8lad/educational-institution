using ExceptionLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EducationInstitution.PersonData;

public class Person
{
    string _name;
    string _lastname;
    string _surname;
    string _phoneNumber;
    DateTime _birthday;
    Address _address;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) throw new StringException();
            _name = value;
        }
    }
    public string Lastname
    {
        get => _lastname;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) throw new StringException();
            _lastname = value;
        }
    }
    public string Surname
    {
        get => _surname;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) throw new StringException();
            _surname = value;
        }
    }
    public string PhoneNumber
    {
        get => _phoneNumber;
        set
        {
            string phoneRegexp = @"^\(\d{3}\)\d{3}\-\d{4}$";
            _phoneNumber = Regex.IsMatch(value, phoneRegexp) ? value : _phoneNumber = "(000)000-0000";
        }
    }
    public DateTime Birthday
    {
        get => _birthday;
        set => _birthday = value;
    }
    public Address Address
    {
        get => _address;
        set => _address = value;
    }

    public Person(string name, string lastname, string surname, DateTime birthday, string phoneNumber, string city, string street, string homeNumber)
        : base()
    {
        Name = name;
        Lastname = lastname;
        Surname = surname;
        PhoneNumber = phoneNumber;
        Birthday = birthday;
        Address = new(city, street, homeNumber);
    }
    public Person(string name, string lastname, string surname, DateTime birthday, string phoneNumber) :
        this(name, lastname, surname, birthday, phoneNumber, "None", "None", "None")
    { }
    public Person(string name, string lastname, string surname) :
        this(name, lastname, surname, new DateTime(1, 1, 1), "(000)000-0000", "None", "None", "None")
    { }
    public Person() :
        this("None", "None", "None", new DateTime(1, 1, 1), "(000)000-0000", "None", "None", "None")
    { }

    public override string ToString()
    {
        return $"Person: {Lastname} {Name} {Surname}\n" +
            $"Birthday: {Birthday.Date.ToString("d")}\n" +
            $"Address: {Address}\n" +
            $"Phone number: {PhoneNumber}\n";
    }
}
