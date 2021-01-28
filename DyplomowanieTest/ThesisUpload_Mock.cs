using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dyplomowanie;
using Moq;
using System;

namespace DyplomowanieTest
{
    //Testy z użyciem MOCK
    [TestClass]
    public class ThesisUpload_Mock
    {
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

        [TestMethod]
        public void ThesisNotUploded_MockTest()
        {
            var mock = new Mock<IThesisUpload>();
            DiplomaProcess dp = new DiplomaProcess(mock.Object);
            DateTime dt = new DateTime(2021, 1, 1);
            mock.Object.Update("ABC");
            mock.Verify(x => x.Check(), Times.Never);
        }


    }
}
