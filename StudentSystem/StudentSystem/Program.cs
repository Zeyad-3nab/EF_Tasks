using StudentSystem.Data;
using StudentSystem.Models;

namespace StudentSystem
{
    public class Program
    {
        public static void SeedData() 
        {
            ApplicationDbContext context = new ApplicationDbContext();
            Student std = new Student() {Name="Zeyad",Phone="01048544",RegisteredOn=DateTime.Now,BirthDay= new DateOnly(2002,10,13)};
            context.Students.Add(std);
            Resource resource = new Resource() {Name="W3Resources",Url="Test.Com" , CourseId=1};
            context.Resources.Add(resource);
            Course course = new Course() {Name="BackEnd", Description="Test" , StarDate=new DateOnly(2024,7,15) , EndDate=new DateOnly(2024,12,15),Price=4500};
            context.Courses.Add(course);
            HomeWork homeWork = new HomeWork() {Content="Test",SubmissionTime=new TimeOnly(12,00),StudentId=1,CourseId=1};
            context.HomeWorks.Add(homeWork);
            context.SaveChanges();
            Console.WriteLine("Done");    //دول الي عرفت اضيفهم في مشكله قابلتني بتاعت ال enum , وفي بعض الايرورات بتظهرلي معرفتش اهندلها
            
            //int x;

            //if (num == 1)
            //{
            //    Student student = new Student();
            //    Console.Write("Enter Student Id : ");
            //    student.StudentId =int.Parse(Console.ReadLine());
            //    Console.Write("Enter Student Name : ");
            //    student.Name = Console.ReadLine();
            //    Console.Write("Enter Student Phone : ");
            //    student.Phone = Console.ReadLine();
            //    student.RegisteredOn=DateTime.Now;
            //    Console.Write("Enter Student BirthDate : ");
            //    student.BirthDay =DateOnly.Parse(Console.ReadLine());
            //    Console.Write("Enter Number Of Courses : ");
            //     x=int.Parse(Console.ReadLine());
            //    for (int i = 0; i < x; i++)
            //    {
            //        Course course = new Course();


            //    }


            //}

        }



        public static void Main(string[] args)
        {
            SeedData();

        }
    }
}
