public class Course
{
    public int CourseNumber { get; set; }
    public string Title { get; set; }
    public int Duration { get; set; } 
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<Student> Students { get; set; }
    public Teacher CourseTeacher { get; set; }

    public Course(int courseNumber, string title, int duration, DateTime startDate, DateTime endDate, Teacher courseTeacher)
    {
        CourseNumber = courseNumber;
        Title = title;
        Duration = duration;
        StartDate = startDate;
        EndDate = endDate;
        Students = new List<Student>();
        CourseTeacher = courseTeacher;
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public override string ToString()
    {
        return $"{Title} (Course Number: {CourseNumber}), Duration: {Duration} days/weeks, Teacher: {CourseTeacher.FirstName} {CourseTeacher.LastName}";
    }
}
