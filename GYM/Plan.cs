using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM
{
    class Plan
    {
        public int id { set; get; }
        public string name { set; get; }
        public Trainer trainer_of_plan { set; get; }
        public TimeSpan start_time { set; get; }
        public TimeSpan end_time { set; get; }
        public List<Exercise> exercise { set; get; }
        public TimeSpan total_time_of_plan { set; get; }
        public Plan (int _id,string _name,TimeSpan _start_time,Trainer t)
        {
            start_time = _start_time;
            end_time = start_time + total_time_of_plan;
            total_time_of_plan = new TimeSpan(00, 00, 00);
            trainer_of_plan = t;
             exercise = new List<Exercise>();
            id = _id;
            name = _name;
        }
        //public Plan(int _id, string _name, int number_of_equipment, TimeSpan start_time)
        //{
        //    num_dur num_dur_1 = new num_dur(number_of_equipment, start_time);
        //    id = _id;
        //    name = _name;
        //}

        public bool available_or_not(Exercise ex)
        {
            if (exercise.Count == 0)
                return false;
            for (int x = 0; x < exercise.Count; x++)
            {
                
                 if ((trainer_of_plan.plans[0].exercise[x].end_time > ex.start_time) || ((ex.end_time) < trainer_of_plan.plans[0].exercise[x].start_time))
                {
                    Console.WriteLine(trainer_of_plan.plans[0].exercise[x].start_time);
                    Console.WriteLine(trainer_of_plan.plans[0].exercise[x].end_time);
                    return true;
                }
            }
            return false;
        }
        public void add_exercise(Exercise ex)
        {
            if (total_time_of_plan > Trainer.max_time_of_training)
            {
                Console.WriteLine("the time of trainer is full .");
                return;
                
            }
            else
            {
                if(ex.equipmen_exercise.duration_of_equipment + ex.start_time > ex.equipmen_exercise.hall_of_equipment.closing_time)
                {
                    Console.WriteLine("the ending time of plan over the ending time of hall");
                    return;
                }
                exercise.Add(ex);
                end_time = ex.equipmen_exercise.duration_of_equipment + ex.start_time;
                total_time_of_plan += ex.equipmen_exercise.duration_of_equipment;
                trainer_of_plan.total_training_time += ex.equipmen_exercise.duration_of_equipment;
                end_time = ex.start_time + ex.equipmen_exercise.duration_of_equipment;
            }
        }
        
    }
     
}
