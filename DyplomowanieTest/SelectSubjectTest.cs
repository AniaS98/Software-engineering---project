using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dyplomowanie;
using System;

namespace DyplomowanieTest
{
    //Testy Pokrycia

    [TestClass]
    public class SelectSubjectTest
    {
        [TestMethod]
        public void SelectSubjectTest_OnTime()
        {
            DateTime date = new DateTime(2021, 1, 1);
            DateTime testing = new DateTime(2021, 1, 2);
            bool expected = true;
            var Dyplomowanie = new SelectSubject(date);
            bool actual = Dyplomowanie.DeadlineCheck(testing);
            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod]
        public void SelectSubjectTest_NotOnTime()
        {
            DateTime date = new DateTime(2021, 1, 1);
            DateTime testing = new DateTime(2021, 1, 10);
            bool expected = false;
            var Dyplomowanie = new SelectSubject(date);
            bool actual = Dyplomowanie.DeadlineCheck(testing);
            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod]
        public void SelectSubjectTest_BeforeFinalDeadline()
        {
            DateTime date = new DateTime(2021, 1, 1);
            DateTime testing = new DateTime(2021, 8, 25);
            bool expected = true;
            var Dyplomowanie = new SelectSubject(date);
            bool actual = Dyplomowanie.DeadlineCheck(testing);
            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod]
        public void SelectSubjectTest_AfterFinalDeadline()
        {
            DateTime date = new DateTime(2021, 1, 1);
            DateTime testing = new DateTime(2021, 9, 2);
            bool expected = false;
            var Dyplomowanie = new SelectSubject(date);
            bool actual = Dyplomowanie.DeadlineCheck(testing);
            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod]
        public void SelectSubjectTest_Subject()
        {
            DateTime date = new DateTime(2021, 1, 1);
            DateTime testing = new DateTime(2021, 1, 2);
            bool expected = true;
            var Dyplomowanie = new SelectSubject(date);
            Dyplomowanie.Update("ABC");
            bool actual = Dyplomowanie.Check();
            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod]
        public void SelectSubjectTest_SubjectSigns()
        {
            DateTime date = new DateTime(2021, 1, 1);
            DateTime testing = new DateTime(2021, 1, 2);
            bool expected = true;
            var Dyplomowanie = new SelectSubject(date);
            Dyplomowanie.Update("./\'");
            bool actual = Dyplomowanie.Check();
            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod]
        public void SelectSubjectTest_SubjectNumbers()
        {
            DateTime date = new DateTime(2021, 1, 1);
            DateTime testing = new DateTime(2021, 1, 2);
            bool expected = true;
            var Dyplomowanie = new SelectSubject(date);
            Dyplomowanie.Update("123");
            bool actual = Dyplomowanie.Check();
            Assert.AreEqual<bool>(expected, actual);
        }

        [TestMethod]
        public void SelectSubjectTest_NoSubject()
        {
            DateTime date = new DateTime(2021, 1, 1);
            DateTime testing = new DateTime(2021, 1, 2);
            bool expected = true;
            var Dyplomowanie = new SelectSubject(date);
            Dyplomowanie.Update("");
            bool actual = Dyplomowanie.Check();
            Assert.AreEqual<bool>(expected, actual);
        }


    }
}
