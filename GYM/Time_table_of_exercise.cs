using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM
{
    class Time_table_of_exercise
    {
        public TimeSpan start_time { set; get; }
        public TimeSpan end_time { set; get; }
        public Exercise exercise { set; get; }
        public Customer submited_customer { set; get; }
        public Time_table_of_exercise()
        {
            start_time = new TimeSpan(00, 00, 00);
            end_time = new TimeSpan(00, 00, 00);
        }
        public Time_table_of_exercise(TimeSpan _start_time,Exercise e)
        {
            start_time = _start_time;
            end_time = _start_time + e.durration_of_exercise();
        }
    }
}
