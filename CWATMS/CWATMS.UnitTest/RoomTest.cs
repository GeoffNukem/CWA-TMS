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
        public void Room_Constructor()
        {
            Room r = new Room("Network Lab", "Y106", Color.Blue, 20);
            Assert.AreEqual("Network Lab", r.Name);
            Assert.AreEqual("Y106", r.Label);
            Assert.AreEqual<Color>(Color.Blue, r.Colour);
            Assert.AreEqual<int>(20, r.Capacity);
        }

        [TestMethod]
        public void Room_Add()
        {
            Room r1 = new Room("Room1", "L1", Color.Blue, 20);
            Room r2 = new Room("Room2", "L2", Color.Blue, 19);
            Room r3 = new Room("Room3", "L3", Color.Blue, 17);

            DataCollection.Instance.Add(r1);
            DataCollection.Instance.Add(r2);
            DataCollection.Instance.Add(r3);

            DataCollection.Instance.Add(r1);
            Assert.AreEqual<Room>(r1, DataCollection.Instance.Rooms[0], "Room1 not found at 0");

            DataCollection.Instance.Add(r2);
            Assert.AreEqual<Room>(r2, DataCollection.Instance.Rooms[1], "Room2 not found at 1");

            DataCollection.Instance.Insert(r3, 1);
            Assert.AreEqual<Room>(r3, DataCollection.Instance.Rooms[1], "Room3 not found at 1");
            Assert.AreEqual<Room>(r2, DataCollection.Instance.Rooms[2], "Room2 not found at 2");
        }
    }
}
