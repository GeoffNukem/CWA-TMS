using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CWATMS;
using System.Drawing;

namespace CWATMS.UnitTest
{
    [TestClass]
    public class LecturerTest
    {
        Lecturer l;
        public LecturerTest()
        {
            l = new Lecturer("Joe", "Bloggs", 14, "JB", Color.Blue);
        }

        [TestMethod]
        public void Lecturer_FirstName()
        {
            Assert.AreEqual("Joe", l.Name);
        }

        [TestMethod]
        public void Lecturer_Surname()
        {
            Assert.AreEqual("Bloggs", l.Surname);
        }

        [TestMethod]
        public void Lecturer_Label()
        {
            Assert.AreEqual("JB", l.Label);
        }

        [TestMethod]
        public void Lecturer_Initials()
        {
            Assert.AreEqual("JB", l.Initials);
        }

        [TestMethod]
        public void Lecturer_FullName()
        {
            Assert.AreEqual("Joe Bloggs", l.FullName);
        }

        [TestMethod]
        public void Lecturer_HoursPerWeek()
        {
            Assert.AreEqual<int>(14, l.HoursPerWeek);
        }

        [TestMethod]
        public void Lecturer_Colour()
        {
            Assert.AreEqual<Color>(Color.Blue, l.Colour);
        }
        
    }
}
