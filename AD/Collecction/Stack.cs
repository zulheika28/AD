using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Sort
{
    public class StackCollection<T>
    {
        //size of the array
        public int size;
        //the key of the last number
        public int topNum;
        public T[] stack1;

        public StackCollection(int arrSize)
        {
            //initialize the size of the new stack and created it
            size = arrSize;
            stack1 = new T[size];
            
        }

        public int push(T value)
        {
            //verify if there is an overflow
            if (topNum == size - 1)
            {
                // if there is return the value
                return -1;
            }
            else
            {
                // insert the value into the stack
                topNum = topNum + 1;
                stack1[topNum] = value;
            }
            return 0;
        }

        public T pop()
        {
            //value deleted
            T poppedValue;
            T temp = default(T);
            //verify if there is an underflow
            if (!(topNum <= 0))
            {
                //the top value is the one to go 
                poppedValue = stack1[topNum];
                //the top value then becomes the one below it
                topNum = topNum - 1;
                //show the value popped
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
            //iterate through the stack by copying from the array to the stack
            T[] Values = new T[topNum + 1];
            Array.Copy(stack1, 0, Values, 0, topNum + 1);
            return Values;
        }

    }
}
