    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM
{
    class Trainer
    {
        public int id { set; get; }
        public string name { set; get; }
        public int hall_num { set; get; }
        public Hall hall_of_trainer { set; get; }
        public List<Plan> plans { set; get; }
        public  TimeSpan total_training_time { set; get; }
        public static TimeSpan max_time_of_training { set; get; }
        public Trainer(int _id,string _name,Hall h)
        {
            hall_of_trainer = h;
            max_time_of_training = new TimeSpan(04, 00, 00);
            total_training_time = new TimeSpan(00, 00, 00);
            id = _id;
            name = _name;
            
            plans = new List<Plan>();
        }
        public void add_plan(Plan p)
        {
            
            plans.Add(p);
  //          total_training_time += p.total_time_of_plan;
        }
        public void time_table_of_trainer()
        {
            Console.WriteLine("___________________________");
            Console.WriteLine("the time table of trainer of id :" + id);
            for(int x=0;x<plans[0].exercise[0].exersice_times.Count;x++)
            {
                Console.WriteLine(plans[0].exercise[0].exersice_times[x].start_time + " __"+ plans[0].exercise[0].exersice_times[x].end_time);
            }
        }

    }
}
