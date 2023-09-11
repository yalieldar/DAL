using DAL.Models;
using DAL.Models1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace DAL
{
    public class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student()
            {
                Name = "Yali",
            };

            HighSchoolContext highSchool = new HighSchoolContext();
            highSchool.AddStudent(student);
            student.AddGrade("Yali", 98);
           
        }
    }
}
