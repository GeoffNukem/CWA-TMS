using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CWATMS.UnitTest
{
    [TestClass]
    public class DataValidationTest
    {
        /// <summary>
        /// Test the ContainsNumbers method in the DataValidation class.
        /// </summary>
        [TestMethod]
        public void Data_ContainsNumbers()
        {
            Assert.IsFalse(DataValidation.Instance.ContainsNumbers("ABC"));
            Assert.IsTrue(DataValidation.Instance.ContainsNumbers("ABC123"));
        }

        [TestMethod]
        public void Data_IsInRange()
        {
            //  Test 1: 5 is between 0 & 10.
            Assert.IsTrue(DataValidation.Instance.IsInRange(5, 0, 10), "Failed @ test 1");

            //  Test 2: 3 is between 1 & 3, with lessThanOrEqualTo set to true.
            Assert.IsTrue(DataValidation.Instance.IsInRange(3, 1, 3, true), "Failed @ test 2");

            //  Test 3: 1 is between 1 & 3, with lessThanOrEqualTo set to true.
            Assert.IsTrue(DataValidation.Instance.IsInRange(1, 1, 3, true), "Failed @ test 3");

            //  Test 4: 20 is out of range.
            Assert.IsFalse(DataValidation.Instance.IsInRange(20, 0, 10), "Failed @ test 4");

            //  Test 5: 12 is out of range of 3 & 12 as lessThanOrEqualTo set to false.
            Assert.IsFalse(DataValidation.Instance.IsInRange(12, 3, 12), "Failed @ test 5");
            
        }
    }
}
