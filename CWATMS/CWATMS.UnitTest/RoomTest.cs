using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CWATMS;
using System.Drawing;

namespace CWATMS.UnitTest
{
    [TestClass]
    public class RoomTest
    {
        Room r;
        public RoomTest()
        {
            r = new Room("Network Lab", "Y106", Color.Blue, 20);
        }

        [TestMethod]
        public void Room_Name()
        {
            Assert.AreEqual("Network Lab", r.Name);
        }

        [TestMethod]
        public void Room_Label()
        {
            Assert.AreEqual("Y106", r.Label);
        }

        [TestMethod]
        public void Room_Colour()
        {
            Assert.AreEqual<Color>(Color.Blue, r.Colour);
        }

        [TestMethod]
        public void Room_Capacity()
        {
            Assert.AreEqual<int>(20, r.Capacity);
        }
    }
}
