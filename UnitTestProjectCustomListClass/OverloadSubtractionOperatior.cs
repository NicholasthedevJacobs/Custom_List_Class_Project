using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;

namespace UnitTestProjectCustomListClass
{
    [TestClass]
    public class OverloadSubtractionOperatior
    {
        [TestMethod]
        public void Subtract_Two_Lists_Check_Result()
        {
            //assign
            CustomBuiltList<int> listOne = new CustomBuiltList<int>();
            CustomBuiltList<int> listTwo = new CustomBuiltList<int>();
            CustomBuiltList<int> listThree = new CustomBuiltList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 1;
            int value5 = 5;
            int value6 = 6;
            string actual;
            string expected = "35";

            listOne.AddToList(value1);
            listOne.AddToList(value3);
            listOne.AddToList(value5);
            listTwo.AddToList(value2);
            listTwo.AddToList(value4);
            listTwo.AddToList(value6);

            //act
            listThree = listOne - listTwo;
            actual = listThree.ToString();

            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Subtract_Two_Lists_One_Is_Empty_Check_Result()
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
            listThree = listOne - listTwo;
            actual = listThree.ToString();

            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Subtract_Two_Lists_Both_Are_The_Same()
        {
            //assign
            CustomBuiltList<int> listOne = new CustomBuiltList<int>();
            CustomBuiltList<int> listTwo = new CustomBuiltList<int>();
            CustomBuiltList<int> listThree = new CustomBuiltList<int>();
            int value1 = 1;
            int value3 = 3;
            int value5 = 5;
            string actual;
            string expected = "";

            listOne.AddToList(value1);
            listOne.AddToList(value3);
            listOne.AddToList(value5);
            listTwo.AddToList(value1);
            listTwo.AddToList(value3);
            listTwo.AddToList(value5);

            //act
            listThree = listOne - listTwo;
            actual = listThree.ToString();

            //assert
            Assert.AreEqual(actual, expected);
        }

    }
}
