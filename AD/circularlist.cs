using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AD.Collecction
{
    public class circularlist<T> : IEnumerable<T>, IEnumerator<T>
    {
        protected T[] items;
        protected int idex;
        protected bool load;
        protected int enumIdex;

        // Constructor that initializes the list with the 
        // required number of items.
        public circularlist(int numItems)
        {
            items = new T[numItems];
            idex = 0;
            load = false;
            enumIdex = -1;
        }

        // Gets/sets the item value at the current index.
        public T Value
        {
            get { return items[idex]; }
            set { items[idex] = value; }
        }

        //counts the number of items
        public int Count
        {
            get { return load ? items.Length : idex; }
        }

        // Gets/sets the value at the specified index.
        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }

        //moves to the next item in the list
        public void Next()
        {
            if (++idex == items.Length)
            {
                idex = 0;
                load = true;
            }
        }

        // Interface implementations:
        public T Current
        {
            get { return this[enumIdex]; }
        }

        object IEnumerator.Current
        {
            get { return this[enumIdex]; }
        }
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        public void Dispose()
        {
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
        //Moves onto the next item
        public bool MoveNext()
        {
            ++enumIdex;
            bool ret = enumIdex < Count;

            if (!ret)
            {
                Reset();
            }

            return ret;
        }
        //resets the enumindex
        public void Reset()
        {
            enumIdex = -1;
        }
    }
}