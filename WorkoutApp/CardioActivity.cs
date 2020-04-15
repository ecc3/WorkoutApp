using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutApp
{
    public class CardioActivity : Activity
    {
        public CardioActivity()
        { }
        public CardioActivity(string name, int duration, int distanceGoal, int reps = 0, int rest = 0) : base(name, duration, reps, rest)
        {
            DistanceGoal = distanceGoal;
        }
        /*public enum NameEnum
        {
            Running,
            Walking,
            Skiing,
            ScubaDiving
        }*/

        public int DistanceGoal { get; set; }
    }
}
