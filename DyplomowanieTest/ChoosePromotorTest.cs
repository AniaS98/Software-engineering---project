using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dyplomowanie;
using System;

namespace DyplomowanieTest
{
    [TestClass]
    public class ChoosePromotorTest
    {

        [TestMethod]
        public void DeadlineCheck_Test()
        {
            DateTime date = new DateTime(2021, 11, 1);
            DateTime testing = new DateTime(2021, 11, 2);
            bool expected = false;
            var Dyplomowanie = new ChoosePromotor(date);
            bool actual = Dyplomowanie.DeadlineCheck(testing);
            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod]
        public void DeadlineCheck_Test2()
        {
            DateTime date2 = new DateTime(2020, 1, 1);
            DateTime testing = new DateTime(2021, 1, 2);
            bool expected = true;
            var Dyplomowanie = new ChoosePromotor(date2);
            bool actual = Dyplomowanie.DeadlineCheck(testing);
            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod]
        public void Check_Test()
        {
            var Dyplomowanie = new ChoosePromotor(DateTime.Now);
            bool expected = false;
            bool current = Dyplomowanie.Check();
            Assert.AreEqual(expected, current);
        }

    }
}
