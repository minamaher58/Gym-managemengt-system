using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM
{
    class Equipment
    {
        public TimeSpan duration_of_equipment { set; get; }
        public int id { set; get; }
        public string name { set; get; }
        public Hall hall_of_equipment { set; get; }                     
        public Equipment (TimeSpan _duration,int _id ,string _name,Hall h)
        {
            duration_of_equipment = _duration;
            id = _id;
            name = _name;
            hall_of_equipment = h;

        }
        public TimeSpan return_duration()
        {
            return duration_of_equipment;
        }
       
       

    }
}
