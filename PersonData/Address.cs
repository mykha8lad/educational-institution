using ExceptionLibrary;
using System;

namespace EducationInstitution.PersonData;

public class Address
{
    string _city;
    string _street;
    string _homeNumber;

    public string City
    {
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) throw new StringException();
            _city = value;
        }
        get => _city;
    }
    public string Street
    {
        get => _street;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) throw new StringException();
            _street = value;
        }
    }
    public string HomeNumber
    {
        get => _homeNumber;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) throw new StringException();
            _homeNumber = value;
        }
    }

    public Address(string city, string street, string homeNumber)
    {
        City = city;
        Street = street;
        HomeNumber = homeNumber;
    }

    public override string ToString()
    {
        return $"{City}, {Street} {HomeNumber}";
    }
}
