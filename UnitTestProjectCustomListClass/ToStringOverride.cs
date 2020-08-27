using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;

namespace UnitTestProjectCustomListClass
{
    [TestClass]
    public class ToStringOverride
    {
        [TestMethod]
        public void Test_If_List_Is_Converted_To_String()
        {
            //arrange
            CustomBuiltList<int> customObject = new CustomBuiltList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            string expected = "1234";
            string actual;

            //act
            customObject.AddToList(value1);
            customObject.AddToList(value2);
            customObject.AddToList(value3);
            customObject.AddToList(value4);
            actual = customObject.ToString();

            //assert
            Assert.AreEqual(actual, expected);

        }
        [TestMethod]
        public void Test_Return_If_List_Empty()
        {
            //arrange
            CustomBuiltList<int> customObject = new CustomBuiltList<int>();
            string expected = "No More Values.";
            string actual;

            //act
            actual = customObject.ToString();

            //assert
            Assert.AreEqual(actual, expected);
        }
    }
}
