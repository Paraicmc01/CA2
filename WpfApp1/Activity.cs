﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public enum ActivityType { Air, Water, Land}
    public class Activity
    {
        //properties
        public DateTime ActivityDate { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public string TypeOfActivity { get; set; }


        //constructors
        public Activity(DateTime activityDate, string name, decimal cost, string description, ActivityType typeOfActivity)
        {

            ActivityDate = activityDate;
            Name = name;
            Cost = cost;
            Description = description;
            TypeOfActivity = TypeOfActivity;
        }

        public Activity()
        {
        }




        // methods
        public override string ToString()
        {
            return $"{Name}-{ActivityDate.ToShortDateString()}";
        }

    }
}
