using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CWATMS;
using System.Drawing;

namespace CWATMS.UnitTest
{
    [TestClass]
    public class RoomTest
    {
        [TestMethod]
        public void RoomConstructorTest()
        {
            Room r = new Room("Network Lab", "Y106", Color.Blue, 20);
            Assert.AreEqual("Network Lab", r.Name);
            Assert.AreEqual("Y106", r.Label);
            Assert.AreEqual<Color>(Color.Blue, r.Colour);
            Assert.AreEqual<int>(20, r.Capacity);
        }
    }
}
