using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models1
{
    public partial class HighSchoolContext : DbContext
    {
        public void AddStudent(Student student)
        {
            using(var db=new HighSchoolContext())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }

        public static Student FindStudentByName(string name) 
        { 
            using(var db=new HighSchoolContext())
            {
                return db.Students.Where(x => x.Name == name).FirstOrDefault();
            }
        }

        public static Student FindStudentById(int id)
        {
            using (var db = new HighSchoolContext())
            {
                return db.Students.Where(x => x.Id == id).FirstOrDefault();
            }
        }

    }
}
