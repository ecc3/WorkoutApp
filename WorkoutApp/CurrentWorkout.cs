using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutApp
{
    class CurrentWorkout
    {
        public CurrentWorkout(Workout wo)
        {
            CurrentWO = wo;
        }
        public Workout CurrentWO { get; set; }
        public void StartWorkout() { }
        public void PauseWorkout() { }
        public void SaveWorkout() { }
    }
}
