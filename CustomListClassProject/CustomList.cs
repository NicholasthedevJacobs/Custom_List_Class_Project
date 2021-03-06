﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class CustomBuiltList<T> : IEnumerable
    {
        //member variables

        T[] items;

        private int capacity;
        private int listCount;      

        public int ListCount
        {
            get
            {
                return listCount;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
        //Starting the indexer here
        public T this[int number]
        {
            get
            {
                if(number >= 0 && number < listCount)//changed from items.Length to listCount
                {
                    return items[number];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }                            
            }
            set
            {
                if(number >= 0 && number < listCount)//changed from items.Length to listCount
                {
                    items[number] = value;
                }
            }
        }
        //constructor
        public CustomBuiltList()
        {          
            listCount = 0;
            capacity = 4;
            items = new T[capacity];
        }
        //member methods
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < listCount; i++)
            {
                yield return items[i];
            }           
        }
        public static CustomBuiltList<T> operator + (CustomBuiltList<T> listOne, CustomBuiltList<T> listTwo)
        {
            CustomBuiltList<T> listThree = new CustomBuiltList<T>();
            for (int i = 0; i < listOne.listCount; i++)
            {              
                listThree.AddToList(listOne[i]);
            }
            for (int i = 0; i < listTwo.listCount; i++)
            {                
                listThree.AddToList(listTwo[i]);
            }
            
            return listThree;            
        }
        private static CustomBuiltList<T> CopyList(CustomBuiltList<T> listToCopy)
        {
            CustomBuiltList<T> copyList = new CustomBuiltList<T>();
            
            foreach (T value in listToCopy)
            {
                copyList.AddToList(value);
            }
           // copyList.RemoveExtraItemsFromList(copyList);
            return copyList;
        }
        public static CustomBuiltList<T> operator - (CustomBuiltList<T> listOne, CustomBuiltList<T> listTwo)
        {
            CustomBuiltList<T> listThree = CopyList(listOne);                      
            for (int i = 0; i < listTwo.listCount; i++)
            {               
                listThree.RemoveFromList(listTwo[i]);               
            }                    
            return listThree;
        }
        public CustomBuiltList<T> Zipper(CustomBuiltList<T> listOne, CustomBuiltList<T> listTwo)
        {
            CustomBuiltList<T> copyList = new CustomBuiltList<T>();
            CustomBuiltList<T> longList = new CustomBuiltList<T>();
            CustomBuiltList<T> shortList = new CustomBuiltList<T>();

            if (listOne.listCount >= listTwo.listCount)
            {
                longList = listOne;
                shortList = listTwo;
            }            
            else
            {
                shortList = listOne;
                longList = listTwo;
            }
            for (int i = 0; i < listOne.listCount + listTwo.listCount; i++)
            {
                copyList.AddToList(longList[i]);

                if (shortList.listCount > 0)
                {
                    copyList.AddToList(shortList[i]);
                    shortList.listCount--;
                }
            }
            return copyList;
        }
        public override string ToString()
        {
            string newString = "";
            for (int i = 0; i < listCount; i++)
            {
                newString += items[i].ToString();
            }
            return newString;
        }
        public void AddToList(T value)
        {        
            if (listCount == capacity)
            {
                GenericSwitchMethod(ref items);
            }
            
            items[listCount] = value;
            listCount++;          
        }
        public bool RemoveFromList(T value)
        {
            bool foundItemToRemove = false;

            T[] placeHolderArray;
            placeHolderArray = new T[listCount];//changed from capacity to listCount
          
            for (int i = 0, j = 0; i < listCount; i++, j++)
            {
                if (value.Equals(items[i]) && foundItemToRemove == false)
                {                       
                    j--;                        
                    foundItemToRemove = true;
                }
                else
                {                        
                    placeHolderArray[j] = items[i];
                }                                                         
            }
            if (foundItemToRemove == true)
            {
                
                listCount--;
            }
                items = placeHolderArray;            
            return foundItemToRemove;
        }
        private void GenericSwitchMethod(ref T[] arrayToExtend)//Copies values from original array to newly created array.
        {
            T[] placeHolderArray;
            placeHolderArray = new T[capacity * 2];

            for (int i = 0; i < capacity; i++)
            {
                placeHolderArray[i] = arrayToExtend[i];
            }
            ArrayExtender(ref arrayToExtend); 
            for(int i = 0; i < capacity; i++)
            {
                arrayToExtend[i] = placeHolderArray[i];
            }
        }
        private void ArrayExtender(ref T[] arrayToExtend)//Resizes Array to twice the previous size.
        {
            capacity = capacity * 2;
            arrayToExtend = new T[capacity];            
        }
    }
}
