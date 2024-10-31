namespace WestCoastEducation.Models
{
    public class Student : Person
    {
        public string PersonalNumber { get; set; }

        public Student(string firstName, string lastName, string phone, string email, string address, string postalCode, string city, string personalNumber)
            : base(firstName, lastName, phone, email, address, postalCode, city)
        {
            PersonalNumber = personalNumber;
        }

        public override string ToString()
        {
            return base.ToString() + $", Personal Number: {PersonalNumber}";
        }
    }
}