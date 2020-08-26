using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class CustomBuiltList<T>
    {
        //member variables

        T[] items;

        int capacity;
        int listCount;      

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
                if(number >= 0 && number < items.Length)
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
                if(number >= 0 && number < items.Length)
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
        public void AddToList(T value)
        {          
            //This is where I check to see if the capacity is full.  If it is, I need to expand the array.
            if (listCount == capacity)
            {
                GenericSwapMethod(ref items);              
            }
            items[listCount] = value;
            listCount++;
        }
        public bool RemoveFromList(T value)
        {
            T[] placeHolderArray;
            placeHolderArray = new T[capacity];
            for (int i = 0; i < listCount; i++)
            {

                int place = i + 1; 
             
                if(value.Equals(place))
                {
                    return true;
                }
                else
                {
                    placeHolderArray[i] = items[i];
                    //Will have to add items back into a new list of 'items', 
                    //so it seems like the value was removed instead of moved around.
                }
            }
            return false;
        }
        //public override string ToString()
        //{
        //    return "ID: " + PartId + "   Name: " + PartName;
        //}
        private void GenericSwapMethod(ref T[] arrayToExtend)//Copies values from original array to newly created array.
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
