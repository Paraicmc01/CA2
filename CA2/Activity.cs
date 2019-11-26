using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    public enum ActivityType { Air, Water, Land}
    public class Activity
    {
        //properties
        public int ActivityDate { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public ActivityType TypeOfActivity { get; set; }


        //constructors
        public Activity(int activitydate, string name, decimal cost, string description, ActivityType activitytype)
        {

            ActivityDate = activitydate;
            Name = name;
            Cost = cost;
            Description = description;
            TypeOfActivity = ActivityType;
        }

        // methods
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
