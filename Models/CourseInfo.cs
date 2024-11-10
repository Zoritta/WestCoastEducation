namespace WestCoastEducation.Models;

public class CourseInfo
{
    public int CourseNumber { get; set; }
    public string? Title { get; set; }
    public int DurationInWeeks { get; set; }
    public string? StudyForm { get; set; }
    public string? Start { get; set; }
    public string? End { get; set; }

    public CourseInfo(int courseNumber)
    {
        CourseNumber = courseNumber;
        FindCourses();
    }
    private void FindCourses()
    {
        if (CourseNumber == 2401)
        {
            Title = "Programming 1";
            DurationInWeeks = 4;
            StudyForm = "Distance";
            Start = "2025-01-07";
            End = "2025-01-31";
        }
        else if (CourseNumber == 2402)
        {
            Title = "DevOps";
            DurationInWeeks = 5;
            StudyForm = "Classroom";
            Start = "2025-01-07";
            End = "2025-02-07";
        }
        else if (CourseNumber == 2403)
        {
            Title = "Database";
            DurationInWeeks = 4;
            StudyForm = "Distance";
            Start = "2025-01-07";
            End = "2025-01-31";
        }
        else
        {
            throw new ArgumentException($"Error: {CourseNumber}");
        }

    }
    public string DisplayCourseInfo()
    {
        return $"Course Number: {CourseNumber}, Course Title: {Title}, Duration: {DurationInWeeks}, Study Form: {StudyForm} Start Date: {Start}/ End Date: {End}.";
    }
}
