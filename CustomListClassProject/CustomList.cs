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
        string[] val = new string[4];
        public string this[int number]
        {
            get
            {
                if(number >= 0 && number < val.Length)
                {
                    return val[number];
                }
                return "Error.";
            }

            set
            {
                if(number >= 0 && number < val.Length)
                {
                    val[number] = value;
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
            items[listCount] = value;
            listCount++;

            //This is where I check to see if the capacity is full.  If it is, I need to expand the array.
            if (listCount == capacity)
            {
                
                //T[] tempList;
                
                
                //for(int i = 0; i < capacity; i++)
                //{
                //    items.RemoveFromList[i];
                //    T removedItem = [i];

                //}
            }
        }
    }
}
