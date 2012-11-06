using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CWATMS.UnitTest
{
    [TestClass]
    public class GroupTest
    {
      [TestMethod]
        public void GroupConstructorTest()
        {
            Group g = new Group("Class1", "C1", Color.Blue, 20);
            Assert.AreEqual("Class1", g.Name);
            Assert.AreEqual("C1", g.Label);
            Assert.AreEqual<Color>(Color.Blue, g.Colour);
            Assert.AreEqual<int>(20, g.TotalStudents);

        }
    }
}
