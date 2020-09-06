using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;

namespace UnitTestProjectCustomListClass
{
    [TestClass]
    public class ZipperUnitTests
    {
        [TestMethod]
        public void Test_Standard_Zipper()
        {
            //assign
            CustomBuiltList<int> listOne = new CustomBuiltList<int>();
            CustomBuiltList<int> listTwo = new CustomBuiltList<int>();
            CustomBuiltList<int> listThree = new CustomBuiltList<int>();
            CustomBuiltList<int> listFour = new CustomBuiltList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            string actual;
            string expected = "123456";

            listOne.AddToList(value1);
            listOne.AddToList(value3);
            listOne.AddToList(value5);
            listTwo.AddToList(value2);
            listTwo.AddToList(value4);
            listTwo.AddToList(value6);

            //act
            listFour = listThree.Zipper(listOne, listTwo);
            actual = listFour.ToString();

            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void One_Method_Has_More_Values()
        {
            //assign
            CustomBuiltList<int> listOne = new CustomBuiltList<int>();
            CustomBuiltList<int> listTwo = new CustomBuiltList<int>();
            CustomBuiltList<int> listThree = new CustomBuiltList<int>();
            CustomBuiltList<int> listFour = new CustomBuiltList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            string actual;
            string expected = "123456";

            listOne.AddToList(value1);
            listOne.AddToList(value3);
            listTwo.AddToList(value2);
            listTwo.AddToList(value4);
            listOne.AddToList(value5);
            listOne.AddToList(value6);

            //act
            listFour = listThree.Zipper(listOne, listTwo);
            actual = listFour.ToString();

            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Neither_List_Has_Values()
        {
            //assign
            CustomBuiltList<int> listOne = new CustomBuiltList<int>();
            CustomBuiltList<int> listTwo = new CustomBuiltList<int>();
            CustomBuiltList<int> listThree = new CustomBuiltList<int>();
            CustomBuiltList<int> listFour = new CustomBuiltList<int>();
            string actual;
            string expected = "";

            //act
            listFour = listThree.Zipper(listOne, listTwo);
            actual = listFour.ToString();

            //assert
            Assert.AreEqual(actual, expected);
        }

    }
}
