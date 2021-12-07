using Microsoft.VisualStudio.TestTools.UnitTesting;
using BPCalculator;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBloodPressureCat()
        {
            BloodPressure BP = new BloodPressure() { Systolic = 100, Diastolic = 60 };
            Assert.AreEqual(BP.Category, BPCategory.Ideal);
        }
    }
}
