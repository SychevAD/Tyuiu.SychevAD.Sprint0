using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tuiu.SychevAD.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SychevAD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheekGetMassageValid()
        {
            var name = "Саша";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Саша", res);
        }
    }
}
