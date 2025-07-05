using courses.data;
using courses.moodle;

namespace courses
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dbc=new data.coursesContext();
            /// Add List(project3 Hard Delete)///
            //var List = new List<course>();
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter the name of course{i}:");
            //    var name = Console.ReadLine();

            //    bool isValid = false;
            //    double courseshours = 0;

            //    do
            //    {
            //        Console.WriteLine("Enter the courses hours:");
            //        try
            //        {
            //            courseshours = double.Parse(Console.ReadLine());
            //            isValid = true;

            //        }
            //        catch
            //        {

            //            Console.WriteLine("Please enter a valid integer.");
            //        }


            //    } while (!isValid);


            //    List.Add(new course { name = name, courseshours = courseshours });

            //}
            //dbc.Courses.AddRange(List);
            //dbc.SaveChanges();

            ///update list(project3 Hard Delete)///

            //var courseList = dbc.Courses.ToList();
            //Console.WriteLine("Enter the new course name you wont to update it in the List courses:");
            //String newNameCourses = Console.ReadLine();
            //foreach (var course in courseList)
            //{
            //    course.name = newNameCourses;
            //}
            //dbc.Courses.UpdateRange(courseList);
            //dbc.SaveChanges();



            ///delete list (project3 hard delete)///
            //var courseList = dbc.Courses.ToList();
            //Console.WriteLine("Enter the name course you wont to delete it:");
            //string courseName = Console.ReadLine();
            //var coursesDelete = dbc.Courses.Where(c => c.name == courseName).ToList();

            //if (coursesDelete.Any())
            //{
            //    dbc.Courses.RemoveRange(coursesDelete);
            //    dbc.SaveChanges();
            //    Console.WriteLine($"{courseName}  deleted successfully ");

            //}
            //else
            //{
            //    Console.WriteLine("the course not found to deleted");
            //}



            /// reserch list(project3 Hared delete)///
            // Console.WriteLine("the name you wont to serch it in list");
            //var searchName = Console.ReadLine();
            //var searchR = dbc.Courses.Where(c => c.name.Contains(searchName)).ToList();
            //if (searchR.Any())
            //{
            //    foreach (var course in searchR)
            //    {

            //        Console.WriteLine($"ID: {course.id},  Name: {course.name}");

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("the course not found");
            }

        }
    }
}
