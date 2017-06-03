using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RivsConsoleTest;

namespace RIVSConsoleUnitTest
{
    [TestClass]
    public class BasicTest
    {
        [TestMethod]
        public void TestSimplify()
        {
            int[] data;
            //Factory object creation 
            Factory factory = new Factory();
            //getting respective objects from factory
            DataProcessor DP = factory.DataProcessorObject();
            DataPrinter printer = factory.DataPrinterObject();
            DataPreparation dataPreparation = factory.DataPreparationObject();

            //getting the input data
            data = dataPreparation.GetData();
            //processing the data
            int[] sortedArray = DP.Simplify(data);
            int[] expectedOutput = {0, 3,5,8,9 };
            CollectionAssert.AreEqual(expectedOutput, sortedArray);

        }
    }
}
