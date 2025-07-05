using Dectors.Moodle;

namespace Dectors
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dbD=new Data.Dectorscontext();
            ///add List (project4 Soft Delete)///
            ///
            //var List = new List<dector>();
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter your First Name {i}:");
            //    var FirstName = Console.ReadLine();
            //    Console.WriteLine("Enter your section:");
            //    var sectionName = Console.ReadLine();
            //    List.Add(new dector { Name = FirstName, section = sectionName, IsDeleted = false });

            //}
            //dbD.dectors.AddRange(List);
            //dbD.SaveChanges();

            ///update list(project4 Soft Delete)///

            //var DectorsList = dbD.dectors.Where(d => d.IsDeleted != true).ToList();
            //Console.WriteLine("enter the section you wont updat it:");
            // string  dectorsection = Console.ReadLine();
            //foreach (var dector in DectorsList)
            //{

            //    dector.section = dectorsection;
            //}
            //dbD.dectors.UpdateRange(DectorsList);
            //dbD.SaveChanges();

            ///delete list (project4 Soft Delete)///
            //var DectorsList = dbD.dectors.Where(d => /*d.Name.StartsWith("A") &&*/ d.IsDeleted != true).ToList();
            //foreach (var dector in DectorsList)
            //{
            //    dector.IsDeleted = true;


            //}
            //dbD.dectors.UpdateRange(DectorsList);
            //dbD.SaveChanges();

            ///restor list(project4 Soft Delete)///

            //var DectorsList = dbD.dectors.Where(d => /*d.Name.StartsWith("A") && */d.IsDeleted == true).ToList();
            //foreach (var dector in DectorsList)
            //{
            //    dector.IsDeleted = false;


            //}
            //dbD.dectors.UpdateRange(DectorsList);
            //dbD.SaveChanges();

            ///serch list(project4 Soft Delete)///

            //Console.WriteLine("the name you wont to serch it in list");
            //var searchname = Console.ReadLine();
            //var searchR = dbD.dectors.Where(d => d.Name.Contains(searchname) && d.IsDeleted != true).ToList();
            //if (searchR.Any())
            //{

            //    foreach (var dector in searchR)
            //    {
            //        Console.WriteLine($"ID: {dector.Id}, First Name: {dector.Name}, section: {dector.section}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("the dector name not found or deleted");
            //}
        }
    }
}
