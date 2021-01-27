using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dyplomowanie;
using System;
using Moq;

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

        [TestMethod]
        public void ThesisUploded_MockTest()
        {
            var mock = new Mock<IThesisUpload>();
            DiplomaProcess dp = new DiplomaProcess(mock.Object);
            DateTime dt = new DateTime(2021, 1, 1);
            mock.Object.Update("ABC");
            dp.Stage.Check();
            mock.Verify(x => x.Check(), Times.Once);
        }

    }
}
