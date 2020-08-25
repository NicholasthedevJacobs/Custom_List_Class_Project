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
            customObject.AddToList(value1);
            customObject.AddToList(value2);
            customObject.AddToList(value3);
            customObject.AddToList(value4);

            customObject[0].RemoveFromList;
            actual = customObject[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Index_Two_Check_Index_One()
        {
            //arrange
            CustomBuiltList<int> customObject = new CustomBuiltList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int expected = 1;
            int actual;

            //act
            customObject.AddToList(value1);
            customObject.AddToList(value2);
            customObject.AddToList(value3);
            customObject.AddToList(value4);

            customObject[2].RemoveFromList;
            actual = customObject[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_From_Index_After_Extended_Check_Capacity_Is_Same()
        {
            //arrange
            CustomBuiltList<int> customObject = new CustomBuiltList<int>();

            int expected = 64;
            int actual;

            //act
            for (int i = 0; i < 37; i++)
            {
                int value = 1 + i;
                customObject.AddToList(value);

            }
            actual = customObject.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
