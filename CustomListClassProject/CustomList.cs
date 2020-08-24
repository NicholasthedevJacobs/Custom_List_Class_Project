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

        CustomBuiltList<T> customList;

        //public CustomBuiltList<T> CustomList
        //{
        //    get
        //    {
        //        return customList;
        //    }
        //}

        //constructor
        public CustomBuiltList()
        {
            customList = new CustomBuiltList<T>();
            //CustomBuiltList<int> customObjectOne = new CustomBuiltList<int>();
        }

        //member variables
    }
}
