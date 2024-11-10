
namespace WestCoastEducation.Models;

public class Courses
{
    public CourseInfo CourseInfo { get; set; }
    public Teacher Teacher { get; set; }


    public Courses(int amount, CourseInfo courseInfo, Teacher teacher)
    {
        CourseInfo = courseInfo;
        Teacher = teacher;
    }
    public override string ToString()
    {
        return $"Course: {CourseInfo.Title}, Start Date: {CourseInfo.Start}, End Date: {CourseInfo.End}, Course Duration: {CourseInfo.DurationInWeeks}, Teacher: {Teacher.Name}";
    }
}

