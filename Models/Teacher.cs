using System.Security.Cryptography.X509Certificates;

namespace WestCoastEducation.Models;

public class Teacher : Person
{
    public string? Course { get; set; }
    public string? AreaOfExpertise { get; set; }
    public int Number { get; set; }

    public Teacher (int number)
    {
        Number = number;
        Find();
    }

    public override void Find()
    {
        if (Number == 1)
        {
            InitializeTeacher("Petra", "Klause", "0408-334455", "19890908-2434", "Signalgatan 3", "454 77", "Stockholm", "Programming 1", "Programming");
        }
        else if (Number == 2)
        {
            InitializeTeacher("Thomas", "Frank", "0108-334455", "19790908-2434", "Storgatan 3", "458 77", "Stockholm", "DevOps", "System Development");
        }
        else if (Number == 3)
        {
            InitializeTeacher("Tommy", "Guth", "0488-334455", "19750908-2434","Davidgatan 3", "343 78", "Kiruna", "Database", "Data Analyse");
        }
        else
        {
            throw new ArgumentException($"Could not find teacher number: {Number}");
        }
    }

    private void InitializeTeacher(string name, string lastName, string phone, string idNumber, string addressLine, string postalCode, string city, string course, string areaOfExpertise)
    {
        Name = name;
        LastName = lastName;
        TelephoneNumber = phone;
        PersonalNumber = idNumber;
        Address.AddressLine = addressLine;
        Address.PostNumber = postalCode;
        Address.City = city;
        Course = course;
        AreaOfExpertise = areaOfExpertise;
    }
    public override string DisplayInfo()
    {
        return $"{base.DisplayInfo()}, Course: {Course}, Area of Expertise: {AreaOfExpertise}";
    }
}

