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
        public void Lecturer_Constructor()
        {
            Lecturer l = new Lecturer("Joe Bloggs", 14, "JB", Color.Blue);
            Assert.AreEqual("Joe", l.Name);
            Assert.AreEqual("JB", l.Label);
            Assert.AreEqual<int>(14, l.HoursPerWeek);
            Assert.AreEqual<Color>(Color.Blue, l.Colour);
        }

        [TestMethod]
        public void Lecturer_Add()
        {
            //  Create test instances
            Lecturer l = new Lecturer("Joe Bloggs", 14, "JB", Color.Blue);
            Lecturer l2 = new Lecturer("John Smith", 32, "JS1", Color.Blue);
            Lecturer l3 = new Lecturer("Fred Flintstone", 50, "FF", Color.Blue);

            //  Add an instance to the list and check if the instance is in the first index (0)
            DataCollection.Instance.Add(l);
            Assert.AreEqual<Lecturer>(l, DataCollection.Instance.Lecturers[0], "Lecturer1 not found at 0");

            //  Add another instance and check if this instance is in the second index (1)
            DataCollection.Instance.Add(l2);
            Assert.AreEqual<Lecturer>(l2, DataCollection.Instance.Lecturers[1], "Lecturer2 not found at 1");

            //  Insert an instance into the second index (1) and check if the instance is at that index and the instance
            //    before has moved to the next index (2)
            DataCollection.Instance.Insert(l3, 1);
            Assert.AreEqual<Lecturer>(l3, DataCollection.Instance.Lecturers[1], "Lecturer3 not found at 1");
            Assert.AreEqual<Lecturer>(l2, DataCollection.Instance.Lecturers[2], "Lecturer2 not found at 2");
        }

    }
}
