using System;
using TechTalk.SpecFlow;
using BPCalculator;
using NUnit.Framework;

namespace BDDTestingCA1.Steps
{
    [Binding]
    public class BloodPressureSteps
    {
        private BloodPressure bptesting = new BloodPressure();

        [Given(@"the systolic pressure is (.*)")]
        public void GivenTheSystolicPressureIs(int p0)
        {
            bptesting.Systolic = p0;
            
        }
        
        [Given(@"the diastolic pressure is (.*)")]
        public void GivenTheDiastolicPressureIs(int p0)
        {
            bptesting.Diastolic = p0;
        }
        
        [When(@"I press calculate")]
        public void WhenIPressCalculate()
        {
            bptesting = new BloodPressure() { Systolic = bptesting.Systolic, Diastolic = bptesting.Diastolic };
        }
        
        [Then(@"the result should be '(.*)'")]
        public void ThenTheResultShouldBe(string p0)
        {
            Assert.AreEqual(bptesting.Category, BPCategory.Ideal);
        }
    }
}
