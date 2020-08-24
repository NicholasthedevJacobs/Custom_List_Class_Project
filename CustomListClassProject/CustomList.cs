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
        //T[] items = new T[4];
        public T this[int number]
        {
            get
            {
                if(number >= 0 && number < items.Length)
                {
                    return items[number];
                }
                Console.WriteLine("Error.");
                return items[number];
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
