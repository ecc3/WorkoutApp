using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkoutApp;

namespace WorkoutAppTest
{
    [TestClass]
    public class WorkoutTest
    {
        [TestMethod]
        public void ValidWorkoutCreated()
        {
            Workout expected = new Workout();
            expected.Name = "2k run";

            Workout actual = new Workout("2k run");

            Assert.AreEqual(expected.Name, actual.Name);
            //Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.Routine.Count, actual.Routine.Count);
            Assert.IsTrue(actual.Routine.Count == 0);
        }

        [TestMethod]
        public void AddsActivityToWorkout()
        {
            Workout actual = new Workout("2k run");
            actual.AddActivity("cardio", "burn", 34);

            Workout expected = new Workout();
            expected.Name = "2k run";
            expected.Routine[0].Name = "burn";
            expected.Routine[0].Duration = 34;


            Assert.AreEqual(expected.Routine[0].Name, actual.Routine[0].Name);
            Assert.AreEqual(expected.Routine[0].Duration, actual.Routine[0].Duration);
            //Assert.AreEqual(expected.Routine[0].DistanceGoal, actual.Routine[0].DistanceGoal);
        }
    }
}
