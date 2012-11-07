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
        public void Room_Constructor_Test()
        {
            Room r = new Room("Network Lab", "Y106", Color.Blue, 20);
            Assert.AreEqual("Network Lab", r.Name);
            Assert.AreEqual("Y106", r.Label);
            Assert.AreEqual<Color>(Color.Blue, r.Colour);
            Assert.AreEqual<int>(20, r.Capacity);
        }

        [TestMethod]
        public void Room_Add_Test()
        {
            Room r1 = new Room("Room1", "L1", Color.Blue, 20);
            Room r2 = new Room("Room2", "L2", Color.Blue, 19);
            Room r3 = new Room("Room3", "L3", Color.Blue, 17);

            DataCollection.Instance.Add(r1);
            DataCollection.Instance.Add(r2);
            DataCollection.Instance.Add(r3);
        }
    }
}
