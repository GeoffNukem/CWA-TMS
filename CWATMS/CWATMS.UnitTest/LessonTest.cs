using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CWATMS.UnitTest
{
    [TestClass]
    public class LessonTest
    {
        [TestMethod]
        public void Lesson_Constructor()
        {
            Lesson lesson = new Lesson();
            Assert.AreEqual(null, lesson.Lecturer, "Failed to match Lecturer after Construtor");
            Assert.AreEqual(null, lesson.Module, "Failed to match Module after Construtor");
            Assert.AreEqual(null, lesson.Room, "Failed to match Room after Construtor");
            Assert.AreEqual(null, lesson.Group, "Failed to match Group after Construtor");

            Lecturer lect = new Lecturer("Fred Flintstone", 12, "FF", Color.White);
            lesson.Lecturer = lect;
            Assert.AreEqual(lect, lesson.Lecturer, "Lecturer Property failed");

            Module mod = new Module("Software Engineering", "Degree", "SED", Color.White);
            lesson.Module = mod;
            Assert.AreEqual(mod, lesson.Module, "Module Property failed");

            Room room = new Room("Y007", "007", Color.Bisque, 30);
            lesson.Room = room;
            Assert.AreEqual(room, lesson.Room, "Room Property failed");

            Group grp = new Group("Group A", "GrA", Color.DarkSeaGreen, 24);
            lesson.Group = grp;
            Assert.AreEqual(grp, lesson.Group, "Group Property failed");

        }

        [TestMethod]
        public void Lesson_Add()
        {
            Lesson lesson1 = new Lesson();
            Lesson lesson2 = new Lesson();
            Lesson lesson3 = new Lesson();

            Lecturer l1 = new Lecturer("Joe Bloggs", 14, "JB", Color.Blue);
            Lecturer l2 = new Lecturer("John Smith", 32, "JS1", Color.Blue);
            Lecturer l3 = new Lecturer("Fred Flintstone", 50, "FF", Color.Blue);

            Module m1 = new Module("Programming", "Level 3", "PL3", Color.Blue);
            Module m2 = new Module("Networking", "Degree", "NET", Color.Blue);
            Module m3 = new Module("Technical Support", "Level 1", "Tech1", Color.Blue);

            Room r1 = new Room("Room1", "L1", Color.Blue, 20);
            Room r2 = new Room("Room2", "L2", Color.Blue, 19);
            Room r3 = new Room("Room3", "L3", Color.Blue, 17);

            Group g1 = new Group("Class1", "C1", Color.Blue, 20);
            Group g2 = new Group("Class2", "C2", Color.Blue, 20);
            Group g3 = new Group("Class3", "C3", Color.Blue, 20);

            lesson1.Lecturer = l1;
            lesson1.Module = m1;
            lesson1.Group = g1;
            lesson1.Room = r1;

            lesson2.Lecturer = l2;
            lesson2.Module = m2;
            lesson2.Group = g2;
            lesson2.Room = r2;

            lesson3.Lecturer = l3;
            lesson3.Module = m3;
            lesson3.Group = g3;
            lesson3.Room = r3;


            DataCollection.Instance.Add(lesson1);
            Assert.AreEqual<Lesson>(lesson1, DataCollection.Instance.Lessons[0], "Lesson1 not found at 0");

            //  Add another instance and check if this instance is in the second index (1)
            DataCollection.Instance.Add(lesson2);
            Assert.AreEqual<Lesson>(lesson2, DataCollection.Instance.Lessons[1], "Lesson2 not found at 1");

            //  Insert an instance into the second index (1) and check if the instance is at that index and the instance
            //    before has moved to the next index (2)
            DataCollection.Instance.Insert(lesson3, 1);
            Assert.AreEqual<Lesson>(lesson3, DataCollection.Instance.Lessons[1], "Lesson3 not found at 1");
            Assert.AreEqual<Lesson>(lesson2, DataCollection.Instance.Lessons[2], "Lesson2 not found at 2");

        }


        [TestMethod]
        public void Lesson_Clash_Test()
        {
            /*
             * Set instances: 2 Lessons with different data
             */
            Lesson lesson1 = new Lesson();
            Lesson lesson2 = new Lesson();

            Lecturer l1 = new Lecturer("Joe Bloggs", 14, "JB", Color.Blue);
            Lecturer l2 = new Lecturer("John Smith", 32, "JS1", Color.Blue);

            Module m1 = new Module("Programming", "Level 3", "PL3", Color.Blue);
            Module m2 = new Module("Networking", "Degree", "NET", Color.Blue);

            Room r1 = new Room("Room1", "L1", Color.Blue, 20);
            Room r2 = new Room("Room2", "L2", Color.Blue, 19);

            Group g1 = new Group("Class1", "C1", Color.Blue, 20);
            Group g2 = new Group("Class2", "C2", Color.Blue, 20);

            /*
             * Set so that each Lesson has different data, except the same time and day
             */
            lesson1.Lecturer = l1;
            lesson1.Module = m1;
            lesson1.Group = g1;
            lesson1.Room = r1;

            lesson2.Lecturer = l2;
            lesson2.Module = m2;
            lesson2.Group = g2;
            lesson2.Room = r2;

            lesson1.Time = 1;
            lesson1.Day = 1;

            lesson2.Time = 1;
            lesson2.Day = 1;

            DataCollection.Instance.Add(lesson1);
            DataCollection.Instance.Add(lesson2);

            /*
             *  Test if there is NO clash.
             *  Each lesson is different.
             */
            Assert.IsFalse(DataCollection.Instance.DoesLessonClash(lesson1), "Detected a clash when values should not");

            /*
             *  Set lesson2 to have the same Room as lesson1.
             *  Test for clash: Same Room holding different Lessons.
             */
            lesson2.Room = r1;
            Assert.IsTrue(DataCollection.Instance.DoesLessonClash(lesson1), "Did not detect a clash with the same Room when it should");
            lesson2.Room = r2;

            /*
             *  Set lesson2 to have the same Lecturer as lesson1.
             *  Test for clash: Same Lecturer at different Lessons.
             */
            lesson2.Lecturer = l1;
            Assert.IsTrue(DataCollection.Instance.DoesLessonClash(lesson1), "Did not detect a clash with the same Lecturer when it should");
            lesson2.Lecturer = l2;

            /*
             *  Set lesson2 to have the same Group as lesson1.
             *  Test for clash: Same Group at different Lessons
             */
            lesson2.Group = g1;
            Assert.IsTrue(DataCollection.Instance.DoesLessonClash(lesson1), "Did not detect a clash with the same Group when it should");
            lesson2.Group = g2;

            /*
             *  Set lesson2 to have the same Module as lesson1.
             *  Test for NO clash: Same Module at different Lessons.
             */
            lesson2.Module = m1;
            Assert.IsFalse(DataCollection.Instance.DoesLessonClash(lesson1), "Did not detect a clash with the same Module when it should");
            lesson2.Module = m2;
        }
    }
}
