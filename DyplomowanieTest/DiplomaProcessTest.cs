using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dyplomowanie;
using System;

namespace DyplomowanieTest
{
    [TestClass]
    public class DiplomaProcessTest
    {
        [TestMethod]
        public void SetNextStage_Test()
        {
            DateTime date = new DateTime(2021, 11, 1);
            bool expected = false;
            var Dyplomowanie = new DiplomaProcess(date);
            bool actual = Dyplomowanie.ActualStage.Check();
            Assert.AreEqual<bool>(expected, actual);
        }


    }
}
