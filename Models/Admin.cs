namespace WestCoastEducation.Models;

public class Admin : Person
{
    public List<Courses> Courses { get; set; } = new List<Courses>();
    public List<Student> Student { get; set; } = new List<Student>();
    public List<AcademicCoordinator> AcademicCoordinator { get; set; } = new List<AcademicCoordinator>();
    public List<Teacher> Teacher { get; set; } = new List<Teacher>();
    public List<Administrators> Administrators { get; set; } = new List<Administrators>();

    public Admin()
    {

    }
    public void AddCourse(Courses course)
    {
        Courses.Add(course);
    }
    public void AddStudent(Student student)
    {
        Student.Add(student);
    }
    public void AddAcademicCoordinator(AcademicCoordinator academicCoordinator)
    {
        AcademicCoordinator.Add(academicCoordinator);
    }
    public void AddTeacher(Teacher teacher)
    {
        Teacher.Add(teacher);
    }
    public void AddAdministrator(Administrators administrator)
    {
        Administrators.Add(administrator);
    }
}

