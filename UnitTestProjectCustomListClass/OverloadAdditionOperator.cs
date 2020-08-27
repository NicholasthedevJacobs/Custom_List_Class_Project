using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;

namespace UnitTestProjectCustomListClass
{
    [TestClass]
    public class OverloadAdditionOperator
    {
        [TestMethod]
        public void Test_If_Lists_Can_Be_Added_Into_New_List()
        {
            //assign
            CustomBuiltList<int> listOne = new CustomBuiltList<int>();
            CustomBuiltList<int> listTwo = new CustomBuiltList<int>();
            CustomBuiltList<int> listThree = new CustomBuiltList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            string actual;
            string expected = "135246";

            listOne.AddToList(value1);
            listOne.AddToList(value3);
            listOne.AddToList(value5);
            listTwo.AddToList(value2);
            listTwo.AddToList(value4);
            listTwo.AddToList(value6);

            //act
            listThree = listOne + listTwo;
            actual = listThree.ToString();

            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void One_List_Has_Values_One_Does_Not()
        {
            //assign
            CustomBuiltList<int> listOne = new CustomBuiltList<int>();
            CustomBuiltList<int> listTwo = new CustomBuiltList<int>();
            CustomBuiltList<int> listThree = new CustomBuiltList<int>();
            int value1 = 1;
            int value3 = 3;
            int value5 = 5;
            string actual;
            string expected = "135";

            listOne.AddToList(value1);
            listOne.AddToList(value3);
            listOne.AddToList(value5);

            //act
            listThree = listOne + listTwo;
            actual = listThree.ToString();

            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void One_List_Has_More_Values_Than_The_Other()
        {
            //assign
            CustomBuiltList<int> listOne = new CustomBuiltList<int>();
            CustomBuiltList<int> listTwo = new CustomBuiltList<int>();
            CustomBuiltList<int> listThree = new CustomBuiltList<int>();
            int value1 = 1;
            int value3 = 3;
            int value5 = 5;
            int value2 = 2;
            int value4 = 4;
            string actual;
            string expected = "13524";

            listOne.AddToList(value1);
            listOne.AddToList(value3);
            listOne.AddToList(value5);
            listTwo.AddToList(value2);
            listTwo.AddToList(value4);

            //act
            listThree = listOne + listTwo;
            actual = listThree.ToString();

            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Neither_List_Has_Any_Values()
        {
            //assign
            CustomBuiltList<int> listOne = new CustomBuiltList<int>();
            CustomBuiltList<int> listTwo = new CustomBuiltList<int>();
            CustomBuiltList<int> listThree = new CustomBuiltList<int>();
            string actual;
            string expected = "";

            //act
            listThree = listOne + listTwo;
            actual = listThree.ToString();

            //assert
            Assert.AreEqual(actual, expected);
        }

    }
}
