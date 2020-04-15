using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutApp
{
    public abstract class Activity
    {
        public Activity()
        { }
        public Activity(string name, int duration, int reps = 0, int rest = 0)
        {
            Name = name;
            Duration = duration;
            Reps = reps;
            Rest = rest;
        }

        public string Name { get; set; }
        public int Duration { get; set; }
        public int Reps { get; set; }
        public int Rest { get; set; }
    }
}
