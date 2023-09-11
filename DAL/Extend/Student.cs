using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models1
{
    public partial class Student
    {
        public void AddGrade(string Name,int grade)
        {
            using(var db=new HighSchoolContext())
            { 
                
               int id = db.Students.Where(x => x.Name == Name).FirstOrDefault().Id;
                if (id != null)
                {
                    StudentGrade s = new StudentGrade()
                    {
                        StudentId = id,
                        Score = grade,
                    };

                    db.StudentGrades.Add(s);
                    db.SaveChanges();
                }
                                                                 
            }
        }
       
    }
}
