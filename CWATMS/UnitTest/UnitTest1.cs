using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CWATMS;
using System.Drawing;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLecturerName()
        {
            Lecturer lec1 = new Lecturer("Geoff", "Grundell", 7, "GG", Color.Red);
            Assert.AreEqual("Geoff", lec1.Name, false);
        }

        [TestMethod]
        public void TestLecturerSurname()
        {
            Lecturer lec1 = new Lecturer("Geoff", "Grundell", 7, "GG", Color.Red);
            Assert.AreEqual("Grundell", lec1.Surname, false);
        }

        [TestMethod]
        public void TestLecturerFullName()
        {
            Lecturer lec1 = new Lecturer("Geoff", "Grundell", 7, "GG", Color.Red);
            Assert.AreEqual("Geoff Grundell", lec1.FullName, false);
        }

        [TestMethod]
        public void TestLecturerInitials()
        {
            Lecturer lec1 = new Lecturer("Geoff", "Grundell", 7, "GG", Color.Red);
            Assert.AreEqual("GG", lec1.Initials, false);
        }
    }
}
