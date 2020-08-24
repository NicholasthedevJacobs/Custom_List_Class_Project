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

        }
    }
}
