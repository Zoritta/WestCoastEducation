namespace WestCoastEducation.Models;

public class Administrators : Person

{
    public int AdministratorNumber { get; set; }
    public string? AreaOfExpertise { get; set; }
    public string? Courses { get; set; }
    public string? EmploymentDate { get; set; }
    public Administrators() { }
    public Administrators(int administratorNumber)
    {
        AdministratorNumber = administratorNumber;
        Find();
    }
    public override void Find()
    {
        if (AdministratorNumber == 1)
        {
            InitializeAcademicCoordinator("Annika", "Stenberg", "0700901018", "19750708-2838", "Baltazargatan 2", "261 64", "Landskrona", "2023-01-24");
        }
        else
        {
            throw new ArgumentException($"Could not find the information for: {AdministratorNumber}");
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
        EmploymentDate= employmentDate;
    }
    public override string DisplayInfo()
    {
        return $"{base.DisplayInfo()}, Employment Date: {EmploymentDate}";
    }

}
