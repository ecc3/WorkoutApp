using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutApp
{
    public class GymActivity : Activity
    {
        public GymActivity()
        {

        }
        public GymActivity(string name, int duration, EquipEnum equipment, int reps = 0, int rest = 0) : base( name,  duration, reps, rest)
            {
            Equipment = equipment;
        }
        /*public enum NameEnum
        {
            Weights,
            Squats,
            Crunches,
            Planks,
            ResistanceTraining
        }*/

        public enum EquipEnum
        {
            Dumbells,
            Mat,
            ResistanceBand
        }

        public EquipEnum Equipment { get; set; }
    }
}
