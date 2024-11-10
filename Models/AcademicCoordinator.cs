namespace WestCoastEducation.Models;

public class AcademicCoordinator : Person
{
    public int  AcademicCoordinatorNumber{ get; set; }
    public string? EmploymentDate { get; set; }

    public AcademicCoordinator(){}
    public AcademicCoordinator(int academicCoordinatorNumber)
    {
        AcademicCoordinatorNumber = academicCoordinatorNumber;
        Find();
    }
    public override void Find()
    {
        if (AcademicCoordinatorNumber == 1)
        {
            InitializeAcademicCoordinator("Thomas", "Palmberg", "0738785425", "19740708-2838", "Strandgatan 29", "212 55", "Malmö", "2023-07-15");
        }
        else if (AcademicCoordinatorNumber == 2)
        {
            InitializeAcademicCoordinator("Elin", "Gustavsson", "0768895828", "19640505-9822", "Trianglesgatan 26", "214 22", "Malmö", "2024-01-17");
        }
        else
        {
            throw new ArgumentException($"Could not find info for: {AcademicCoordinatorNumber}");
        }
    }
    private void InitializeAcademicCoordinator(string name, string lastName, string phone, string idNumber, string addressLine, string postalCode, string city, string employmentDate)
    {
        Name = name;
        LastName = lastName;
        TelephoneNumber = phone;
        PersonalNumber = idNumber;
        Address.AddressLine = addressLine;
        Address.PostNumber = postalCode;
        Address.City = city;
        EmploymentDate = employmentDate;
    }
    public override string DisplayInfo()
    {
        return $"{base.DisplayInfo()}, Employment Date: {EmploymentDate}";
    }
}