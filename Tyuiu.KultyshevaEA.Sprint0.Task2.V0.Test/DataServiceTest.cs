using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KultyshevaEA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KultyshevaEA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Катя";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Катя!", res);
        }
    }
}
