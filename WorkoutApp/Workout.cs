using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutApp
{
    public class Workout : ILoggable
    {
        public Workout() : this("")
        {

        }

        public Workout(string name)
        {
            Name = name;
            Routine = new List<Activity>();
        }

        private int _iD = new Random().Next();
        public int ID
        {
            get { return _iD; }
        }
        public string Name { get; set; }
        public List<Activity> Routine { get; set; }
        public void AddActivity(string activityType, string name, int duration) { 
            if (activityType == "cardio")
            {
                string distanceGoal = Console.ReadLine();
                CardioActivity newCardio = new CardioActivity(name, duration, Int32.Parse(distanceGoal));
                Activity newCardioAct = newCardio;
                Routine.Add(newCardioAct);
            }
            else if (activityType == "hiit")
            {
                string intensity = Console.ReadLine();
                HiitActivity newHiit = new HiitActivity(name, duration, (HiitActivity.IntensityEnum)Enum.Parse(typeof(HiitActivity.IntensityEnum), intensity));
                Activity newHiitAct = newHiit;
                Routine.Add(newHiitAct);
            }
            else if (activityType == "gym")
            {
                string equipment = Console.ReadLine();
                GymActivity newGym = new GymActivity(name, duration, (GymActivity.EquipEnum)Enum.Parse(typeof(GymActivity.EquipEnum), equipment));
                Activity newGymAct = newGym;
                Routine.Add(newGymAct);
            }
        }
        public void DeleteWorkout() { }
        public void Display()
        {
            string result = "";
            foreach (Activity activity in Routine)
            {
                result += $" { activity.Name} for {activity.Duration} seconds, with {activity.Rest} seconds rest and {activity.Reps} repetitions.";

            }

            Console.WriteLine(result.Trim());
        }
    }
    }
