using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_ExamPractice;

// Test Class gets a reference to the project OOP_ExamPractice
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange 
            Phone phone = new Phone("Sony", 500m, "Android");
            decimal ExpectedPrice = 550m;

            // Act 
            phone.IncreasePrice(.10);

            // Assert
            Assert.AreEqual(ExpectedPrice, phone.Price);
        }
    }
}
