using WestCoastEducation.Models;

namespace WestCoastEducation.Interfaces;

public interface IPerson
{
public string Name {get; set;}
public string LastName { get; set; }
public string TelephoneNumber { get; set; }
public string PersonalNumber { get; set; }
public Address Address { get; set; }

public void Find();

}
