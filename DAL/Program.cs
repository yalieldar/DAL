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

            Player player = new Player()
            {
                BirthYear = 2006,
                Name = "NK",
               
            };

            using (var db = new HighScoresContext())
            {


                /*  db.Players.Add(player);
                  db.SaveChanges();

                  foreach(Game game in db.Games) 
                  {
                      Console.WriteLine($"{game.Name} - {game.GameId}");
                  }*/

                //foreach (HighScore highScore in db.HighScores)
                //{
                //    HighScore hs = db.HighScores.Include(x => x.Player).Include(x => x.Game).FirstOrDefault();
                //    Console.WriteLine(hs.Player.Name);
                //}
            }
            using (var db = new HighSchoolContext())
            {
                Console.WriteLine( " pick one of the following option:" );
                Console.WriteLine( "to add student press \"1\" ");
                Console.WriteLine("to add grade for a student student press \"2\" ");
                Console.WriteLine("to search a student by his Id press \"3\" ");
                Console.WriteLine("to see the student's geades and his average press \"4\" ");
                Console.WriteLine("to see the best student with the hightest average press \"5\" ");
                int choice = int.Parse(Console.ReadLine()); 
                while(choice<1 || choice>5 )
                {
                    Console.WriteLine( "please enter a valid number");
                     choice = int.Parse(Console.ReadLine());
                }

                switch( choice )
                {
                    case 1:
                    {
                        Console.WriteLine("enter the new student name");
                        string name = Console.ReadLine();
                        while(!(name==null && (name[0] >= 'a' && name[0]<='z')))
                        {

                        }
                        Student s = new Student()
                        {
                           Name = name,
                        };
                        db.Students.Add(s);
                        db.SaveChanges();

                    } break;
                    case 2:
                    {
                            Console.WriteLine(" enter student name");
                            string name = Console.ReadLine();

                            while()
                            { }
                        }
                        break;
                        
                }
            }
           
        }
    }
}