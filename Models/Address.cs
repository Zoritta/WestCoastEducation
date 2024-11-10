namespace WestCoastEducation.Models;

public class Address
{
public string AddressLine { get; set; } = "";
public string PostNumber { get; set; } = "";
public string City { get; set; } = "";

    public override string ToString()
    {
        return $"{AddressLine}, Post Number: {PostNumber}, City: {City}";
    }
}
