using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CWATMS;

namespace CWATMS.UnitTest
{
    [TestClass]
    public class ModuleTest
    {
        [TestMethod]
        public void ModuleConstructorTest()
        {
            Module m = new Module("Programming", "Level 3", "PL3", Color.Blue);
            Assert.AreEqual("Programming", m.Name);
            Assert.AreEqual("Level 3", m.CourseLevel);
            Assert.AreEqual("PL3", m.Label);
            Assert.AreEqual<Color>(Color.Blue, m.Colour);
        }

    }
}
