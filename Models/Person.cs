using WestCoastEducation.Interfaces;

namespace WestCoastEducation.Models;

public class Person: IPerson
{
    public string Name { get; set; } = "";
    public string LastName { get; set; } = "";
    public string TelephoneNumber { get; set; } = "";
    public string PersonalNumber { get; set; } = "";
    public Address Address { get; set; } = new Address();

    public virtual void Find()
    {

    }
    public virtual string DisplayInfo()
    {
        return $"{Name} {LastName}, Telephone Number : {TelephoneNumber}, Personal Number : {PersonalNumber}, Address: {Address}";
    }
}
