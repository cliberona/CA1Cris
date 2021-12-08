using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebTestCA1
{
    [TestClass]
    public class EdgeDriverTest
    {
        // In order to run the below test(s), 
        // please follow the instructions from http://go.microsoft.com/fwlink/?LinkId=619687
        // to install Microsoft WebDriver.

        private EdgeDriver _driver;

        [TestInitialize]
        public void EdgeDriverInitialize()
        {
            // Initialize edge driver 
            var options = new EdgeOptions
            {
                PageLoadStrategy = PageLoadStrategy.Normal
            };
            _driver = new EdgeDriver("C:\\Code\\CA1Cris\\WebTestCA1\\Drivers");
        }

        [TestMethod]
        public void VerifyPageTitle()
        {
            _driver.Url = "https://bmica1cris.azurewebsites.net/";
            Assert.AreEqual("BP Category Calculator - BPCalculator", _driver.Title);
        }

        [TestMethod]
        public void VerifyBPCalculator()
        {
            _driver.Url = "https://bmica1cris.azurewebsites.net/";

            IWebElement diastolicPressure = _driver.FindElement(By.Id("press_diastolic"));
            // enter 60 in element
            diastolicPressure.SendKeys("60");
            IWebElement systolicPressure = _driver.FindElement(By.Id("press_systolic"));
            // enter 100 in element
            systolicPressure.SendKeys("100");

            // submit the form
            _driver.FindElement(By.Id("bloodPressureForm")).Submit();

            IWebElement BMIValueElement = new WebDriverWait(_driver, TimeSpan.FromSeconds(10))
                .Until(c => c.FindElement(By.Id("bpVal")));
            String bmi = BMIValueElement.Text.ToString();

            StringAssert.Contains(bmi, "Ideal Blood Pressure");

            _driver.Quit();
        }


        [TestCleanup]
        public void EdgeDriverCleanup()
        {
            _driver.Quit();
        }
    }
}
