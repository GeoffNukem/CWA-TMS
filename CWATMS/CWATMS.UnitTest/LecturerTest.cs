using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CWATMS;
using System.Drawing;

namespace CWATMS.UnitTest
{
    [TestClass]
    public class LecturerTest
    {
        
        [TestMethod]
        public void LecturerConstructorTest()
        {
            Lecturer l = new Lecturer("Joe", "Bloggs", 14, "JB", Color.Blue);
            Assert.AreEqual("Joe", l.Name);
            Assert.AreEqual("Bloggs", l.Surname);
            Assert.AreEqual("JB", l.Label);
            Assert.AreEqual("JB", l.Initials);
            Assert.AreEqual("Joe Bloggs", l.FullName);
            Assert.AreEqual<int>(14, l.HoursPerWeek);
            Assert.AreEqual<Color>(Color.Blue, l.Colour);
        }
        
    }
}
