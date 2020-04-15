using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutApp
{
    public class HiitActivity : Activity
    {
        public HiitActivity()
        { }
        public HiitActivity(string name, int duration, IntensityEnum intensity
            , int reps = 0, int rest = 0) : base(name, duration, reps, rest)
        {
            Intensity = intensity;
        }
        /*    public enum NameEnum
            {
                Running,
                BodyConditioning
            }*/

        public enum IntensityEnum
        {
            Low, Medium, High
        }

        public IntensityEnum Intensity { get; set; }
}
}
