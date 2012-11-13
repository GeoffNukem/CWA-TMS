﻿using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CWATMS;

namespace CWATMS.UnitTest
{
    [TestClass]
    public class ModuleTest
    {
        [TestMethod]
        public void Module_Constructor()
        {
            Module m = new Module("Programming", "Level 3", "PL3", Color.Blue);
            Assert.AreEqual("Programming", m.Name);
            Assert.AreEqual("Level 3", m.CourseLevel);
            Assert.AreEqual("PL3", m.Label);
            Assert.AreEqual<Color>(Color.Blue, m.Colour);
        }

        [TestMethod]
        public void Module_Add()
        {
            Module m1 = new Module("Programming", "Level 3", "PL3", Color.Blue);
            Module m2 = new Module("Networking", "Degree", "NET", Color.Blue);
            Module m3 = new Module("Technical Support", "Level 1", "Tech1", Color.Blue);

            DataCollection.Instance.Add(m1);
            Assert.AreEqual<Module>(m1, DataCollection.Instance.Modules[0], "Module1 not found at 0");

            DataCollection.Instance.Add(m2);
            Assert.AreEqual<Module>(m2, DataCollection.Instance.Modules[1], "Module2 not found at 1");

            DataCollection.Instance.Insert(m3, 1);
            Assert.AreEqual<Module>(m3, DataCollection.Instance.Modules[1], "Module3 not found at 1");
            Assert.AreEqual<Module>(m2, DataCollection.Instance.Modules[2], "Module2 not found at 2");
        }

    }
}
