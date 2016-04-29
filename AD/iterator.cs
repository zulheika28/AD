using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AD.Collecction
{
    public class iterator<T> : IEnumerable<T>
    {

        private T[] values = new T[100];
        private int tops = 0;

        //push will add the item to the top 
        public void Push(T t)
        {
            values[tops] = t;
            tops++;
        }
        public T Pop()
        {
            tops--;
            return values[tops];
        }

        // This method implements the GetEnumerator method. It allows
        // an instance of the class to be used in a foreach statement.
        public IEnumerator<T> GetEnumerator()
        {
            for (int indexs = tops - 1; indexs >= 0; indexs--)
            {
                yield return values[indexs];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<T> TopBottom
        {
            get { return this; }
        }

        //adds number from bottom to top e.g. 9 8 7 6 5 4
        public IEnumerable<T> Bottomtothetop
        {
            get
            {
                for (int indexs = 0; indexs <= tops - 1; indexs++)
                {
                    yield return values[indexs];
                }
            }
        }
        //Adds items from the top down eg. 0 1 2 3 4 5 6
        public IEnumerable<T> TopDown(int itemsfromthetop)
        {
            // Return less than itemsFromTop if necessary.
            int startIndexs = itemsfromthetop >= tops ? 0 : tops - itemsfromthetop;

            for (int indexs = tops - 1; indexs >= startIndexs; indexs--)
            {
                yield return values[indexs];
            }
        }

    }
}

