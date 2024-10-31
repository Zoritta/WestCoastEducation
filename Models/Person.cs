namespace WestCoastEducation.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        

        public Person(string firstName, string lastName, string phone, string email, string address, string postalCode, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Address = address;
            PostalCode = postalCode;
            City = city;
            
        }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, Phone: {Phone}, Email: {Email}, Address: {Address},  {PostalCode} {City}";
        }
    }
}
 