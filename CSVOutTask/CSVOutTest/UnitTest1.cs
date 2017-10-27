using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSVOutTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
          CSVTask.CSVClass csv = new CSVTask.CSVClass();
            csv.ReadCSV();
                 
        }
    }
}
