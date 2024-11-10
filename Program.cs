using System.Text.Encodings.Web;
using System.Text.Json;
using WestCoastEducation.Models;

namespace WestCoastEducation;

class Program
{
    static void Main()
    {
        Admin admin = new Admin();
        AcademicCoordinator academicCoordinator = new AcademicCoordinator();


        admin.AddStudent(new Student(1));
        admin.AddStudent(new Student(2));
        admin.AddStudent(new Student(3));

        admin.AddTeacher(new Teacher(1));
        admin.AddTeacher(new Teacher(2));
        admin.AddTeacher(new Teacher(3));

        admin.AddAcademicCoordinator(new AcademicCoordinator(1));
        admin.AddAcademicCoordinator(new AcademicCoordinator(2));

        admin.AddAdministrator(new Administrators(1));

        try
        {
            admin.AddCourse(new Courses(1, new CourseInfo(2401), new Teacher(1)));
            admin.AddCourse(new Courses(1, new CourseInfo(2402), new Teacher(2)));
            admin.AddCourse(new Courses(1, new CourseInfo(2403), new Teacher(3)));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Wrong: {ex.Message}");
        }

        Console.WriteLine("Course Info:");
        foreach (var Course in admin.Courses)
        {
            Console.WriteLine(Course.ToString());
        }

        Console.WriteLine("Students' Info:");
        foreach (var student in admin.Student)
        {
            Console.WriteLine(student.DisplayInfo());
        }

        Console.WriteLine("Teacher's Info:");
        foreach (var Teacher in admin.Teacher)
        {
            Console.WriteLine(Teacher.DisplayInfo());
        }
        Console.WriteLine("AcademicCoordinator's Info:");
        foreach (var AcademicCoordinator in admin.AcademicCoordinator)
        {
            Console.WriteLine(AcademicCoordinator.DisplayInfo());
        }



        var path = Path.Combine(Environment.CurrentDirectory, "Data", "courses.json");
        
        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            WriteIndented = true
        };
        var json = JsonSerializer.Serialize(admin.Courses, options);
        File.WriteAllText(path, json);

        var AllCourses = File.ReadAllText(path);

        Console.WriteLine(AllCourses);
    }
}
