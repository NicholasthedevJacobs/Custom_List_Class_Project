using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;

namespace UnitTestProjectCustomListClass
{
    [TestClass]
    public class TestSwapMethods
    {
        [TestMethod]
        public void Copy_Values_From_One_Array_To_Another()
        {
            //arrange
            CustomBuiltList<int> customObject1 = new CustomBuiltList<int>();
            //CustomBuiltList<int> arrayToExtend = new CustomBuiltList<int>();
            int[] arrayToExtend = new int[4];
            customObject1.AddToList(2);
            customObject1.AddToList(3);
            customObject1.AddToList(5);
            customObject1.AddToList(6);


            //act
            customObject1.GenericSwapMethod(ref arrayToExtend);

            //assert
            Assert.AreEqual(arrayToExtend, customObject1);
        }
        public void Test_If_Array_Copies_When_Extended()
        {
            //arrange
            CustomBuiltList<int> customObject1 = new CustomBuiltList<int>();
            int[] arrayToExtend = new int[4];

            customObject1.AddToList(2);
            customObject1.AddToList(3);
            customObject1.AddToList(5);
            customObject1.AddToList(6);
            customObject1.AddToList(8);
            customObject1.AddToList(9);


            //act
            customObject1.GenericSwapMethod(ref arrayToExtend);

            //assert
            Assert.AreEqual(arrayToExtend, customObject1);
        }
    }
}
