using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Sort
{
    public class StackCollection<T>
    {
        public int size;
        public int topNum;
        public T[] stack1;

        public StackCollection(int arrSize)
        {
            size = arrSize;
            stack1 = new T[size];
            
        }

        public int push(T value)
        {
            //Check Overflow
            if (topNum == size - 1)
            {
                // return -1 if over flow is there
                return -1;
            }
            else
            {
                // insert elementt into stack
                topNum = topNum + 1;
                stack1[topNum] = value;
            }
            return 0;
        }

        public T pop()
        {
            T poppedValue;
            T temp = default(T);
            //check Underflow
            if (!(topNum <= 0))
            {
                poppedValue = stack1[topNum];
                topNum = topNum - 1;
                return poppedValue;
            }
            return temp;

        }

        public T peep(int location)
        {
            T temp = default(T);
            //check if Position is Valid or not
            if (location < size && location >= 0)
            {
                return stack1[location];
            }
            return temp;
        }

        public T[] GetAllStackValues()
        {
            T[] Values = new T[topNum + 1];
            Array.Copy(stack1, 0, Values, 0, topNum + 1);
            return Values;
        }

    }
}
