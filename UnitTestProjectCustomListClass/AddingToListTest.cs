using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;

namespace UnitTestProjectCustomListClass
{
    [TestClass]
    public class AddingToListTest
    {
        [TestMethod]
        public void Test_Adding_Two_Values() 
        {                      
            //arrange
            CustomBuiltList<int> customObject = new CustomBuiltList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 2;
            int actual;

            //act

            customObject.AddToList(value1);
            customObject.AddToList(value2);
            actual = customObject.ListCount;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Count_Objects_To_4()
        {
            //arrange
            CustomBuiltList<int> customObject = new CustomBuiltList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int expected = 4;
            int actual;

            //act

            customObject.AddToList(value1);
            customObject.AddToList(value2);
            customObject.AddToList(value3);
            customObject.AddToList(value4);
            actual = customObject.ListCount;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Count_Objects_To_37()
        {
            //arrange
            CustomBuiltList<int> customObject = new CustomBuiltList<int>();
            int expected = 37;
            int actual;
            //act

            //Wants to check if over 37, because the previous maximum length of the array would be 36.  This makes sure the array can 
            //extend itself multiple times, and maintain its function.
            for (int i = 0; i < 37; i++)
            {
                int value = 1 + i;
                customObject.AddToList(value);
              
            }
            actual = customObject.ListCount;
        
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_Index_At_0()
        {
            //arrange
            CustomBuiltList<int> customObject = new CustomBuiltList<int>();
            int value1 = 42;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int expected = 42;
            int actual;

            //act

            customObject.AddToList(value1);
            customObject.AddToList(value2);
            customObject.AddToList(value3);
            customObject.AddToList(value4);
            actual = customObject[0];

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_Capacity_After_Extended()
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
            //Console.ReadLine();
        }       
        public void Add_Two_Values_To_Get_Capactiy_Of_Four()
        {
            //arrange

            CustomBuiltList<int> customObject = new CustomBuiltList<int>();
            int value1 = 3;
            int value2 = 5;
            int expected = 4;
            int actual;

            //act
            customObject.AddToList(value1);
            customObject.AddToList(value2);
            actual = customObject.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }
        
    }   
}
