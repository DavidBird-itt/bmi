using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.DataAnnotations;
using BMICalculator;

namespace UnitTests
{
    [TestClass]
    public class UnitTestBMICalculator
    {
        //Setup
        BMI bmiTest = new BMI();

        [TestMethod]
        public void bmiIsUnderweight()
        {
            BMI bmiTest = new BMI();


            bmiTest.WeightStones = 7;
            bmiTest.HeightFeet = 6;
            bmiTest.HeightInches = 2;

            Assert.AreEqual(bmiTest.BMICategory, BMICategory.Underweight);
            
        }

        [TestMethod]
        public void bmiIsNormal()
        {
            
            bmiTest.WeightStones = 9;
            bmiTest.HeightFeet = 5;
            bmiTest.HeightInches = 7;

            Assert.AreEqual(bmiTest.BMICategory, BMICategory.Normal);

        }

        [TestMethod]
        public void bmiIsOverweight()
        {
            bmiTest.WeightStones = 14;
            bmiTest.HeightFeet = 6;
            bmiTest.HeightInches = 2;

            Assert.AreEqual(bmiTest.BMICategory, BMICategory.Overweight);

        }

        [TestMethod]
        public void bmiIsObese()
        {
            bmiTest.WeightStones = 18;
            bmiTest.HeightFeet = 5;
            bmiTest.HeightInches = 11;

            Assert.AreEqual(bmiTest.BMICategory, BMICategory.Obese);

        }

        [TestMethod]
        public void conversionCheck()
        {
            bmiTest.WeightStones = 9;
            bmiTest.WeightPounds = 5;
            bmiTest.HeightFeet = 5;
            bmiTest.HeightInches = 7;

            double weightInKgs = ((9 * 14) + 5) * 0.453592;
            double heightInMetres = ((5 * 12) + 7) * 0.0254;
            double bmi = weightInKgs / (Math.Pow(heightInMetres, 2));

            Assert.AreEqual(bmiTest.BMIValue, bmi);
        }

    }
}
