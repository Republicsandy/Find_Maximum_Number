using Microsoft.VisualStudio.TestTools.UnitTesting;
using Find_Max_Num_Using_Generics;

namespace Find_Max_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(9, 4, 1)]
        [DataRow(43, 32, 11)]
        public void Int_Max_Number_First_Position_Return_Max(int firstValue, int secondValue, int thirdValue)
        {
            int expected = firstValue;
            int result = Max_Num_Check.MaxIntgerNum(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [DataRow(9, 23, 1)]
        [DataRow(43, 65, 11)]
        public void Int_Max_Number_Second_Position_Return_Max(int firstValue, int secondValue, int thirdValue)
        {
            int expected = secondValue;
            int result = Max_Num_Check.MaxIntgerNum(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [DataRow(9, 4, 43)]
        [DataRow(43, 32, 85)]
        public void Int_Max_Number_Third_Position_Return_Max(int firstValue, int secondValue, int thirdValue)
        {
            int expected = thirdValue;
            int result = Max_Num_Check.MaxIntgerNum(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, result);
        }
    }
}
