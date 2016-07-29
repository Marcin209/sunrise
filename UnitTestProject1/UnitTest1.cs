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
            int Latidue = 15;
            sut.setData(data);
            sut.setLatidue(Latidue);
            double result = sut.getWats();
            Assert.AreEqual(0.821429736026901, result);
        }
        [TestMethod]
        public void Should()
        {
            CalculateSunEnergy sut = new CalculateSunEnergy();
            DateTime data = new DateTime(2016, 2, 29, 8, 0, 0);
            int Latidue = 15;
            sut.setData(data);
            sut.setLatidue(Latidue);
            double result = sut.getWats();
            Assert.AreEqual(0.81957279699043839, result);
        }
        [TestMethod]
        public void Should2()
        {
            CalculateSunEnergy sut = new CalculateSunEnergy();
            DateTime data = new DateTime(2016, 1,1, 8, 0, 0);
            int Latidue = 15;
            sut.setData(data);
            sut.setLatidue(Latidue);
            double result = sut.getWats();
            Assert.AreEqual(0.81857892700918289, result);
        }

        [TestMethod]
        public void Should3()
        {
            CalculateSunEnergy sut = new CalculateSunEnergy();
            DateTime data = new DateTime(2016, 12, 31, 8, 0, 0);
            int Latidue = 15;
            sut.setData(data);
            sut.setLatidue(Latidue);
            double result = sut.getWats();
            Assert.AreEqual(0.81857763919553383, result);
        }



    }
}
