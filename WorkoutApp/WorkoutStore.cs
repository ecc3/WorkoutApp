using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutApp
{
    public class WorkoutStore : ILoggable
    {
        public WorkoutStore()
        { 
            AllWorkouts = new List<Workout>();
        }

        public List<Workout> AllWorkouts { get; set; }
        static int _totalWorkouts = 0;

        public static int TotalWorkouts 
        { 
        get { return _totalWorkouts; }
        }

        public void AddNewWorkout()
        {
            _totalWorkouts += 1;
        }
        public void Display()
        {
            string result = String.Empty;
            foreach (Workout workoutPlan in AllWorkouts)
            {
                result += workoutPlan.Name + ", ";
                result.Remove(workoutPlan.Name.Length - 2);
            }
            Console.WriteLine(result);
        }



	}
}
