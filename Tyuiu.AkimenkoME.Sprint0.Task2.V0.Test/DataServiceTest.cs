using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AkimenkoME.Sprint0.Lib;

namespace Tyuiu.AkimenkoME.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Мария";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Мария", res);
        }
    }
}
