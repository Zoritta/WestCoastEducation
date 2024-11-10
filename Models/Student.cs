namespace WestCoastEducation.Models;

public class Student : Person
{
     public int StudentNumber { get; private set; }

    public Student()
    {

    }
    public Student(int studentNumber)
    {
        StudentNumber = studentNumber;
        Find();
    }

    public override void Find()
    {
        if (StudentNumber == 1)
        {
            InitializeStudent("Tina", "Fiberg", "0739348889", "19720808-2878", "Gånggatan 22", "345 55", "Landskrona");
        }
        else if (StudentNumber == 2)
        {
            InitializeStudent("Louise", "Berg", "0769833078", "19680505-9622", "Kärlekgatan 54", "345 22", "Åstorp");
        }
        else if (StudentNumber == 3)
        {
            InitializeStudent("Sara", "Lindholm", "0703889966", "19880101-1206", "Solnagatan 78", "345 56", "Lund");
        }
        else
        {
            throw new ArgumentException($"Could not find student for: {StudentNumber}");
        }
    }

    private void InitializeStudent(string name, string lastName, string phone, string idNumber, string addressLine, string postalCode, string city)
    {
        Name = name;
        LastName = lastName;
        TelephoneNumber = phone;
        PersonalNumber = idNumber;
        Address.AddressLine = addressLine;
        Address.PostNumber = postalCode;
        Address.City = city;
    }

    public override string DisplayInfo()
    {
        return $"{base.DisplayInfo()}";
    }

}


