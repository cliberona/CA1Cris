using System;
using Xunit;
using BPCalculator;

namespace unitTestingCA1
{
    public class UnitTest1
    {
        [Fact]
        public void TestBloodPressureCat()
        {
            BloodPressure BP = new BloodPressure() { Systolic = 100, Diastolic = 60 };
            Assert.Equal(BPCategory.Ideal, BP.Category);
        }
        [Fact]
        public void TestBMI()
        {
            BMICalculator BMI = new BMICalculator() { kg = 100, m = 160 };
            Assert.Equal("-> Overweight", BMI.bmiCalculate());
        }

    }
}
