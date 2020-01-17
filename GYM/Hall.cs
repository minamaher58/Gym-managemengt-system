using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM
{
    class Hall
    {
        public int id { set; get; }
        
        string name;
        public List<Equipment> equipments { set; get; }
        public List<Trainer> trainers { set; get; }
        public TimeSpan total_time { set; get; }
        public TimeSpan max_time  { get; }
        public TimeSpan opening_time { set; get; }
        public TimeSpan closing_time { set; get; }
        public TimeSpan duration_of_hall { set; get; }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }      
        public void add_equipment(Equipment e)
        {                  
         //       Equipment e1 = new Equipment(e.duration_of_equipment, e.id, e.name);
                equipments.Add(e);
                total_time += e.duration_of_equipment;
            
        }
        public Hall(int _id, string _name,List<Equipment> list_of_equip)
        {
            id = _id;
            name = _name;
            equipments = new List<Equipment>(list_of_equip);
        }
        public Hall(int _id, string _name)
        {
            max_time = new TimeSpan(03, 00, 00);
            opening_time = new TimeSpan(08, 00, 00);
            duration_of_hall = new TimeSpan(12, 00, 00);
            closing_time = opening_time + duration_of_hall;
            id = _id;
            name = _name;
            equipments = new List<Equipment>();
            trainers = new List<Trainer>();
        }
        public Hall()
        {
            if (total_time > max_time)
            {
                Console.WriteLine("tony");
                return;
            }
        }
        public TimeSpan get_duration(int _id)
        {
            TimeSpan t = new TimeSpan(00, 11, 00);
            for (int x=0;x<equipments.Count;x++)
            {              
                if (equipments[x].id == _id)
                {
                    t = equipments[x].duration_of_equipment;
                }
            
            }
            return t;
        }
        public List<Equipment> return_list_of_equip()
        {
            return equipments;
        }
        public int num_of_equip()
        {
            return equipments.Count;
        }
        public TimeSpan return_du_equip(int _id)
        {
            TimeSpan t = new TimeSpan(00, 00, 00);
            for (int x = 0;x<equipments.Count;x++)
            {
                if (equipments[x].id == _id)
                    t= equipments[x].duration_of_equipment;
            }
            return t;
        }
        public void add_trainer(Trainer tr)
        {
            trainers.Add(tr);
        }
        
    }
}
