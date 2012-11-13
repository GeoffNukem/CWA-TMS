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
