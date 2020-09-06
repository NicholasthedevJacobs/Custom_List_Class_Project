using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;

namespace UnitTestProjectCustomListClass
{
    [TestClass]
    public class ZipperUnitTests
    {
        [TestMethod]
        public void Test_When_Lists_Have_Equal_Number_Of_Values()
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
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            string actual;
            string expected = "123";

            listOne.AddToList(value1);
            listOne.AddToList(value2);
            listOne.AddToList(value3);

            //act
            listFour = listThree.Zipper(listOne, listTwo);
            actual = listFour.ToString();

            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void One_List_Has_No_Values()
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
        [TestMethod]
        public void Test_When_Both_Lists_Have_More_Than_Five_Values()
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
            int value7 = 7;
            int value8 = 8;
            int value9 = 9;
            int value10 = 10;
            string actual;
            string expected = "12345678910";

            listOne.AddToList(value1);
            listOne.AddToList(value3);
            listOne.AddToList(value5);
            listOne.AddToList(value7);
            listOne.AddToList(value9);
            listTwo.AddToList(value2);
            listTwo.AddToList(value4);
            listTwo.AddToList(value6);
            listTwo.AddToList(value8);
            listTwo.AddToList(value10);

            //act
            listFour = listThree.Zipper(listOne, listTwo);
            actual = listFour.ToString();

            //assert
            Assert.AreEqual(actual, expected);

        }
    }
}
