using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkoutApp;

namespace WorkoutAppTest
{
    [TestClass]
    public class CardioActivityTest
    {
        [TestMethod]
        public void ValidCardioActivityCreated()
        {
            //--Arrange
            CardioActivity expected = new CardioActivity();
            expected.Name = "Running";
            expected.Duration = 30;
            expected.DistanceGoal = 12;
            expected.Reps = 3;
            expected.Rest = 10;
            //--Act
            CardioActivity actual = new CardioActivity("Running", 30, 12, 3, 10);

            //--Assert
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Duration, actual.Duration);
            Assert.AreEqual(expected.DistanceGoal, actual.DistanceGoal);
            Assert.AreEqual(expected.Reps, actual.Reps);
            Assert.AreEqual(expected.Rest, actual.Rest);
        }
    }
}
