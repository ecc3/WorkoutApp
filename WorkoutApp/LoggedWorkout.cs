using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutApp
{
    class LoggedWorkout
    {
        public LoggedWorkout(int workoutID, int totalTime)
        {
            WorkoutId = workoutID;
            DateDone = DateTime.Today;
            TotalTime = totalTime;


        }

        public int WorkoutId { get; set; }
        public DateTime DateDone { get; set; }
        public int TotalTime { get; set; }
    }
}
