using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sunrise.Energy.Computing;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void ShouldgetWats()
        {
            CalculateSunEnergy sut = new CalculateSunEnergy();
            DateTime data = new DateTime(2016,7,25,8,0,0);
            int Latidue = 53;
            sut.setData(data);
            sut.setLatidue(Latidue);
            double result = sut.getWats();
            Assert.AreEqual(0.87092, result);
        }
        [TestMethod]
        public void Should()
        {
            CalculateSunEnergy sut = new CalculateSunEnergy();
            DateTime data = new DateTime(2016, 2, 29, 8, 0, 0);
            int Latidue = 53;
            sut.setData(data);
            sut.setLatidue(Latidue);
            double result = sut.getWats();
            Assert.AreEqual(0.36002, result);
        }
        [TestMethod]
        public void Should2()
        {
            CalculateSunEnergy sut = new CalculateSunEnergy();
            DateTime data = new DateTime(2016, 1,1, 10, 0, 0);
            int Latidue = 53;
            sut.setData(data);
            sut.setLatidue(Latidue);
            double result = sut.getWats();
            Assert.AreEqual(0.31968, result);
        }

        [TestMethod]
        public void Should3()
        {
            CalculateSunEnergy sut = new CalculateSunEnergy();
            DateTime data = new DateTime(2016, 12, 31, 10, 0, 0);
            int Latidue = 53;
            sut.setData(data);
            sut.setLatidue(Latidue);
            double result = sut.getWats();
            Assert.AreEqual(0.31968, result);
        }



    }
}
