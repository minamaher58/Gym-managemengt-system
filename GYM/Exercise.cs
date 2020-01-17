using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM
{
    class Exercise
    {
        public int number_of_equipment { set; get; }
        public Equipment equipmen_exercise { set; get; }
        public TimeSpan start_time { set; get; }
        public Plan execise_plan { set; get; }
        public TimeSpan end_time { set; get; }
        public  List<Customer> sutmited_customers{ set; get; }
        public List<Time_table_of_exercise> exersice_times { set; get; }
        public Exercise(Equipment eq)
        {
            exersice_times = new List<Time_table_of_exercise>();
            equipmen_exercise = eq;                      
        }
        public TimeSpan durration_of_exercise()
        {
           
           
            return equipmen_exercise.duration_of_equipment;
        }
        public bool availble_or_not_2(Time_table_of_exercise exeit)
        {
            for (int x = 0; x < exersice_times.Count; x++)
            {

                if ((exersice_times[x].end_time >= exeit.start_time) && ((exeit.start_time) >= exersice_times[x].start_time))
                {
                    Console.WriteLine(exeit.start_time);
                    Console.WriteLine(exeit.end_time);
                    return true;
                }
                else if (exersice_times[x].end_time >= exeit.end_time && (exeit.end_time) >= exersice_times[x].start_time)
                {

                    Console.WriteLine("2"+ exeit.start_time);
                    Console.WriteLine(exeit.end_time);
                    return true;
                }    
            }
            return false;
        }
        public void add_exercise_time(Time_table_of_exercise exeti)
        {
            if(availble_or_not_2(exeti))
            {
                Console.WriteLine("time out .");
                return;
            }
            else
                exersice_times.Add(exeti);

        }


    }
}
