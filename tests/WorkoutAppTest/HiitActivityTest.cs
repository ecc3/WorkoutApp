using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkoutApp;

namespace WorkoutAppTest
{
    [TestClass]
    public class HiitActivityTest
    {
        [TestMethod]
        public void ValidHiitActivityCreated()
        {
            //--Arrange
            HiitActivity expected = new HiitActivity();
            expected.Name = "BodyConditioning";
            expected.Duration = 30;
            expected.Intensity = HiitActivity.IntensityEnum.High;
            expected.Reps = 3;
            expected.Rest = 10;
            //--Act
            HiitActivity actual = new HiitActivity("BodyConditioning", 30, HiitActivity.IntensityEnum.High, 3, 10);

            //--Assert
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Duration, actual.Duration);
            Assert.AreEqual(expected.Intensity, actual.Intensity);
            Assert.AreEqual(expected.Reps, actual.Reps);
            Assert.AreEqual(expected.Rest, actual.Rest);
        }
    }
}
