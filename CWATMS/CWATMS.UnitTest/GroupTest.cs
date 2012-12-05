using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CWATMS.UnitTest
{
    [TestClass]
    public class GroupTest
    {
        [TestMethod]
        public void Group_Constructor()
        {
            Group g = new Group("Class1", "C1", Color.Blue, 20);
            Assert.AreEqual("Class1", g.Name);
            Assert.AreEqual("C1", g.Label);
            Assert.AreEqual<Color>(Color.Blue, g.Colour);
            Assert.AreEqual<int>(20, g.TotalStudents);
        }

        [TestMethod]
        public void Room_GetterAndSetter()
        {
            Room r = new Room("", "", Color.Empty, 0);
            r.Name = "Y106";
            r.Label = "106";
            r.Colour = Color.Crimson;
            r.Capacity = 69;
            Assert.AreEqual("Y106", r.Name);
            Assert.AreEqual("106", r.Label);
            Assert.AreEqual<Color>(Color.Crimson, r.Colour);
            Assert.AreEqual<int>(69, r.Capacity);
        }

        [TestMethod]
        public void Group_Remove()
        {
            Group g = new Group("Class1", "C1", Color.Blue, 20);
            DataCollection.Instance.Add(g);
            Assert.IsTrue(DataCollection.Instance.Groups.Contains(g), "Groups does not contain Group");
            DataCollection.Instance.Remove(g);
            Assert.IsFalse(DataCollection.Instance.Groups.Contains(g), "Groups still contains Group");
        }

        [TestMethod]
        public void Group_Add()
        {
            Group g1 = new Group("Class1", "C1", Color.Blue, 20);
            Group g2 = new Group("Class2", "C2", Color.Blue, 20);
            Group g3 = new Group("Class3", "C3", Color.Blue, 20);

            DataCollection.Instance.Add(g1);
            Assert.AreEqual<Group>(g1, DataCollection.Instance.Groups[0], "Class1 not found at 0");

            DataCollection.Instance.Add(g2);
            Assert.AreEqual<Group>(g2, DataCollection.Instance.Groups[1], "Class2 not found at 1");

            DataCollection.Instance.Insert(g3, 1);
            Assert.AreEqual<Group>(g3, DataCollection.Instance.Groups[1], "Class3 not found at 1");
            Assert.AreEqual<Group>(g2, DataCollection.Instance.Groups[2], "Class2 not found at 2");
        }

    }
}
