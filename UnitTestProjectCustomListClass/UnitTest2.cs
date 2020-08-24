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
        public void 
    }
}
