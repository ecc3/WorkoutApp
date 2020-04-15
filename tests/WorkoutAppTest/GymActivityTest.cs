using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkoutApp;

namespace WorkoutAppTest
{
    [TestClass]
    public class GymActivityTest
    {
        [TestMethod]
        public void ValidGymActivityCreated()
        {
            //--Arrange
            //GymActivity gymAct = new GymActivity(Squats, 30, Mat, 3, 10);
            GymActivity expected = new GymActivity();
            expected.Name = "Squats";
            expected.Duration = 30;
            expected.Equipment = GymActivity.EquipEnum.Mat;
            expected.Reps = 3;
            expected.Rest = 10;
            //--Act
            GymActivity actual = new GymActivity("Squats", 30, GymActivity.EquipEnum.Mat, 3, 10);

            //--Assert
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Duration, actual.Duration);
            Assert.AreEqual(expected.Equipment, actual.Equipment);
            Assert.AreEqual(expected.Reps, actual.Reps);
            Assert.AreEqual(expected.Rest, actual.Rest);
        }
    }
}
