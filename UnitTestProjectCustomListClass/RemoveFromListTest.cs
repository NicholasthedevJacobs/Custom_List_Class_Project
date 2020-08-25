using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;

namespace UnitTestProjectCustomListClass
{
    [TestClass]
    public class RemoveFromListTest
    {
        
        [TestMethod]
        public void Remove_Value_At_Index_Zero()
        {
            //arrange
            CustomBuiltList<int> customObject = new CustomBuiltList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int expected = 2;
            int actual;

            //act
            customObject[0].RemoveFromList;
            actual = customObject[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Index_Two_Check_Index_One()
        {

        }


      
    }
}
