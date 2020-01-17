using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan duration_of_equipment1 = new TimeSpan(00, 50, 00);
            TimeSpan duration_of_equipment2 = new TimeSpan(00, 20, 00);
            TimeSpan duration_of_equipment3 = new TimeSpan(00, 20, 00);
   //       Console.WriteLine(duration_of_equipment1 + duration_of_equipment2 );
            TimeSpan duration_of_equipment4 = new TimeSpan(00, 41, 00);
            TimeSpan star_time_of_exercise1 = new TimeSpan(10, 05, 00);
            TimeSpan star_time_of_exercise2 = new TimeSpan(12, 20, 00);
            TimeSpan star_time_of_exercise3 = new TimeSpan(13, 10, 00);
            TimeSpan star_time_of_exercise4 = new TimeSpan(12, 41, 00);
            Hall h1 = new Hall(1, "hall1");
            Equipment eq1 = new Equipment(duration_of_equipment1,1, "equip1",h1);
            Equipment eq2 = new Equipment(duration_of_equipment2, 2, "equip1", h1);
            Equipment eq3 = new Equipment(duration_of_equipment3, 3, "equip1", h1);
            Equipment eq4 = new Equipment(duration_of_equipment4, 4, "equip1", h1);
            Exercise ex1 = new Exercise(eq1);
            Exercise ex2 = new Exercise(eq2);
            Exercise ex3 = new Exercise(eq3);
            Exercise ex4 = new Exercise(eq4);            
            h1.add_equipment(eq1);
            h1.add_equipment(eq2);
            h1.add_equipment(eq3);
 //           Console.WriteLine(h1.total_time);
            h1.add_equipment(eq4);
            Trainer tr1 = new Trainer(1, "tony", h1);          
            Plan pl1 = new Plan(1, "tray", ex1.start_time,tr1);
            tr1.add_plan(pl1);
            pl1.add_exercise(ex1);
      //      Console.WriteLine(pl1.exercise.Count);            
            pl1.add_exercise(ex2);
    //        Console.WriteLine(pl1.exercise.Count);
            pl1.add_exercise(ex3);          
   //         Console.WriteLine(pl1.exercise.Count);
            pl1.add_exercise(ex4);
            //      Console.WriteLine(pl1.exercise[pl1.exercise.Count-1].end_time);
            //        Console.WriteLine(" ");
            //        Console.WriteLine(h1.equipments.Count);
            Time_table_of_exercise exeti1=new Time_table_of_exercise(star_time_of_exercise1,ex1);
            Time_table_of_exercise exeti2 = new Time_table_of_exercise(star_time_of_exercise2, ex1);
            Time_table_of_exercise exeti3 = new Time_table_of_exercise(star_time_of_exercise3, ex1);
            ex1.add_exercise_time(exeti1);
            ex1.add_exercise_time(exeti2);
            ex1.add_exercise_time(exeti3);
            //           Console.WriteLine( pl1.exercise[0].exersice_times.Count);
            tr1.time_table_of_trainer();
        //    Console.WriteLine(pl1.available_or_not(ex4));



        }
    }
}
