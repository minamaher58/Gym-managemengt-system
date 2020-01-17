using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM
{
    class Customer
    {
        public int id { set; get; }
        public string name { set; get; }
        public Trainer customer_trainer { set; get; }
        public Plan customer_plans { set; get; }
        public DateTime start_training_date { set; get; }
        public DateTime end_training_date { set; get; }
        public Customer (int _id,string _name,Trainer t,DateTime _start_training_date,DateTime _end_training_date,Plan p)
        {
             customer_plans = p;
            id = _id;
            name = _name;
            customer_trainer = t;
            start_training_date = _start_training_date;
            end_training_date = _end_training_date;
        }

    }
}
