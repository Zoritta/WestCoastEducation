public class Teacher : Person, ICommunicate
{
    public string Expertise { get; set; }
    public List<Course> CoursesResponsible { get; set; }

    public Teacher(string firstName, string lastName, string phone, string email, string address, string postalCode, string city, string expertise)
        : base(firstName, lastName, phone, email, address, postalCode, city)
    {
        Expertise = expertise;
        CoursesResponsible = new List<Course>();
    }

    public void AddCourse(Course course)
    {
        CoursesResponsible.Add(course);
    }
    public void SendEmail(string message)
    {
        Console.WriteLine($"Sending email: {message}");
    }

    public void Chat(string message)
    {
        Console.WriteLine($"Chatting: {message}");
    }

    public override string ToString()
    {
        return base.ToString() + $", Expertise: {Expertise}";
    }
}
